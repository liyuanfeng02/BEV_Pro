using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;


namespace Common
{
    public enum MemoryAreaCode
    {
        CIOBit  = 0x30,//CIO区
        CIOWord = 0xB0,//CIO区
        WRBit   = 0x31,//W区
        WRWord  = 0xB1,//W区
        DMBit   = 0x02,//D区
        DMWord  = 0x82,//D区

    }
    public enum CommandType{
        Start,
        Read,
        Write
    };
    public class OmronFINS
    {
        Thread threadClientPLC = null; //PLC线程
        Socket sockClientPLC = null; //PLC套接字
        private byte PCNodeAddr;//PC节点地址
        private byte PLCNodeAddr;//PLC节点地址
        private bool IsStart = false;//开始FINS标志
        private bool IsRecFinish = false;//数据接收完成
        public string PcIPAddr { get; }
        public string PlcIPAddr { get; }
        public int PlcPort { get; }

        private byte[] RecMsgBuff = null;//plc数据接收缓冲区

        private byte[] FINS_Command = new byte[34] {
            0x46, 0x49, 0x4E, 0x53,//Header
            0x00, 0x00, 0x00, 0x1A,//Length
            0x00, 0x00, 0x00, 0x02,//Command
            0x00, 0x00, 0x00, 0x00,//ErrorCode
            0x80, 0x00, 0x02,      //ICF-RSV-GCT
            0x00, 0x67, 0x00,      //DNA-DA1-DA2
            0x00, 0x05, 0x00,      //SNA-SA1-SA2
            0x00,                  //SID
            0x01, 0x01,            //Fins_Command
            0x82,                  //Memory_Area
            0x00, 0x00, 0x00,      //Beginning_Addr
            0x00, 0x02             //num_of_itmes     one_of_items = 2byte
        };
        private delegate string ConnectSocketDelegate(IPEndPoint ipep, Socket sock);
        //public delegate void DealMessage(byte[] Message);
        //public event DealMessage DealMessagePlc;
        /// <summary>
        /// PLC FINS通信握手命令
        /// </summary>
        private byte[] StartConnectCommand
        {
            get
            {
                byte[] buff = new byte[20] {
                    0x46, 0x49, 0x4E, 0x53,//Header
                    0x00, 0x00, 0x00, 0x0C,//Length
                    0x00, 0x00, 0x00, 0x00,//Command
                    0x00, 0x00, 0x00, 0x00,//Error_code
                    0x00, 0x00, 0x00, PCNodeAddr,//Client_node_addr
                };
                return buff;
            }
        }
        public OmronFINS(string pcIp,string plcIP,int plcPort )
        {
            PcIPAddr = pcIp;
            PlcIPAddr = plcIP;
            PlcPort = plcPort;

        }
        private bool WaitForReply(CommandType commandType)
        {
            int timeCount = Environment.TickCount;
           
            while (!IsRecFinish)
            {
                if (Environment.TickCount > timeCount + 1000)                                 
                    return false;
                
            }
            if (commandType == CommandType.Start)
            {
                if(RecMsgBuff.Length == 24)
                {
                    byte[] errorCode = new byte[4];
                    Buffer.BlockCopy(RecMsgBuff, 12, errorCode, 0, 4);
                    if (BitConverter.ToString(errorCode) == "00-00-00-00")
                        return true;
                }
            }
            else if(commandType == CommandType.Write)
            {
                if (RecMsgBuff.Length == 30)
                {
                    if (RecMsgBuff[27] == 0x02)
                    {
                        byte[] errorCode = new byte[2];
                        Buffer.BlockCopy(RecMsgBuff, 28, errorCode, 0, 2);
                        if (BitConverter.ToString(errorCode) == "00-00")
                            return true;
                    }
                }
            }
            else if(commandType == CommandType.Read)
            {
                if (RecMsgBuff.Length > 30)
                {
                    if (RecMsgBuff[27] == 0x01)
                    {
                        byte[] errorCode = new byte[2];
                        Buffer.BlockCopy(RecMsgBuff, 28, errorCode, 0, 2);
                        if (BitConverter.ToString(errorCode) == "00-00")
                            return true;
                    }
                }
            }
            return false;
        }
        private void ListenPlcMsg()
        {
            while (IsStart)
            {
                int length = 0;
                byte[] arrMsgRec = new byte[512];    
                sockClientPLC.ReceiveBufferSize = 512;
                try
                {
                    length = sockClientPLC.Receive(arrMsgRec); // 接收数据，并返回数据的长度；
                    RecMsgBuff = new byte[length];
                    Buffer.BlockCopy(arrMsgRec, 0, RecMsgBuff, 0, length);
                    IsRecFinish = true;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }
        private string ConnectSocket(IPEndPoint ipep, Socket sock)
        {
            string exmessage = "";
            try
            {
                sock.Connect(ipep);
            }
            catch (System.Exception ex)
            {
                exmessage = ex.Message;
            }
            finally
            {
            }
            return exmessage;
        }
        private bool MySocketConnet(IPEndPoint ipep, Socket sock)
        {
            ConnectSocketDelegate connect = ConnectSocket;
            IAsyncResult asyncResult = connect.BeginInvoke(ipep, sock, null, null);
            bool connectSuccess = asyncResult.AsyncWaitHandle.WaitOne(200, false);
            string exmessage = connect.EndInvoke(asyncResult);
            if (!connectSuccess || exmessage != "")
            {
                return false;
            }
            return true;
        }
        public bool StartConnect()
        {
            try
            {
                //获取plc节点
                string[] arrPlcIP = PlcIPAddr.ToString().Split('.');
                byte[] arr_nodePlc = BitConverter.GetBytes(Convert.ToInt32(arrPlcIP[3]));
                PLCNodeAddr = arr_nodePlc[0];
                //获取pc节点
                string[] arrPcIP = PcIPAddr.ToString().Split('.');
                byte[] arr_nodePc = BitConverter.GetBytes(Convert.ToInt32(arrPcIP[3]));
                PCNodeAddr = arr_nodePc[0];
                //连接
                IPEndPoint endPoint = new IPEndPoint(IPAddress.Parse(PlcIPAddr), PlcPort);
                sockClientPLC = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                if (!MySocketConnet(endPoint, sockClientPLC))
                {
                    return false;
                }
                threadClientPLC = new Thread(ListenPlcMsg);
                threadClientPLC.IsBackground = true;
                threadClientPLC.Start();
                IsRecFinish = false;
                IsStart = true;
                sockClientPLC.Send(StartConnectCommand);
                return WaitForReply(CommandType.Start);


            }
            catch
            {
                return false;
            }

        }
        public void StopConnect()
        {
            try
            {
                if (IsStart)
                {
                    IsStart = false;
                    threadClientPLC.Abort();
                    sockClientPLC.Close();
                    sockClientPLC.Dispose();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// FINS写欧姆龙PLC
        /// </summary>
        /// <param name="byt_rom_area">内存区域</param>
        /// <param name="start_addr">起始地址(3个字节)按位写入前两字节表示字地址，最后字节表示位地址，按字写入同理最后字节忽略</param>
        /// <param name="send_data">写入数据</param>
        /// <returns></returns>
        public bool WriteCommand(MemoryAreaCode byt_rom_area, byte[] start_addr, byte[] send_data)
        {
            try
            {
                byte[] arr_write_command = FINS_Command; //34个byte
                byte[] fins_send_buff;//发送数据缓冲区
                                      //send_data
                if (send_data.Length % 2 == 1)//奇数
                {
                    if (byt_rom_area == MemoryAreaCode.CIOBit ||
                        byt_rom_area == MemoryAreaCode.DMBit ||
                        byt_rom_area == MemoryAreaCode.WRBit)//按位写
                    {
                        fins_send_buff = send_data;
                    }
                    else
                    {
                        fins_send_buff = new byte[send_data.Length + 1];
                        Buffer.BlockCopy(send_data, 0, fins_send_buff, 0, send_data.Length);
                        fins_send_buff[fins_send_buff.Length - 1] = 0x00;
                    }
                }
                else
                {
                    fins_send_buff = send_data;
                }
                //num_of_itmes
                byte[] arr_data_len;
                if (byt_rom_area == MemoryAreaCode.CIOBit ||
                    byt_rom_area == MemoryAreaCode.DMBit ||
                    byt_rom_area == MemoryAreaCode.WRBit)//按位写
                {
                    arr_data_len = BitConverter.GetBytes(fins_send_buff.Length);
                }
                else
                {
                    arr_data_len = BitConverter.GetBytes(fins_send_buff.Length / 2);

                }
                Array.Reverse(arr_data_len);
                Buffer.BlockCopy(arr_data_len, 2, arr_write_command, 32, 2);
                //length
                int len = 34 - 8 + fins_send_buff.Length;
                byte[] arr_len = BitConverter.GetBytes(len);
                Array.Reverse(arr_len);
                Buffer.BlockCopy(arr_len, 0, arr_write_command, 4, 4);
                //目标节点
                arr_write_command[20] = PLCNodeAddr;
                //源节点
                arr_write_command[23] = PCNodeAddr;

                arr_write_command[26] = 0x01;//Fins_Command_H
                arr_write_command[27] = 0x02;//Fins_Command_L写
                                             //Memory_Area
                arr_write_command[28] = (byte)byt_rom_area;

                arr_write_command[29] = start_addr[0];
                arr_write_command[30] = start_addr[1];
                arr_write_command[31] = start_addr[2];

                byte[] all_send_buff = new byte[34 + fins_send_buff.Length];
                Buffer.BlockCopy(arr_write_command, 0, all_send_buff, 0, 34);
                Buffer.BlockCopy(fins_send_buff, 0, all_send_buff, 34, fins_send_buff.Length);
                IsRecFinish = false;
                sockClientPLC.Send(all_send_buff);
                
                return WaitForReply(CommandType.Write);
            }
            catch
            {
                return false;
            }
        }
        /// <summary>
        /// FINS读取欧姆龙PLC
        /// </summary>
        /// <param name="byt_rom_area">内存区域</param>
        /// <param name="start_addr">起始地址(3个字节)按位读取前两字节表示字地址，最后字节表示位地址，按字读取同理最后字节忽略</param>
        /// <param name="length">字长/位数量</param>
        /// <returns>高字节[0]、低字节[1]</returns>      
        public byte[] ReadCommand(MemoryAreaCode byt_rom_area, byte[] start_addr, int length)
        {
            try
            {
                byte[] arr_read_command = FINS_Command;//34byte
                //arr_read_command[7] = 0x1A;//length固定
                int len = 34 - 8;
                byte[] arr_len = BitConverter.GetBytes(len);
                Array.Reverse(arr_len);
                Buffer.BlockCopy(arr_len, 0, arr_read_command, 4, 4);

                arr_read_command[20] = PLCNodeAddr;//目标节点
                arr_read_command[23] = PCNodeAddr;//源节点

                arr_read_command[26] = 0x01;//Fins_Command_H
                arr_read_command[27] = 0x01;//Fins_Command_L读

                arr_read_command[28] = (byte)byt_rom_area;//读取区域

                arr_read_command[29] = start_addr[0];
                arr_read_command[30] = start_addr[1];
                arr_read_command[31] = start_addr[2];

                byte[] arr_count = BitConverter.GetBytes(length);
                Array.Reverse(arr_count);//
                Buffer.BlockCopy(arr_count, 2, arr_read_command, 32, 2); //num_of_itmes
                IsRecFinish = false;
                sockClientPLC.Send(arr_read_command);                
                bool res =  WaitForReply(CommandType.Read);
                if(res)
                {
                    byte[] data = new byte[RecMsgBuff.Length - 30];
                    Buffer.BlockCopy(RecMsgBuff, 30, data, 0, data.Length);
                    return data;
                }
                return null;
            }
            catch
            {
                return null;
            }
        }
    }
}

