using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace Common
{
    public enum JUDGE_TYPE
    {
        OK,
        NG,
        ER
    }
    public struct IV2Tpye
    {
        public string TypeName;//摄像头型号
        public string Version;//版本号
    }

    public struct IV2ToolResult
    {
        public string ToolNo;//编号，2位
        public string Judge;//判定，2位，--无法判定
        public string Similarity;//相似度，固定7位
    }

    public struct IV2StandardResult
    {
        public string HeaderComm;//命令头，2位
        public string ResultNo;//结果编号，5位
        public JUDGE_TYPE AllJudge;//总判定，2位
        public IV2ToolResult[] iV2ToolResults;//工具结果
    }
    class IV2Navigator
    {
        Thread threadClient = null; 
        Socket sockClient = null; 
        private bool IsStart = false;//线程开始标志
        /// <summary>
        /// 数据接收完成标志位，true:数据包接收成功；false:数据包处理完成
        /// </summary>
        private bool IsRecFinish = false;
        public string PcIPAddr { get; }
        public string IV2IPAddr { get; }
        public int IV2Port { get; }

        private byte[] RecMsgBuff = null;//c数据接收缓冲区

        private delegate string ConnectSocketDelegate(IPEndPoint ipep, Socket sock);

        public IV2Navigator(string pcIp, string iv2IP, int iv2Port)
        {
            PcIPAddr = pcIp;
            IV2IPAddr = iv2IP;
            IV2Port = iv2Port;
        }
        private bool WaitForReply()
        {
            int timeCount = Environment.TickCount;
            while (!IsRecFinish)
            {
                if (Environment.TickCount == timeCount + 500)
                    return false;
            }
         
            return true;
        }
        private byte[] IV2SendCommand(string sendData)
        {
            try
            {
                IsRecFinish = false;
                sockClient.Send(Encoding.Default.GetBytes(sendData));                
                if (WaitForReply())
                {
                    if(RecMsgBuff[RecMsgBuff.Length-1] == 0x0D)
                        return RecMsgBuff;
                }
                return null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// 触发并读取结果
        /// </summary>
        /// <returns></returns>
        public IV2StandardResult TriggerGetResult()
        {
            string strResult;
            IV2StandardResult iV2Result = new IV2StandardResult();
            string commBuff = "T2";
            byte[] bytResult = IV2SendCommand(commBuff + "\r");
            if(bytResult != null)
            {
                strResult = Encoding.Default.GetString(bytResult,0, bytResult.Length-1);//去掉CR结束符
                string[] arrResult = strResult.Split(',');
                if(arrResult[0] == "RT")
                {
                    iV2Result.HeaderComm = arrResult[0];
                    iV2Result.ResultNo = arrResult[1];
                    iV2Result.AllJudge = arrResult[2] == "OK" ? JUDGE_TYPE.OK : JUDGE_TYPE.NG;
                    int toolNum = arrResult.Length / 3 - 1;
                    IV2ToolResult[] iV2ToolResults = new IV2ToolResult[toolNum];
                    for(int i = 0;i<toolNum;i++)
                    {
                        iV2ToolResults[i].ToolNo = arrResult[3 + i * 3];//345/678/91011
                        iV2ToolResults[i].Judge = arrResult[4 + i * 3];
                        iV2ToolResults[i].Similarity = arrResult[5 + i * 3];
                    }
                    iV2Result.iV2ToolResults = iV2ToolResults;
                }
                else
                {
                    iV2Result.AllJudge = JUDGE_TYPE.ER;
                }
            }
            else
            {
                iV2Result.AllJudge = JUDGE_TYPE.ER;
            }
            return iV2Result;
        }
        /// <summary>
        /// 单向控制设备只需获取命令是否执行成功
        /// </summary>
        /// <param name="commBuff"></param>
        /// <returns></returns>
        private bool ControlDevice(string commBuff)
        {
            string strResult;
            byte[] bytResult = IV2SendCommand(commBuff);
            if (bytResult != null)
            {
                strResult = Encoding.Default.GetString(bytResult, 0, bytResult.Length - 1);//去掉CR结束符
                if (strResult.Substring(0, 2) == commBuff.Substring(0,2))
                    return true;
            }
            return false;
        }
        /// <summary>
        /// 更改识别工具的阈值
        /// </summary>
        /// <param name="toolNo">工具编号</param>
        /// <param name="val">值</param>
        /// <returns></returns>
        public bool AlterToolThresholdVal(int toolNo,int val)
        {
            string strComm = "DM," + toolNo.ToString("00")+",0," + val.ToString("0000");
            return ControlDevice(strComm);
        }
        /// <summary>
        /// 获取设备版本号
        /// </summary>
        /// <returns></returns>
        public IV2Tpye GetDeviceVer()
        {
            IV2Tpye iV2Tpye = new IV2Tpye();
            string strResult;
            byte[] bytResult = IV2SendCommand("VI\r");
            if (bytResult != null)
            {
                strResult = Encoding.Default.GetString(bytResult, 0, bytResult.Length - 1);//去掉CR结束符
                if (strResult.Substring(0, 2) == "VI")
                {
                    string[] arrResult = strResult.Split(',');
                    iV2Tpye.TypeName = arrResult[0];
                    iV2Tpye.Version = arrResult[1];
                }
            }
            return iV2Tpye;
        }
        /// <summary>
        ///获取识别工具通道的阈值
        /// </summary>
        /// <param name="toolNo"></param>
        /// <returns></returns>
        public int GetToolThresholdVal(int toolNo)
        {
            int val = 0;
            string strResult;
            byte[] bytResult = IV2SendCommand("DR,"+toolNo.ToString("00")+",0\r");
            if (bytResult != null)
            {
                strResult = Encoding.Default.GetString(bytResult, 0, bytResult.Length - 1);//去掉CR结束符
                if (strResult.Substring(0, 2) == "DR")
                {
                    string[] arrResult = strResult.Split(',');
                    val = Int32.Parse(arrResult[3]);
                }
            }
            return val;
        }
        /// <summary>
        /// 触发拍照
        /// </summary>
        /// <returns></returns>
        public bool TriggerDevice()
        {
            return ControlDevice("T1\r");
        }
        /// <summary>
        /// 切换程序编号
        /// </summary>
        /// <param name="progNo">程序编号，最大32</param>
        /// <returns></returns>
        public bool ChangeProgNo(int progNo)
        {
            string strComm = "PW," + progNo.ToString("000") + "\r";
            return ControlDevice(strComm);
        }
        /// <summary>
        /// 自动结果发送开关
        /// </summary>
        /// <param name="para">true:开，false:关</param>
        /// <returns></returns>
        public bool AutoResultSwitch(bool para)
        {
            string strComm = "OE," + (para ? "1" : "0") + "\r";
            return ControlDevice(strComm);
        }
        private void ListenSocket()
        {
            while (IsStart)
            {
                int length = 0;
                byte[] arrMsgRec = new byte[512];
                sockClient.ReceiveBufferSize = 512;
                try
                {
                    length = sockClient.Receive(arrMsgRec); // 接收数据，并返回数据的长度；
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
                //连接
                IPEndPoint endPoint = new IPEndPoint(IPAddress.Parse(IV2IPAddr), IV2Port);
                sockClient = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                if (!MySocketConnet(endPoint, sockClient))
                {
                    return false;
                }
                IsStart = true;               
                threadClient = new Thread(ListenSocket);
                threadClient.IsBackground = true;
                threadClient.Start();                
                return true;
            }
            catch
            {
                return false;
            }

        }
    }
}
