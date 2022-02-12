using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Common;
using System.IO.Ports;
using System.IO;

namespace Common
{
    class OmronFinsUdp
    {
        Thread ThreadClient = null;
        Socket UdpClient = null;
        public EndPoint TargetPoint;
        public string LocalIP { get; }
        public int LocalPort { get; }
        public bool IsSendFinsh = true;
        public bool IsRecData = false;
        private byte[] RecBuff = new byte[512];
        private byte[] FinsHeader = new byte[12];
        public byte[] RecAddr = new byte[3];//本设备接收的内存地址
        public byte RecIpNode;//发送过来数据的IP节点
        public int RecDataLen = 0;//接收到真正的数据长度
        public OmronFinsUdp(string localIP,int localPort)
        {
            LocalIP = localIP;
            LocalPort = localPort;
            string[] arrlocalIP = LocalIP.ToString().Split('.');
            byte[] arr_node = BitConverter.GetBytes(Convert.ToInt32(arrlocalIP[3]));
            byte localNode = arr_node[0];

            FinsHeader[0] = 0x80;           //ICF
            FinsHeader[1] = 0x00;           //REV
            FinsHeader[2] = 0x02;           //GCT
            FinsHeader[3] = 0x00;           //DNA
            FinsHeader[4] = 0x01;           //DA1
            FinsHeader[5] = 0x00;           //DA2
            FinsHeader[6] = 0x00;           //SNA
            FinsHeader[7] = localNode;      //SA1
            FinsHeader[8] = 0x00;           //SA2
            FinsHeader[9] = 0x00;           //SID
            FinsHeader[10] = 0x01;          //MRC     //写
            FinsHeader[11] = 0x02;          //SRC

        }
        public bool StartBind()
        {
            IPEndPoint endPoint = new IPEndPoint(IPAddress.Parse(LocalIP), LocalPort);//本地IP端口
            UdpClient = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            try
            {
                UdpClient.Bind(endPoint);
            }
            catch
            {
                return false;
            }
            ThreadClient = new Thread(RecUdpMsg);
            ThreadClient.IsBackground = true;
            ThreadClient.Start();
            return true;
        }
        private void RecUdpMsg()
        {
            while (true)
            {
                try
                {
                    EndPoint recPoint = new IPEndPoint(IPAddress.Any, 0);
                    byte[] buffer = new byte[1024];
                    int length = UdpClient.ReceiveFrom(buffer, ref recPoint);
                    RecDataLen = RecDataResponse(buffer, length);
                    if(RecDataLen != 0)
                        IsRecData = true;
                }
                catch (Exception e)
                {
                    throw e;
                }
            }
        }
        private int RecDataResponse(byte[] buffer,int length)
        {
            try
            {
                if (length >= 18)//对接收到的数据进行应答
                {
                    byte[] rpeBuff = new byte[14];
                    rpeBuff[0] = 0xc0;             //ICF
                    rpeBuff[1] = buffer[1];        //REV
                    rpeBuff[2] = buffer[2];        //GCT
                    rpeBuff[3] = buffer[6];        //DNA
                    rpeBuff[4] = buffer[7];        //DA1
                    rpeBuff[5] = buffer[8];        //DA2
                    rpeBuff[6] = buffer[3];        //SNA
                    rpeBuff[7] = buffer[4];        //SA1
                    rpeBuff[8] = buffer[5];        //SA2
                    rpeBuff[9] = buffer[9];        //SID
                    rpeBuff[10] = buffer[10];      //MRC     //写
                    rpeBuff[11] = buffer[11];      //SRC
                    rpeBuff[12] = 0x00;            //MRCS
                    rpeBuff[13] = 0x00;            //SRCS

                    RecIpNode = buffer[7];
                    string[] targetIpArr = LocalIP.Split('.');
                    string repIP = targetIpArr[0] + "." + targetIpArr[1] + "." + targetIpArr[2] + "." + RecIpNode.ToString();
                    TargetPoint = new IPEndPoint(IPAddress.Parse(repIP), LocalPort);
                    UdpClient.SendTo(rpeBuff, TargetPoint);
                    //获取接收地址
                    RecAddr[0] = buffer[13];
                    RecAddr[1] = buffer[14];
                    RecAddr[2] = buffer[15];

                    //RecIpNode[0] = buffer[6];
                    RecIpNode = buffer[7];
                    //RecIpNode[2] = buffer[8];
                    int dataLen = length - 18;
                    if(dataLen > 0)
                    {
                        for (int i = 0; i < 512; i++)
                            RecBuff[i] = 0x00;
                        Buffer.BlockCopy(buffer, 18, RecBuff, 0, dataLen);
                        return dataLen;
                    }
                }
                else//发送出去的数据的应答
                {
                    IsSendFinsh = true;
                }
                return 0;
            }
            catch
            {
                return 0;
            }
        }
        public bool Write(byte[] sData,byte[] addrDM ,string targetIP,int targetPort)//只写入DM
        {
            try
            {
                byte[] writeBuff = new byte[18 + sData.Length];
                string[] arrTargetIP = targetIP.ToString().Split('.');
                byte[] arr_node = BitConverter.GetBytes(Convert.ToInt32(arrTargetIP[3]));
                byte targetNode = arr_node[0];
                FinsHeader[4] = targetNode;//DA1
                TargetPoint = new IPEndPoint(IPAddress.Parse(targetIP), targetPort);//目标IP端口
                short wordCount;
                if (sData.Length % 2 == 0)
                    wordCount = (short)(sData.Length / 2);
                else
                    wordCount = (short)((sData.Length + 1) / 2);
                byte[] wordCountB = BitConverter.GetBytes(wordCount);
                Buffer.BlockCopy(FinsHeader, 0, writeBuff, 0, 12);
                writeBuff[12] = 0x82;//DM区
                writeBuff[13] = addrDM[0];//addr_H
                writeBuff[14] = addrDM[1];//addr_L
                writeBuff[15] = 0x00;//addr_Bit

                writeBuff[16] = wordCountB[1];//dataLen_H
                writeBuff[17] = wordCountB[0];//dataLen_L
                Buffer.BlockCopy(sData, 0, writeBuff, 18, sData.Length);
                IsSendFinsh = false;
                UdpClient.SendTo(writeBuff, TargetPoint);

                return true;
            }
            catch
            {
                return false;
            }
        }
        
        public byte[] RecData()
        { 
            IsRecData = false;
            return RecBuff;
        }
    }
}
