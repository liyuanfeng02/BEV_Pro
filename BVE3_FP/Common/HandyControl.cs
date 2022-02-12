using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.IO.Ports;

namespace Common
{//推到远程master
    struct HandyData
    {
        public string spd;//局编号
        public string ch;//拧紧CH编号
        public string fs_count;//拧紧次数
        public string date;//拧紧年月日时分秒
        public string judge;//判定结果
        public string f_trq;//最终扭矩
        public string f_ang;//最终角度
        public string fs_time;//最终拧紧时间
        public string tl_time;//拧紧总时间
        public string job;//job编号
        public string step;//step编号
        public string count;//计数
        public string rundown_time;//run角度
        public string low_f_trq;//最终扭矩设定下限
        public string hig_f_trq;//最终扭矩设定上限
        public string pos_x;//x坐标
        public string pos_y;//y坐标
        public string pos_z;//z坐标
        public int length;//数据包长度
    }
    class HandyControl
    {
      
        public string HandyIP;
        public string HandyPort = "4545";
        public SerialPort HandySerial;
        public HandyData handyData = new HandyData {};
        private Socket sockClientHandy = null; //智能电批
        private delegate string ConnectSocketDelegate(IPEndPoint ipep, Socket sock);
        private bool NewDataFlat = false;
        public HandyControl(SerialPort handySerial, string handyIP = "192.168.1.2",string handyPort = "4545")
        {
            HandySerial = handySerial;
            HandyIP = handyIP;
            HandyPort = handyPort;
            HandySerial.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(SerialHandyDataReceived);
        }
        public bool SerialPortOpen(string portName,int baudRate)
        {
            try
            {
                HandySerial.PortName = portName;
                HandySerial.BaudRate = baudRate;
                HandySerial.Parity = System.IO.Ports.Parity.None;
                HandySerial.DataBits = 8;
                HandySerial.StopBits = System.IO.Ports.StopBits.One;
                HandySerial.ReceivedBytesThreshold = 1;
                HandySerial.Open();
            }
            catch
            {
                return false;
            }
            return true;
        }
        public bool SerialPortClose()
        {
            try
            {
                if(HandySerial.IsOpen)
                    HandySerial.Close();
            }
            catch
            {
                return false;
            }
            return true;
        }
        private void SerialHandyDataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            PublicValue.Delay(50);
            int len = HandySerial.BytesToRead;//获取可以读取的字节数
            byte[] buff = new byte[len];//创建缓存数据数组
            HandySerial.Read(buff, 0, len);//把数据读取到buff数组
            if (buff.Length == 293)
            {
                if (buff[0] == 0x02 && buff[291] == 0x03)// && buff[284] == 0x03
                {
                    HandySerial.Write(new byte[1] { 0x06 }, 0, 1);//应答成功
                    handyData.ch = Encoding.Default.GetString(buff, 3, 2);
                    handyData.date = Encoding.Default.GetString(buff, 13, 12);
                    handyData.judge = Encoding.Default.GetString(buff, 25, 1);
                    handyData.f_trq = Encoding.Default.GetString(buff, 26, 7);
                    handyData.f_ang = Encoding.Default.GetString(buff, 33, 7);
                    handyData.rundown_time = Encoding.Default.GetString(buff, 134, 7);
                    handyData.low_f_trq = Encoding.Default.GetString(buff, 194, 7);
                    handyData.hig_f_trq = Encoding.Default.GetString(buff, 201, 7);
                    handyData.pos_x = Encoding.Default.GetString(buff, 266, 6);
                    handyData.pos_y = Encoding.Default.GetString(buff, 272, 6);
                    handyData.pos_z = Encoding.Default.GetString(buff, 278, 6);
                    handyData.length = buff.Length;
                    NewDataFlat = true;
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
            return exmessage;
        }
        private bool MySocketConnet(IPEndPoint ipep, Socket sock)
        {
            ConnectSocketDelegate connect = ConnectSocket;
            IAsyncResult asyncResult = connect.BeginInvoke(ipep, sock, null, null);
            bool connectSuccess = asyncResult.AsyncWaitHandle.WaitOne(200, false);
            return connectSuccess;
        }
        public HandyData GetSerialData()
        {
            if(NewDataFlat)
            {
                NewDataFlat = false;
            }
            else
            {
                handyData.length = 0;//如果为0则不是新的数据
            }
            return handyData;
        }
        public bool SelectJob(int jobNo)
        {
            IPAddress ip = IPAddress.Parse(HandyIP);
            IPEndPoint endPoint = new IPEndPoint(ip, int.Parse(HandyPort));
            sockClientHandy = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            bool Staus = MySocketConnet(endPoint, sockClientHandy);
            if (Staus == true)
            {
                byte[] Handy_Start = new byte[] { 0x30, 0x30, 0x32, 0x30, 0x30, 0x30, 0x30, 0x31, 0x30, 0x30,
                    0x31, 0x20, 0x20, 0x20, 0x20, 0x20, 0x20, 0x20, 0x20, 0x20, 0x00 };

                byte[] byte_job_num = Encoding.Default.GetBytes(jobNo.ToString("00"));
                byte[] Handy_Select = new byte[] { 0x30, 0x30, 0x32, 0x32, 0x30, 0x30, 0x33, 0x38, 0x30, 0x30,
                    0x31, 0x20, 0x20, 0x20, 0x20, 0x20, 0x20, 0x20, 0x20, 0x20, byte_job_num[0], byte_job_num[1], 0x00 };

                byte[] Handy_Reset = new byte[] { 0x30, 0x30, 0x32, 0x32, 0x30, 0x30, 0x33, 0x39, 0x30, 0x30,
                    0x31, 0x20, 0x20, 0x20, 0x20, 0x20, 0x20, 0x20, 0x20, 0x20, byte_job_num[0], byte_job_num[1], 0x00 };
                sockClientHandy.Send(Handy_Start); // 握手；
                Thread.Sleep(20);
                sockClientHandy.Send(Handy_Select); // 选择任务组；
                sockClientHandy.Close();
            }
            return Staus;
        }
        public bool JobReset(int jobNo)
        {
            IPAddress ip = IPAddress.Parse(HandyIP);
            IPEndPoint endPoint = new IPEndPoint(ip, int.Parse(HandyPort));
            sockClientHandy = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            bool Staus = MySocketConnet(endPoint, sockClientHandy);
            if (Staus == true)
            {
                byte[] Handy_Start = new byte[] { 0x30, 0x30, 0x32, 0x30, 0x30, 0x30, 0x30, 0x31, 0x30, 0x30,
                    0x31, 0x20, 0x20, 0x20, 0x20, 0x20, 0x20, 0x20, 0x20, 0x20, 0x00 };
                byte[] byte_job_num = Encoding.Default.GetBytes(jobNo.ToString("00"));
                byte[] Handy_Reset = new byte[] { 0x30, 0x30, 0x32, 0x32, 0x30, 0x30, 0x33, 0x39, 0x30, 0x30,
                    0x31, 0x20, 0x20, 0x20, 0x20, 0x20, 0x20, 0x20, 0x20, 0x20, byte_job_num[0], byte_job_num[1], 0x00 };
                sockClientHandy.Send(Handy_Start); // 握手；
                Thread.Sleep(20);
                sockClientHandy.Send(Handy_Reset); // 复位；
                sockClientHandy.Close();
            }
            return Staus;
        }
        public bool OpenJobMode()
        {
            IPAddress ip = IPAddress.Parse(HandyIP);
            IPEndPoint endPoint = new IPEndPoint(ip, int.Parse(HandyPort));
            sockClientHandy = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            bool Staus = MySocketConnet(endPoint, sockClientHandy);
            if (Staus == true)
            {
                byte[] Handy_Start = new byte[] { 0x30, 0x30, 0x32, 0x30, 0x30, 0x30, 0x30, 0x31, 0x30, 0x30,
                    0x31, 0x20, 0x20, 0x20, 0x20, 0x20, 0x20, 0x20, 0x20, 0x20, 0x00 };

                byte[] Handy_ON = new byte[] { 0x30, 0x30, 0x32, 0x31, 0x30, 0x31, 0x33, 0x30, 0x30, 0x30,
                    0x31, 0x20, 0x20, 0x20, 0x20, 0x20, 0x20, 0x20, 0x20, 0x20, 0x31, 0x00 };
                sockClientHandy.Send(Handy_Start); // 握手；
                Thread.Sleep(20);
                sockClientHandy.Send(Handy_ON); // 选择任务组；
                sockClientHandy.Close();
            }
            return Staus;
        }
        public bool CloseJobMode()
        {
            IPAddress ip = IPAddress.Parse(HandyIP);
            IPEndPoint endPoint = new IPEndPoint(ip, int.Parse(HandyPort));
            sockClientHandy = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            bool Staus = MySocketConnet(endPoint, sockClientHandy);
            if (Staus == true)
            {
                byte[] Handy_Start = new byte[] { 0x30, 0x30, 0x32, 0x30, 0x30, 0x30, 0x30, 0x31, 0x30, 0x30,
                    0x31, 0x20, 0x20, 0x20, 0x20, 0x20, 0x20, 0x20, 0x20, 0x20, 0x00 };

                byte[] Handy_OFF = new byte[] { 0x30, 0x30, 0x32, 0x31, 0x30, 0x31, 0x33, 0x30, 0x30, 0x30,
                    0x31, 0x20, 0x20, 0x20, 0x20, 0x20, 0x20, 0x20, 0x20, 0x20, 0x30, 0x00 };
                sockClientHandy.Send(Handy_Start); // 握手；
                Thread.Sleep(20);
                sockClientHandy.Send(Handy_OFF);
                sockClientHandy.Close();
            }
            return Staus;
        }
        private bool SelectChannel(int chNo)
        {
            byte[] byte_ch_num = Encoding.Default.GetBytes(chNo.ToString("00"));
            IPAddress ip = IPAddress.Parse(HandyIP);
            IPEndPoint endPoint = new IPEndPoint(ip, int.Parse(HandyPort));
            sockClientHandy = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            bool Staus = MySocketConnet(endPoint, sockClientHandy);
            if (Staus == true)
            {
                byte[] Handy_Start = new byte[] { 0x30, 0x30, 0x32, 0x30, 0x30, 0x30, 0x30, 0x31, 0x30, 0x30,
                    0x31, 0x20, 0x20, 0x20, 0x20, 0x20, 0x20, 0x20, 0x20, 0x20, 0x00 };

                byte[] ChSwitch = new byte[] { 0x30, 0x30, 0x32, 0x33, 0x30, 0x30, 0x31, 0x38, 0x30, 0x30,
                    0x31, 0x20, 0x20, 0x20, 0x20, 0x20, 0x20, 0x20, 0x20, 0x20, 0x30, byte_ch_num[0],byte_ch_num[1], 0x00 };
                sockClientHandy.Send(Handy_Start); // 握手；
                Thread.Sleep(20);
                sockClientHandy.Send(ChSwitch);
                sockClientHandy.Close();
            }
            return Staus;
        }

    }
}
