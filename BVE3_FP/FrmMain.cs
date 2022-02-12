/***********************************更新日志******************************************/
//Ver1.0.0.0 →Ver1.0.1.0    2021.08.26  LYF
//1.追加扫入QR所有部品的格式校验
//2.追加光标扫描仪的兼容使用与启用配置
//3.优化IP获取失败提示
//4.网络不佳时PLC读取有可能返回NULL值修正
//5.暂时屏蔽CCD检查
//6.屏蔽取螺钉信号检测
//7.CCD屏蔽开放到配置文件
//8.追加软件自动更新
//9.水冷板保险丝QR屏蔽
//Ver1.0.1.0 →Ver1.0.1.1    2021.08.30  LYF
//1.检查机三合一
//2.复位时清除电批数据的残留
//3.解除水冷板和保险丝QR的触发
//Ver1.0.1.1 →Ver1.0.1.2    2021.09.05  LYF
//1.配置文件新增检查机设定
//2.追加三台检查机自身追溯功能
//3.开放选中表格使用光标扫描读取
//Ver1.0.1.2 →Ver1.0.1.3    2021.09.07  LYF
//1.优化组立2扫码的流程
//2.生产指示书扫码的优化,组立的时候PanaTextBox可编辑
//3.优化检查机的通信数据统一使用检查机的数据包括作业员等
//4.优化点检数据残留问题
//5.追加跳过的CCD执行气缸动作
//Ver1.0.1.3 →Ver1.0.1.4    2021.09.09  LYF
//1.完善组立9功能流程
//2.检查机工程画面的设备号更新
//3.工程名代码修正
//4.CCD检查追加3秒延时
//5.优化BDSB预组立气缸动作
//6.扫描仪连续触发时追加延时50ms
//7.优化预组立Pana铭板清空问题
//8.点检数据残留问题再优化
//9.优化检查机NG时追溯失败
//Ver1.0.1.4 →Ver1.0.1.5    2021.09.13  LYF
//1.将保险丝QR读入从组立7移动到组立6，并追加配置文件保险丝扫描感应的点位
//2.配置文件追加组立6和组立2的治具升降到位信号
//3.组立2追加治具升起步骤
//4.组立6的第二把电批要打6个螺钉需要调整为5个
//5.组立6追加治具升起步骤
//6.追加第三个CCD的画面与文件配置
//7.追加与MES通信的日志保留
//8.追加程序不可重复打开
//9.DisplayClear中不清空txtQRScan.Text
//10.光标扫描追加Keys.ShiftKey判断
//Ver1.0.1.5 →Ver1.0.1.6    2021.09.13  LYF
//1.修正保险螺丝螺钉对应的通道切换
//2.修正日志保存存在的重复内容
//Ver1.0.1.6 →Ver1.0.1.7    2021.09.13  LYF
//1.修正第3个CCD的初始化
//Ver1.0.1.7 →Ver1.0.1.8    2021.09.14  LYF
//1.修正工程代码  
//Ver1.0.1.8 →Ver1.0.1.9    2021.09.17  LYF
//1.追加Typeconfig式样文件配置
//2.追加CCD的多通道识别
//3.追加错误码显示
//4.修正部品混入子项目不显示NG
//5.优化等待MES反馈的项目显示
//6.优化接收MES日志，将记录函数放入接收线程中
//7.追加跳过CCD设定画面
//8.追加重复作业画面选择及文件配置，以及逻辑逻辑处理，只针对本体组立
//9.取消立即触发托盘扫描仪
//10.追加CCD关闭时无法拍照提示
//11.追加CCD检查NG时进行人工判定
//Ver1.0.1.9 →Ver1.0.2.0    2021.09.17  LYF
//1.优化跳过CCD的配置文件逻辑相反
//Ver1.0.2.0 →Ver1.0.2.1    2021.09.17  LYF
//1.修正检查机与MES进行本工程确认时通信数据的错误
//Ver1.0.2.1 →Ver1.0.2.2    2021.09.18  LYF
//1.组立9本工程OK后解除气缸优化
//2.追加组立4多一个CCD检查
//Ver1.0.2.2 →Ver1.0.2.3    2021.09.23  LYF
//1.优化复位MES数据和光标扫描数据的缓冲
//2.开放托盘扫描仪
//3.优化进入下一步骤时清空光标QR和电批数据
//Ver1.0.2.3 →Ver1.0.2.4    2021.09.23  LYF
//1.组立6追加第二个CCD
//2.CCD检查切换通道后追加延时处理1s
//Ver1.0.2.4 →Ver1.0.2.5    2021.09.26  LYF
//1.追加PLC通信异常监控5s通信失败报警后报警
//2.追加A1A2A3式样的配置,根据制品铭板的品番区别式样，品番配置在TypeConfig.csv中
//3.追加图片路径配置
//4.追加图片监控功能，是否监控选项
//5.追加CCD4配置
//6.追加密码配置文件
//7.组立4追加CCD3和CCD4
//8.追加螺钉数量检查配置选项及超出报警
//9.优化TypeConfig.cs添加CCD4的配置，式样名称变更为品番名称为后面自动切换品番作预留
//10.针对检查机追加Master.csv文件，在做MASTER时可重复做，将收到MES的反馈默认改成00
//11.自动触发组立6保险丝QR
//Ver1.0.2.5 →Ver1.0.2.6    2021.10.03  LYF
//1.螺钉检测修正
//2.CSV保存失败时清除缓存
//Ver1.0.2.6 →Ver1.0.2.7    2021.10.04  LYF
//1.组立6螺钉检测修正
//2.追加NG时电批回到点检坐标
//3.组立3追加多一个CCD检查，组立3和组立7翻转机中追加CCD检查结果输出到PLC 
//Ver1.0.2.7 →Ver1.0.2.8    2021.10.11  LYF
//1.取消NG时电批回到点检坐标
//Ver1.0.2.8 →Ver1.0.2.9    2021.10.11  LYF
//1.优化翻转机CCD信号
//2.优化设备连接提示
//3.优化PLC的连接关闭
//Ver1.0.2.9 →Ver1.0.3.0    2021.10.11  LYF
//1.追加调试用模拟的电批数据
//2.取出螺钉异常再判定追加
//3.追加预充继电器QR、托盘QR检验
//4.追加部品混入再判定
//5.复位清空CSV缓存修正
//Ver1.0.3.0 →Ver1.0.3.1    2021.10.15  LYF
//1.优化ScrewDataRecDeal()对应的A1式样在主继电器预装和组立1工程
//2.修正项目数据表格空间无法手动排序
//3.追加点检画面
//Ver1.0.3.1 →Ver1.0.3.2    2021.10.25  LYF
//1.组立2追加A1A2式样主继电器的摆放位置对QR进行检验
//2.优化组立1追加A1式样的电批坐标设定
//3.优化作业者输入后导致的PLC连接失败
//Ver1.0.3.2 →Ver1.0.3.3    2021.10.26  LYF
//1.优化点检画面的端口初始化
//2.优化点检画面
//3.优化作业者输入后导致的PLC连接失败
//Ver1.0.3.2 →Ver1.0.3.3    2021.10.26  LYF
//1.优化程序退出的处理
//Ver1.0.3.3 →Ver1.0.3.4    2021.10.28  LYF
//1.人工处理界面追加声音
//2.设备初始化放到FrmMain_Shown中
//Ver1.0.3.4 →Ver1.0.3.5    2021.11.02  LYF
//1.优化图片重命名
//2.将作业员输入调整到主画面
//3.优化等待MES回复显示
//4.履历追加最终角度值
//Ver1.0.3.5 →Ver1.0.3.6    2021.11.12  LYF
//1.A1A4机种继电器扫描FP化右边继电器修正为X30
//2.修正组立6-2螺钉机在扫描仪保险丝QR前触发的螺钉数量异常无法解除问题
//Ver1.0.3.6 →Ver1.0.3.7    2021.11.24  LYF
//1.追加A5机种在电批6-2进行可配置的坐标
//2.追加本体组立自动切换式样
//3.追加式样的主画面显示
//Ver1.0.3.7 →Ver1.0.3.8    2021.11.24  LYF
//1.修正式样自动切换时。画面式样文字对应变化
//Ver1.0.3.8 →Ver1.0.3.9    2021.11.24  LYF
//1.修正主继电器在组立2根据式样切换的校验
//Ver1.0.3.9 →Ver1.0.4.0    2021.12.01  LYF
//1.追加组立6电批9Nm的点检选项
/*************************************************************************************/
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
using BVE3_FP.ProjectClass;
using System.IO;
namespace BVE3_FP
{
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
        public bool flat;//数据包更新标志
    }
    public enum IP_TYPE {
        DEVICE,
        MES
    }

    public enum UDPMODE
    {
        Start,//前工程确认
        End//本工程确认
    }
    public enum MES_RESULT
    { 
        OK,
        NG
    }
    struct PLCUdpData
    {
        public string Mode;//头:1:前工程确认，2:本工程登录（1位）
        public string ProjCode;//工程名4位
        public string DeviceID;//装置番号2位
        public string Program;//程序名称15位
        public string ToolCode;//治具番号5位
        public string LotCode;//批次号11位
        public string SerNo;//序列号7位
        public string RefCode;//制品番号12位
        public string UserCode;//作业者番号7位
        public string Judge;//判定2位
        public string Remark;//备用预留10位
        public string EndCode;//结束符2位
    }


    public partial class FrmMain : Form
    {
        public class MesSendData
        {
            public string Mode;//头:1:前工程确认，2:本工程登录（1位）
            public string ProjCode;//工程名4位
            public string DeviceID;//装置番号2位
            public string Program;//程序名称15位
            public string ToolCode;//治具番号5位
            public string LotCode;//批次号11位
            public string SerNo;//序列号7位
            public string RefCode;//制品番号12位
            public string ProductCode;//生产指示番号32位
            public string MaterialCode;//材料番号36位
            public string UserCode;//作业者番号7位
            public string Judge;//判定2位
            public string Remark;//备用预留10位
            public string EndCode;//结束符2位

            public MesSendData()
            {
                Mode = "1";
                ProjCode = "";
                DeviceID = "";
                Program = "";
                ToolCode = "";
                LotCode = "";
                SerNo = "";
                RefCode = "";
                ProductCode = "";//新增
                MaterialCode = "";//新增
                UserCode = "";
                Judge = "";
                Remark = "";
                EndCode = "\r\n";
            }
            public string SendMsg()
            {
                string data;
                Mode = string.Format("{0,1}", Mode);//正号：右对齐，负号左对齐
                ProjCode = string.Format("{0,-4}", ProjCode);
                DeviceID = string.Format("{0,-2}", DeviceID);
                Program = string.Format("{0,-15}", Program);
                ToolCode = string.Format("{0,5}", ToolCode);//治具番号5位
                LotCode = string.Format("{0,-11}", LotCode);
                SerNo = string.Format("{0,-7}", SerNo);
                RefCode = string.Format("{0,-12}", RefCode);
                ProductCode = string.Format("{0,32}", ProductCode);//新增
                MaterialCode = string.Format("{0,36}", MaterialCode);//新增
                UserCode = string.Format("{0,7}", UserCode);
                Judge = string.Format("{0,-2}", Judge);//判定2位
                Remark = string.Format("{0,-3}", Remark) + "0999999";
                EndCode = "\r\n";
                data = Mode + ProjCode + DeviceID + Program + ToolCode + LotCode + SerNo
                    + RefCode + ProductCode + MaterialCode + UserCode + Judge + Remark + EndCode;
                return data;
            }
        }
        private bool ScannerIsOpen = false;//扫描仪是否处于触发状态
        HandyData handyData1;
        HandyData handyData2;
        OmronFINS PLCcontrol;

        OmronFINS PLCcontrolHV;
        OmronFINS PLCcontrolLV;
        OmronFINS PLCcontrolBDSB;
        OmronFinsUdp UdpServerHLB;//检查机UDP
        IV2Navigator IV2control1;
        IV2Navigator IV2control2;
        IV2Navigator IV2control3;
        IV2Navigator IV2control4;
        private SoundPlayer ScanSound = new SoundPlayer(Properties.Resources.ScanVoice);
        private SoundPlayer ERRSound = new SoundPlayer(Properties.Resources.ERR);
        private byte[] LastPlcIO = new byte[2] { 0x00, 0x00 };
        private bool[] PlcIoInputFlat = new bool[16];//输入点IO
        private bool[] PlcIoOutputFlat = new bool[16];//输出点IO
        private string[] QRbuff = new string[6] { "","","","","",""};
        private string TotalJudgeMsg = "";//总判定内容
        private int ItemsStep = 0;//项目执行步骤
        private int LastItemsStep = 0;//项目执行步骤的上一步
        private int DeviceStep = 0;//设备详细运行步骤
        private int HandyOKCount1 = 0;//电批1锁入螺钉OK数
        private int HandyOKCount2 = 0;//电批2锁入螺钉OK数
        private int ScrewPackCount1 = 0; //螺钉机1取出螺钉数量
        private int ScrewPackCount2 = 0; //螺钉机2取出螺钉数量
        private string ProjectCode;//当前工程码
        private string CurrPanaQR = "";//主键QR
        private string CurrSubQR = "";//子部品QR
        private string PressQR = "";//光标扫描仪的QR


        private string MainRelay1QR = "";//主继电器1QR
        private string MainRelay2QR = "";
        private string MainRelay3QR = "";
        private string MainRelay4QR = "";

        private int WorkStartTimeCount = 0;//开始作业的时间
        Thread threadClientQR1 = null; //扫描仪1线程
        Socket sockClientQR1 = null; //扫描仪1套接字

        Socket sockClientHandy = null; //智能电批

        Thread threadClientAPP = null; //与App Server服务器通信的线程
        Socket udpClient = null; //App Server套接字
        EndPoint targetPoint;
        private string ServerAPPMsg ="";//服务器消息
        private LINETYPE Linetype;
        TConfigLine[] ConfigLines;
        TConfigLine TypeA;
        PLCUdpData plcData;//接收到PLC的数据包
        string typeText = string.Empty;
        private int FinsErrCount = 0;

        private string[] MasterList;
        /// <summary>
        /// Udp是已否完成一次收发
        /// </summary>
        private bool IsUdpFinish = true;
        FileData FileSave;
        LogMan UdpLog;
        DataMangement ShuntFileMag = new DataMangement(".csv", "", "ShuntParaData");//
        private delegate string ConnectSocketDelegate(IPEndPoint ipep, Socket sock);

        public FrmMain()
        {
            InitializeComponent();
        }

        private void DataGridUiInit()
        {
            dataGridViewData.Columns.Add("c0", "No");
            dataGridViewData.Columns.Add("c1", "扭矩值");
            dataGridViewData.Columns.Add("c2", "角度");
            dataGridViewData.Columns.Add("c3", "位置X");
            dataGridViewData.Columns.Add("c4", "位置Y");
            dataGridViewData.Columns.Add("c5", "位置Z");
            dataGridViewData.Columns.Add("c6", "判定");
            dataGridViewData.Columns[0].Width = 70;
            dataGridViewData.Columns[1].Width = 122;
            dataGridViewData.Columns[2].Width = 122;
            dataGridViewData.Columns[3].Width = 122;
            dataGridViewData.Columns[4].Width = 122;
            dataGridViewData.Columns[5].Width = 122;
            dataGridViewData.Columns[6].Width = 122;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            dataGridViewData.AllowUserToAddRows = false;//允许用户新增行
            dataGridViewData.AllowUserToDeleteRows = false;//允许用户删除行
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(237)))), ((int)(((byte)(244)))));//System.Drawing.Color.LightCyan;//表格1的背景色
            dataGridViewData.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;//设置计数行单元格
            dataGridViewData.BackgroundColor = System.Drawing.Color.White;//设置本表格背景色为白色
            dataGridViewData.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;//标题头样式
            dataGridViewData.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;//设置标题头的样式
            dataGridViewData.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));//单元格字体
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(223)))), ((int)(((byte)(240)))));//标题头颜色
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewData.EnableHeadersVisualStyles = false;
            dataGridViewData.GridColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewData.ReadOnly = true;
            dataGridViewData.RowHeadersVisible = false;
            dataGridViewData.RowTemplate.Height = 43;
            dataGridViewData.RowTemplate.ReadOnly = true;

            for (int i = 0; i < dataGridViewData.Columns.Count; i++)
            {
                dataGridViewData.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }
        private void ItemsGridUiInit()
        {
            dataGridViewItems.Columns.Add("c0", "No");
            dataGridViewItems.Columns.Add("c1", "作业项目");
            dataGridViewItems.Columns.Add("c2", "测定值");
            dataGridViewItems.Columns.Add("c3", "结果");

            dataGridViewItems.Columns[0].Width = 70;
            dataGridViewItems.Columns[1].Width = 490;
            dataGridViewItems.Columns[2].Width = 490;
            dataGridViewItems.Columns[3].Width = 122;

            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            dataGridViewItems.AllowUserToAddRows = false;//允许用户新增行
            dataGridViewItems.AllowUserToDeleteRows = false;//允许用户删除行
            //dataGridViewItems.RowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(216)))), ((int)(((byte)(232)))));//偶数行
            
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(237)))), ((int)(((byte)(244)))));//设置奇数行单元格背景色
            dataGridViewItems.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;//设置奇数行单元格      
            dataGridViewItems.BackgroundColor = System.Drawing.Color.White;//设置本表格后面的颜色
            dataGridViewItems.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;//标题头样式
            dataGridViewItems.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;//设置标题头的样式
            dataGridViewItems.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));//单元格字体
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor =  System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));//标题头颜色
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewItems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewItems.EnableHeadersVisualStyles = false;
            dataGridViewItems.GridColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewItems.ReadOnly = true;
            dataGridViewItems.RowHeadersVisible = false;
            dataGridViewItems.RowTemplate.Height = 43;
            dataGridViewItems.RowTemplate.ReadOnly = true;

            for(int i = 0;i< dataGridViewItems.Columns.Count;i++)
            {
                dataGridViewItems.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }
        //函数参数为铜片的QR，返回参数为bool,检查内容：铜片QR格式是否正确，配置路径文件是否存在，文件格式是否正确，目标数据是否为数字，生成对应文件
        //NG的内容直接赋值给TotalJudge进行报警
        //通过返回的bool量进行工程的跳跃和画面的控制
        private bool CheckShuntQR(string shuntQR)
        {
            if(shuntQR.Length != 12)
            {
                TotalJudgeMsg = "铜片QR格式不正确";
                return false;
            }
            if(Directory.Exists(PublicValue.configData.ShuntPath) == false)
            {
                TotalJudgeMsg = "电阻值参数文件夹不存在";
                return false;
            }
            string shuntSerial = shuntQR.Substring(shuntQR.Length - 7, 7);
            DirectoryInfo directoryInfo = new DirectoryInfo(PublicValue.configData.ShuntPath);
            FileInfo[] fileInfos = directoryInfo.GetFiles("*.csv");
            List<string> tarFile = new List<string> { };
            foreach (FileInfo file in fileInfos)
            {
                string[] atrPart = file.Name.Split('_');
                if(atrPart.Length != 2)
                {
                    TotalJudgeMsg = "电阻值参数文件名不正确";
                    return false;
                }
                string serNo = atrPart[0].Substring(atrPart[0].Length - 7, 7);
                if (serNo == shuntSerial)
                    tarFile.Add(file.FullName);
            }
            if(tarFile.Count == 0)
            {
                TotalJudgeMsg = "对应电阻参数文件不存在";
                return false;
            }
            if (tarFile.Count > 1)
            {
                TotalJudgeMsg = "存在多个电阻参数文件";
                return false;
            }
            try
            {
                using (StreamReader sr = new StreamReader(tarFile[0], true))
                {
                    string line = sr.ReadLine();
                    string shuntPara = line.Split(',')[10];
                    bool rel = SaveShuntFile(shuntSerial, shuntPara);
                    if(rel == false)
                    {
                        TotalJudgeMsg = "生成电阻绑定文件失败";
                        return false;
                    }
                }
            }
            catch
            {
                TotalJudgeMsg = "参数文件读取失败";
                return false;
            }
            return true;
        }

        //通过实例化文件保存的类作为生成控制
        //把铜片序列号和电阻值作为参数进行CSV的保存
        //返回bool，被上面的函数调用
        private bool SaveShuntFile(string shuntSerial,string para)
        {
            try
            {
                string wrData = shuntSerial + "," + para;
                ShuntFileMag.Data_Save(wrData, CurrPanaQR,false,false);
                return true;
            }
            catch
            {
                return false;

            }
        }
        private void InitTypeDis()
        {
            string type = string.Empty;
            switch ((TypeA123)PublicValue.configData.TYPE)
            {
                case TypeA123.A1: type = "A1-A4"; break;
                case TypeA123.A2: type = "A2-A5"; break;
                case TypeA123.A3: type = "A3-A6"; break;
            }
            labType.Text = type;
        }
        /// <summary>
        /// 初始化标题栏\项目列表信息
        /// </summary>
        private void BaseInit()
        {
            labProj.Text = PublicValue.Projects[PublicValue.configData.Proj];
            labDeviceNo.Text = PublicValue.configData.DeviceNo;
            labLineNo.Text = PublicValue.configData.LineNo;
            InitTypeDis();
            for (int i = 0;i< PublicValue.ItemList.GetLength(1); i++)
            {
                if (PublicValue.ItemList[PublicValue.configData.Proj, i] == "END")
                {
                    progWork.Maximum = i;
                    break;
                }
                AddGridItemJudge(PublicValue.ItemList[PublicValue.configData.Proj, i], "", "");
            }
            toolLacalIP.Text = "本机设备IP：" + GetLocalIP(IP_TYPE.DEVICE);
            toolLocalMesIP.Text = "本机MES IP：" + GetLocalIP(IP_TYPE.MES);

            toolPLCIP.Text = "PLC IP：" + PublicValue.configData.PLCIP;
            toolServerIP.Text = "服务器IP：" + PublicValue.configData.ServerIP;
            toolVersion.Text = "Version" + System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString();


            ProjectCode = PublicValue.ProjectCodes[PublicValue.configData.Proj];
            //判断是否本体组立还是预组立
            Linetype = (PublicValue.configData.Proj <= (int)PROINDEX.MainLine9 
                     || PublicValue.configData.Proj >= (int)PROINDEX.HV) ? LINETYPE.Main : LINETYPE.Pre;
            if (Linetype == LINETYPE.Pre)
                txtPana.Enabled = true;
            if (PublicValue.configData.HandyScaner == "OFF")
                txtQRScan.Enabled = false;
            //初始化CSV
            FileSave = new FileData("", "", labLineNo.Text, "", "", labDeviceNo.Text);

            UdpLog = new LogMan(".txt");

            ConfigLines = TypeConfig.ReadConfig(Application.StartupPath + "\\TypeConfig.csv");//式样配置文件读取
            if (ConfigLines == null)
                ShowMsg("TypeConfig.csv读取失败");
            else
                TypeA = ConfigLines[PublicValue.configData.TYPE];

            MasterList = ReadMasterFile(Application.StartupPath + "\\Master.csv");
            if (MasterList == null)
                ShowMsg("Master.csv读取失败");


            string[] operators = ReadMasterFile(Application.StartupPath + "\\Operator.txt");
            if (operators == null)
                ShowMsg("作业员文件读取失败");
            else
            {
                for (int i = 0; i < operators.Length; i++)
                    comOperator.Items.Add(operators[i]);
            }
        }
        /// <summary>
        /// 本体组立自动切换式样配置
        /// </summary>
        /// <param name="KindName"></param>
        private void AotoSwitchTypeA(string KindName)
        {
            switch (KindName)
            {
                case "EDA9GC101AB ": PublicValue.configData.TYPE = (int)TypeA123.A1; break;//A1 客户
                case "EDA101AB01  ": PublicValue.configData.TYPE = (int)TypeA123.A1; break;//A1 出日本
                case "EDA101AB02  ": PublicValue.configData.TYPE = (int)TypeA123.A1; break;//A1 出日本
                case "EDA101AB03  ": PublicValue.configData.TYPE = (int)TypeA123.A1; break;//A1 出日本

                case "EDA9GC108AB ": PublicValue.configData.TYPE = (int)TypeA123.A2; break;//A2 客户
                case "EDA108AB01  ": PublicValue.configData.TYPE = (int)TypeA123.A2; break;//A2 出日本
                case "EDA108AB02  ": PublicValue.configData.TYPE = (int)TypeA123.A2; break;//A2 出日本
                case "EDA108AB03  ": PublicValue.configData.TYPE = (int)TypeA123.A2; break;//A2 出日本

                case "EDA9GC109AB ": PublicValue.configData.TYPE = (int)TypeA123.A3; break;//A3 客户
                case "EDA109AB01  ": PublicValue.configData.TYPE = (int)TypeA123.A3; break;//A3 出日本
                case "EDA109AB02  ": PublicValue.configData.TYPE = (int)TypeA123.A3; break;//A3 出日本
                case "EDA109AB03  ": PublicValue.configData.TYPE = (int)TypeA123.A3; break;//A3 出日本

                case "EDA9GC101AA ": PublicValue.configData.TYPE = (int)TypeA123.A1; break;//A4 客户
                case "EDA101AA01  ": PublicValue.configData.TYPE = (int)TypeA123.A1; break;//A4 出日本
                case "EDA101AA02  ": PublicValue.configData.TYPE = (int)TypeA123.A1; break;//A4 出日本
                case "EDA101AA03  ": PublicValue.configData.TYPE = (int)TypeA123.A1; break;//A4 出日本

                case "EDA9GC108AA ": PublicValue.configData.TYPE = (int)TypeA123.A2; break;//A5 客户
                case "EDA108AA01  ": PublicValue.configData.TYPE = (int)TypeA123.A2; break;//A5 出日本
                case "EDA108AA02  ": PublicValue.configData.TYPE = (int)TypeA123.A2; break;//A5 出日本
                case "EDA108AA03  ": PublicValue.configData.TYPE = (int)TypeA123.A2; break;//A5 出日本

                case "EDA9GC109AA ": PublicValue.configData.TYPE = (int)TypeA123.A3; break;//A6 客户
                case "EDA109AA01  ": PublicValue.configData.TYPE = (int)TypeA123.A3; break;//A6 出日本
                case "EDA109AA02  ": PublicValue.configData.TYPE = (int)TypeA123.A3; break;//A6 出日本
                case "EDA109AA03  ": PublicValue.configData.TYPE = (int)TypeA123.A3; break;//A6 出日本
            }
            TypeA = ConfigLines[PublicValue.configData.TYPE];
            InitTypeDis();
        }
        private string[] ReadMasterFile(string filePath)
        {
            try
            {
                List<string> lineStr = new List<string> { };
                using (StreamReader reader = new StreamReader(filePath, Encoding.Default))
                {
                    string readLine;
                    while ((readLine = reader.ReadLine()) != null)
                    {
                        lineStr.Add(readLine);
                    }
                }
                return lineStr.ToArray();
            }
            catch
            {
                return null;
            }
        }
        private bool IsMater(string panaQR)
        {
            return MasterList.Contains(panaQR);
        }
        private void CsvSaveInit(string panaQR)
        {
            string sRef = panaQR.Substring(0, 12);
            string sLot = panaQR.Substring(12, 11);
            string sSer = panaQR.Substring(23);
            FileSave.Program = sRef.Trim();
            FileSave.RefNo = sRef.Trim();
            FileSave.LotNo = sLot.Trim();
            FileSave.SerNo = sSer.Trim();
        }
        /// <summary>
        /// 与远程主机连接
        /// </summary>
        /// <param name="ipep"></param>
        /// <param name="sock"></param>
        /// <returns></returns>
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
        /// <summary>
        /// 异步远程连接200ms内失败返回
        /// </summary>
        /// <param name="ipep">IPEndPoint端口</param>
        /// <param name="sock">socket实例</param>
        /// <returns></returns>
        public bool MySocketConnet(IPEndPoint ipep, Socket sock)
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
        private void RecQR1Msg(object mode)
        {
            while (true)
            {
                byte[] arrMsgRec = new byte[200];
                int length = 0;
                sockClientQR1.ReceiveBufferSize = 200;
                try
                {
                    length = sockClientQR1.Receive(arrMsgRec); // 接收数据，并返回数据的长度；
                    string strMsg = System.Text.Encoding.UTF8.GetString(arrMsgRec, 0, length);// 将接受到的字节数据转化成字符串；
                    string qrNo = mode as string;
                    ScannerIsOpen = false;
                    if (strMsg != "NOREAD" && strMsg.Trim() != "")//扫描成功时有概率出现空字符
                    {
                        QRbuff[Int32.Parse(qrNo)] = strMsg;
                        ScanSound.Play();
                        //Deal_QR1_Msg(strMsg);
                    }
                }
                catch (Exception e)
                {
                    throw e;
                }
            }
        }
        public bool TCPConnectQR1(string strIP, string strPort, string strPara)
        {
            IPAddress ip = IPAddress.Parse(strIP);
            IPEndPoint endPoint = new IPEndPoint(ip, int.Parse(strPort));
            sockClientQR1 = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            if (!MySocketConnet(endPoint, sockClientQR1))
            {
                return false;
            }
            threadClientQR1 = new Thread(new ParameterizedThreadStart(RecQR1Msg));
            threadClientQR1.IsBackground = true;
            threadClientQR1.Start(strPara);
            return true;
        }
        private void OpenScaner(int qrNo)
        {
            if(PublicValue.configData.OmronScaner == "OFF")
            {
                ShowMsg("固定扫描仪未启用！");
                return;
            }
            ScannerIsOpen = true;
            PublicValue.Delay(50);//连续触发有点问题
            switch (qrNo)
            {
                case 0: TCPConnectQR1(PublicValue.configData.QRIP1, PublicValue.configData.QRPort1, qrNo.ToString()); break;
                case 1: TCPConnectQR1(PublicValue.configData.QRIP2, PublicValue.configData.QRPort2, qrNo.ToString()); break;
                case 2: TCPConnectQR1(PublicValue.configData.QRIP3, PublicValue.configData.QRPort3, qrNo.ToString()); break;
                case 3: TCPConnectQR1(PublicValue.configData.QRIP4, PublicValue.configData.QRPort4, qrNo.ToString()); break;
                case 4: TCPConnectQR1(PublicValue.configData.QRIP5, PublicValue.configData.QRPort5, qrNo.ToString()); break;
                case 5: TCPConnectQR1(PublicValue.configData.QRIP6, PublicValue.configData.QRPort6, qrNo.ToString()); break;
            }
            sockClientQR1.Send(System.Text.Encoding.UTF8.GetBytes("< >")); //触发扫描仪    

        }
        /// <summary>
        /// 智能电批工作组选择(1:点检坐标; 2-5:对应螺钉1-4坐标)
        /// </summary>
        /// <param name="handyID">电批编号1-2</param>
        /// <param name="jobNo">工作组编号</param>
        private void HandyJobSelected(int handyID,int jobNo)
        {
            string Handyip, Handyport;
            if(handyID == 1)
            {
                Handyip = PublicValue.configData.HandyIP1;
                Handyport = PublicValue.configData.HandyNetPort1;
            }
            else
            {
                Handyip = PublicValue.configData.HandyIP2;
                Handyport = PublicValue.configData.HandyNetPort2;
            }
            IPAddress ip = IPAddress.Parse(Handyip);
            IPEndPoint endPoint = new IPEndPoint(ip, int.Parse(Handyport));
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
                if (jobNo == 1)
                {
                    Thread.Sleep(20);
                    sockClientHandy.Send(Handy_Reset); // 复位；
                }
                sockClientHandy.Close();
            }
        }
        /// <summary>
        /// 界面显示消息
        /// </summary>
        /// <param name="str"></param>
        private void ShowMsg(string str)
        {
            txtMsg.AppendText(str + Environment.NewLine);
        }
        /// <summary>
        /// 初始化获取本机IP地址
        /// </summary>
        /// <returns></returns>
        private string GetLocalIP(IP_TYPE iP_TYPE)
        {
            try
            {
                string localIp = null;
                string mesIp = null;
                IPAddress[] ipelist = Dns.GetHostAddresses(Dns.GetHostName());
                foreach (IPAddress ipe in ipelist)
                {
                    if (ipe.AddressFamily == AddressFamily.InterNetwork)
                    {
                        string ipv4 = ipe.ToString();
                        string[] arrIP = ipv4.Split('.');
                        string[] arrPLCIP = PublicValue.configData.PLCIP.Split('.');
                        if (arrIP[0] == arrPLCIP[0] && arrIP[1] == arrPLCIP[1])                        
                            localIp = ipv4;                        
                        else                        
                            mesIp = ipv4;                       
                    }
                }
                if (iP_TYPE == IP_TYPE.DEVICE)
                    return localIp;
                else
                    return mesIp;
            }
            catch
            {
                ShowMsg("本机IP获取失败");
            }
            return null;
        }
        /// <summary>
        /// 转换二进制按位取值
        /// </summary>
        /// <param name="b">源数据</param>
        /// <param name="index">获取位的索引值</param>
        /// <returns>0或者1</returns>
        private int GetBitStatus(byte[] b, int index)
        {
            if (b.Length == 2)
            {
                if (index < 8)
                    return ((b[1] & (1 << index)) > 0 ? 1 : 0);
                else
                    return ((b[0] & (1 << (index - 8))) > 0 ? 1 : 0);
            }
            return -1;
        }
        private void PlcResetIO(int BitNo)
        {
            PlcIoOutputFlat[BitNo] = true;
        }
        private void CCDOutputPLC(MES_RESULT rel)
        {
            if(rel == MES_RESULT.OK)
            {
                PLCcontrol.WriteCommand(MemoryAreaCode.WRBit, new byte[] { 0x00, 0x0A, (byte)2 }, new byte[] { 0x01 });
                PLCcontrol.WriteCommand(MemoryAreaCode.WRBit, new byte[] { 0x00, 0x0A, (byte)2 }, new byte[] { 0x00 });
            }
            else
            {
                PLCcontrol.WriteCommand(MemoryAreaCode.WRBit, new byte[] { 0x00, 0x0A, (byte)6 }, new byte[] { 0x01 });
                PLCcontrol.WriteCommand(MemoryAreaCode.WRBit, new byte[] { 0x00, 0x0A, (byte)6 }, new byte[] { 0x00 });
            }
        }
        /// <summary>
        /// 更新PLC的IO状态
        /// </summary>
        private void PLCIOUpdate()
        {
            //输出扫描
            for (int i = 0; i < 16; i++)
            {
                if(PlcIoOutputFlat[i] == true)
                {
                    PLCcontrol.WriteCommand(MemoryAreaCode.WRBit, new byte[] { 0x00, 0x0A, (byte)i }, new byte[] { 0x01 });
                    PLCcontrol.WriteCommand(MemoryAreaCode.WRBit, new byte[] { 0x00, 0x0A, (byte)i }, new byte[] { 0x00 });
                    PlcIoOutputFlat[i] = false;
                }
            }
            //IO读取
            byte[] iOData = PLCcontrol.ReadCommand(MemoryAreaCode.WRWord, new byte[] { 0x00, 0x03, 0x00 }, 1);//W3.00
            if(iOData != null)
            {
                FinsErrCount = 0;
                for (int i = 0; i < 16; i++)
                {
                    if (GetBitStatus(LastPlcIO, i) != GetBitStatus(iOData, i) && GetBitStatus(iOData, i) == 1)
                        PlcIoInputFlat[i] = true;
                }
                if (LastPlcIO != iOData)//检测数据变化的边沿
                {
                    LastPlcIO = iOData;
                }
            }
            else
            {
                FinsErrCount++;
                if(FinsErrCount == 50)
                {
                    TotalJudgeMsg = "PLC通信异常";
                }
            }
        }
        /// <summary>
        /// 检测PLC 的IO边沿
        /// </summary>
        /// <param name="addr">地址</param>
        /// <param name="mode">检测上或下边沿</param>
        /// <returns></returns>
        private bool CheckPlcIoEdge(OmronBitAddr addr, CheckEdgeMode mode)
        {
            //IO读取
            bool rel = false;
            byte[] iOData = PLCcontrol.ReadCommand(addr.AreaCode, addr.WdAddr, 1);
            if(iOData != null)
            {
                if (GetBitStatus(LastPlcIO, addr.BitNo) != GetBitStatus(iOData, addr.BitNo) &&
                    GetBitStatus(iOData, addr.BitNo) == (mode == CheckEdgeMode.Up ? 1 : 0))
                {
                    rel = true;
                }
                if (LastPlcIO != iOData)//检测数据变化的边沿
                {
                    LastPlcIO = iOData;
                }
            }

            return rel;
        } 
        private string GetPlcQR(OmronBitAddr addr)
        {
            byte[] data = PLCcontrol.ReadCommand(addr.AreaCode, addr.WdAddr, 15);
            string qr = Encoding.Default.GetString(data);
            return qr;
        }

        private bool CheckQRFomat(QRType type,string qr)
        {
            bool rel = false;
            if(qr != null)
            {
                switch (type)
                {
                    case QRType.Pana:
                        if (qr.Length == 30)
                            rel = true;
                        break;
                    case QRType.Panel:
                        rel = true;
                        break;
                    case QRType.PreRelay:
                        if (qr.Length == 29)
                            rel = true;
                        break;
                    case QRType.CuQR:
                        if (qr.Length == 12)
                            rel = true;
                        break;
                    case QRType.MainRelayA2A3:
                        if (qr.Length == 29)
                            rel = true;
                        break;
                    case QRType.MainRelayA1Left:
                        if (qr.Length == 29)
                            if(qr.Substring(8,3) == "XX8")
                                rel = true;
                        break;
                    case QRType.MainRelayA1Right:
                        if (qr.Length == 29)
                            if (qr.Substring(8,3) == "X30")
                                rel = true;
                        break;
                    case QRType.BDSB:
                        if (qr.Length == 30)
                            rel = true;
                        break;
                    case QRType.Water:
                        if (qr.Length == 26)
                            rel = true;
                        break;
                    case QRType.Safe:
                        if (qr.Length == 36)
                            rel = true;
                        break;
                }
            }
            return rel;
        }
        /// <summary>
        /// 检查拿取的螺钉数量
        /// </summary>
        /// <param name="hID">配套电批的ID</param>
        /// <param name="theHandyStep">此电批的作业步骤</param>
        /// <param name="typeM">螺钉型号，如M6</param>
        private void ScrewPackCheck(HANDYID hID,int theHandyStep,string typeM = "")
        {
            if (PublicValue.configData.LDErr == "OFF")
                return;

            int ScrewPackCount;
            int SetScrew;
            if(hID == HANDYID.Handy1)
            {
                ScrewPackCount1++;
                ScrewPackCount = ScrewPackCount1;
                SetScrew = PublicValue.configData.LD1;
            }
            else
            {
                ScrewPackCount2++;
                ScrewPackCount = ScrewPackCount2;
                SetScrew = PublicValue.configData.LD2;
            }
            if (ItemsStep == theHandyStep)//锁螺钉步骤
            {
                if (ScrewPackCount <= SetScrew)
                {
                    UpdateGridItemJudge(ItemsStep, typeM + "*" + ScrewPackCount, "");//表格中显示取出螺钉数量             
                }
                else
                {
                    //人为失误ERR修复
                    NGBtnClick manSel = ManuDealNGshow(NGTpye.Operator, "取出螺钉异常！");
                    if (manSel == NGBtnClick.CLEAR)
                        return;
                    TotalJudgeMsg = "取出螺钉数异常！";
                    ItemsStep = -1;
                }
            }
            else
            {
                //人为失误ERR修复
                NGBtnClick manSel = ManuDealNGshow(NGTpye.Operator, "目前不是锁螺钉步骤！");
                if (manSel == NGBtnClick.CLEAR)
                    return;
                TotalJudgeMsg = "目前不是锁螺钉步骤！";
                ItemsStep = -1;
            }
        }
        private void MainResetCheck()
        {
            //初始化一些数据
            TotalJudgeMsg = "";
            DataInit();
            ResetInputFlat();
            DisplayClear();
            txtPana.Text = "";
            FileSave.BufferClear();
            ERRSound.Stop();
            if (PublicValue.configData.Handy1 == "ON")
            {
                HandyJobSelected(1, 1);//坐标1
                
            }
            if (PublicValue.configData.Handy2 == "ON")
            {
                HandyJobSelected(2, 1);//坐标1
                
            }

        }
        /// <summary>
        /// MES前工程确认逻辑处理
        /// </summary>
        /// <returns>下个步骤No</returns>
        private int MainMesPreReq()
        {
            if (QRbuff[PublicValue.QR1] != "")
            {
                CurrPanaQR = QRbuff[PublicValue.QR1];
                QRbuff[PublicValue.QR1] = "";
                txtPana.Text = CurrPanaQR;
                CsvSaveInit(CurrPanaQR);
                handyData1.flat = false;//电批数据点检残留清除
                handyData2.flat = false;
                WorkStartTimeCount = Environment.TickCount;
                if (CheckQRFomat(QRType.Pana, CurrPanaQR))//格式判定
                {
                    AotoSwitchTypeA(CurrPanaQR.Substring(0, 12));
                    IsUdpFinish = false;
                    ServerAPPMsg = "";
                    UdpSend(UDPMODE.Start, CurrPanaQR);
                    UpdateGridItemJudge(ItemsStep, CurrPanaQR, "--");
                }
                else
                {
                    //人为失误ERR修复
                    NGBtnClick manSel = ManuDealNGshow(NGTpye.Operator, "部品混入！QR:" + CurrPanaQR);
                    if (manSel == NGBtnClick.CLEAR)
                        return ItemsStep;

                    txtPana.BackColor = Color.Red;
                    TotalJudgeMsg = "部品混入";
                    ItemsStep = -1;
                    return ItemsStep;
                }
            }
            string rel = MesAppUdpRec(UDPMODE.Start);//MES前工程确认
            if (rel != "")
            {
                string codeErr = GetUdpErrCode(rel);
                ShowMsg(rel);
                bool isRepeat = false;
                if (PublicValue.configData.REPEAT == "ON")
                    if (codeErr == "22")
                        isRepeat = true;
                if (codeErr == "00" || isRepeat)
                {
                    UpdateGridItemJudge(ItemsStep, "E" + codeErr, "OK");
                    ResetInputFlat();//为了防止在进入下一步之前已经触发了传感器，标志被置位
                    progWork.Value++;
                    ItemsStep++;
                }
                else
                {
                    UpdateGridItemJudge(ItemsStep, "E" + codeErr, "NG");
                    TotalJudgeMsg = codeErr;
                    ItemsStep = -1;
                }
            }
            return ItemsStep;
        }

        private int SubRefMesReq(QRType type, int relayNo)//子部品MES请求处理
        {
            if (QRbuff[relayNo] != "")
            {
                string qrSub = QRbuff[relayNo];
                QRbuff[relayNo] = "";
                CurrSubQR = qrSub;
                if (CheckQRFomat(type,qrSub))//格式判定
                {
                    IsUdpFinish = false;
                    ServerAPPMsg = "";
                    if (Linetype == LINETYPE.Main)
                    {
                        UdpSend(UDPMODE.Start,CurrPanaQR, "", qrSub, MES_RESULT.OK);
                    }
                    else
                    {
                        FileSave.LotNo = txtPana.Text.Trim();//生产指示番号填到批次列中
                        UdpSend(UDPMODE.Start,"", txtPana.Text, qrSub, MES_RESULT.OK);

                    }
                    UpdateGridItemJudge(ItemsStep, CurrSubQR, "--");
                }
                else
                {
                    //人为失误ERR修复
                    NGBtnClick manSel = ManuDealNGshow(NGTpye.Operator, "部品混入！QR:" + qrSub);
                    if (manSel == NGBtnClick.CLEAR)
                        return ItemsStep;

                    UpdateGridItemJudge(ItemsStep, CurrSubQR, "NG");
                    //txtPana.BackColor = Color.Red;
                    TotalJudgeMsg = "部品混入";
                    ItemsStep = -1;
                    return ItemsStep;
                }
            }
            string rel = MesAppUdpRec(UDPMODE.Start);//MES前工程确认
            if (rel != "" && labJudge.Text == "----")
            {
                string codeErr = GetUdpErrCode(rel);
                ShowMsg(rel);
                if (codeErr == "00")
                {
                    UpdateGridItemJudge(ItemsStep, CurrSubQR, "OK");
                    ResetInputFlat();//为了防止在进入下一步之前已经触发了传感器，标志被置位
                    progWork.Value++;
                    ItemsStep++;
                }
                else
                {
                    UpdateGridItemJudge(ItemsStep, CurrSubQR, "NG");
                    TotalJudgeMsg = codeErr;
                    ItemsStep = -1;
                }
            }
            return ItemsStep;
        }
        /// <summary>
        /// 本工程确认项目处理
        /// </summary>
        /// <returns>下个步骤No</returns>
        private int MainMesSelfRecord()
        {
            if (IsUdpFinish == true)
            {
                IsUdpFinish = false;
                ServerAPPMsg = "";
                if (Linetype == LINETYPE.Main)
                {
                    if ((PROINDEX)PublicValue.configData.Proj == PROINDEX.HV ||
                        (PROINDEX)PublicValue.configData.Proj == PROINDEX.LV ||
                        (PROINDEX)PublicValue.configData.Proj == PROINDEX.BDSB)
                        UdpSend(plcData);
                    else
                        UdpSend(UDPMODE.End, CurrPanaQR);
                }
                else
                    UdpSend(UDPMODE.End, "", txtPana.Text, CurrSubQR, MES_RESULT.OK);//CurrSubQR追加发送2021.08.19
            }
            string rel = MesAppUdpRec(UDPMODE.End);
            if (rel != "" && labJudge.Text == "----") //labJudge.Text == "----"2021.08.18追加
            {
                string codeErr = GetUdpErrCode(rel);
                ShowMsg(rel);
                bool isRepeat = false;
                if (PublicValue.configData.REPEAT == "ON")//允许重做
                    if (codeErr == "22")
                        isRepeat = true;
                //对接设备自身的追溯
                if ((PROINDEX)PublicValue.configData.Proj == PROINDEX.HV ||
                    (PROINDEX)PublicValue.configData.Proj == PROINDEX.LV ||
                    (PROINDEX)PublicValue.configData.Proj == PROINDEX.BDSB)
                    if (PublicValue.configData.DeviceMES == "ON")
                    {
                        //判断是不是MASTER，如果是则直接对codeErr = "00"
                        if (IsMater(CurrPanaQR))
                            codeErr = "00";
                        MESRepPLC(UDPMODE.End, isRepeat ? "00" : codeErr);
                    }
                if (codeErr == "00" || isRepeat)
                {
                    UpdateGridItemJudge(ItemsStep, "E" + codeErr, "OK");
                    TotalJudgeMsg = "OK";
                    progWork.Value++;
                    ItemsStep++;
                    //为下一趟作业准备
                    ResetInputFlat();
                    
                }
                else
                {
                    UpdateGridItemJudge(ItemsStep, "E" + codeErr, "NG");
                    TotalJudgeMsg = codeErr;
                    ItemsStep = -1;
                }
                
            }
            return ItemsStep;
        }
        private int CCDnDeal(IV2Navigator iV2Navigator)
        {
            if(iV2Navigator == null)
            {
                TotalJudgeMsg = "CCD未连接";
                ItemsStep = -1;
            }

            string[] chs;
            TConfigLine configCCD = ConfigLines[(int)PublicValue.configData.TYPE];//默认A3式样
            if (iV2Navigator == IV2control1)
                chs = configCCD.CCD1CH;
            else if(iV2Navigator == IV2control2)
                chs = configCCD.CCD2CH;
            else if(iV2Navigator == IV2control3)
                chs = configCCD.CCD3CH;
            else
                chs = configCCD.CCD4CH;

            string judge = "OK";
            IV2StandardResult iv2RelCH;
            string similarity = "--";
            ShowMsg("--------------------");
            foreach (string chNo in chs)
            {
                ShowMsg("识别CCD通道:"+ chNo);
                bool relch = iV2Navigator.ChangeProgNo(Int32.Parse(chNo));
                if(relch)
                    ShowMsg("切换成功");
                PublicValue.Delay(1000);//延时1秒
                iv2RelCH = iV2Navigator.TriggerGetResult();
                IV2ToolResult[] iV2ToolResults = iv2RelCH.iV2ToolResults;
                if (iv2RelCH.AllJudge != JUDGE_TYPE.OK)
                {
                    judge = "NG";
                    foreach(IV2ToolResult rel in iV2ToolResults)
                    {
                        if (rel.Judge != "OK")
                        {
                            similarity = Int32.Parse(rel.Similarity.Substring(rel.Similarity.Length - 3)).ToString() + "%";
                        }
                        ShowMsg(rel.ToolNo + "," + rel.Judge + "," + rel.Similarity);
                    }
                    break;
                }
                else
                {
                    foreach (IV2ToolResult rel in iV2ToolResults)//默认取最后的结果
                    {
                        similarity = Int32.Parse(rel.Similarity.Substring(rel.Similarity.Length - 3)).ToString() + "%";
                        ShowMsg(rel.ToolNo+","+ rel.Judge+","+rel.Similarity);
                    }
                }
            }
            //如果NG进行人工CCD判定处理
            if(judge != "OK")
            {
                NGBtnClick manSel = ManuDealNGshow(NGTpye.CCD,"当前CCD识别判定NG 相识度为" + similarity);
                if (manSel == NGBtnClick.Again)
                    return ItemsStep;
                else if (manSel == NGBtnClick.OK)
                {
                    judge = "OK";
                    similarity = "人为目视判定";
                }
            }
            UpdateGridItemJudge(ItemsStep, similarity, judge);
            if (judge == "OK")
            {
                //ScanSound.Play();
                ResetInputFlat();
                progWork.Value++;
                ItemsStep++;
            }
            else
            {
                TotalJudgeMsg = "NG";
                ItemsStep = -1;
            }
            return ItemsStep;
        }
        private int ScrewDataRecDeal(HANDYID hID,string typeM = "")
        {
            int handyOKCount;
            int SetScrew;
            HandyData handyData;

            if (hID == HANDYID.Handy1)
            {
                handyOKCount = HandyOKCount1;
                SetScrew = PublicValue.configData.LD1;
                handyData = handyData1;
            }
            else
            {
                handyOKCount = HandyOKCount2;
                SetScrew = PublicValue.configData.LD2;
                handyData = handyData2;
            }
            if (handyOKCount < SetScrew)
            {
                if (handyData.flat == true)
                {
                    handyData1.flat = false;
                    handyData2.flat = false;
                    AddGridHandyData(handyData);
                    if (handyData.judge == "O")
                    {
                        handyOKCount++;
                        if (handyOKCount == SetScrew)
                        {

                            UpdateGridItemJudge(ItemsStep, typeM + "*" + handyOKCount, "OK");
                            //本工程确认后再松开气缸
                            ResetInputFlat();
                            progWork.Value++;
                            ItemsStep++;
                        }
                        else
                        {
                            if((PROINDEX)PublicValue.configData.Proj == PROINDEX.RelayLine ||
                                (PROINDEX)PublicValue.configData.Proj == PROINDEX.MainLine1||
                                ((PROINDEX)PublicValue.configData.Proj == PROINDEX.MainLine6 && hID ==  HANDYID.Handy2))
                            {
                                int startJob;
                                if (PublicValue.configData.TYPE == (int)TypeA123.A3)
                                {
                                    startJob = 2;
                                }
                                else
                                {
                                    startJob = TypeA.StartJob;
                                }
                                HandyJobSelected((int)hID + 1, handyOKCount + startJob);//切换到下个坐标
                            }
                            else
                                HandyJobSelected((int)hID + 1, handyOKCount + 2);//切换到下个坐标


                        }
                    }
                    else
                    {
                        UpdateGridItemJudge(ItemsStep, typeM + "*" + handyOKCount, "NG");
                        TotalJudgeMsg = "NG";
                        ItemsStep = -1;
                    }
                }
            }
            if (hID == HANDYID.Handy1)
                HandyOKCount1 = handyOKCount;
            else
                HandyOKCount2 = handyOKCount;
            return ItemsStep;
        }
        //HV LV 结束后PublicValue.configData.Proj+1
        //BDSB 结束后PublicValue.configData.Proj-2
        //下一项初始化时ProjSwitchInit();
        /// <summary>
        /// 工程切换
        /// </summary>
        /// <param name="pIndex">切换目标工程</param>
        private void ProjSwitch(PROINDEX pIndex)
        {
            if (pIndex == PROINDEX.HV)
            {
                PublicValue.configData.Proj = (int)PROINDEX.HV;
                PLCcontrol = PLCcontrolHV;
            }
            else if(pIndex == PROINDEX.LV)
            {
                PublicValue.configData.Proj = (int)PROINDEX.LV;
                PLCcontrol = PLCcontrolLV;

            }
            else if (pIndex == PROINDEX.BDSB)
            {
                PublicValue.configData.Proj = (int)PROINDEX.BDSB;
                PLCcontrol = PLCcontrolBDSB;

            }

        }

        private void ProjSwitchInit()
        {
            if(labProj.Text != PublicValue.Projects[PublicValue.configData.Proj])
            {
                labProj.Text = PublicValue.Projects[PublicValue.configData.Proj];
                //labDeviceNo.Text = PublicValue.configData.DeviceNo;//需要修改配置文件
                if ((PROINDEX)PublicValue.configData.Proj == PROINDEX.HV)
                    labDeviceNo.Text = PublicValue.configData.HVDeviceNo;
                else if ((PROINDEX)PublicValue.configData.Proj == PROINDEX.LV)
                    labDeviceNo.Text = PublicValue.configData.LVDeviceNo;
                else if ((PROINDEX)PublicValue.configData.Proj == PROINDEX.BDSB)
                    labDeviceNo.Text = PublicValue.configData.BDSBDeviceNo;
                else
                    labDeviceNo.Text = PublicValue.configData.HVDeviceNo;
                labLineNo.Text = PublicValue.configData.LineNo;
                //labWorker.Text = FrmInit.WorkerName;
                dataGridViewItems.Rows.Clear();
                for (int i = 0; i < PublicValue.ItemList.GetLength(1); i++)
                {
                    if (PublicValue.ItemList[PublicValue.configData.Proj, i] == "END")
                    {
                        progWork.Maximum = i;
                        break;
                    }
                    AddGridItemJudge(PublicValue.ItemList[PublicValue.configData.Proj, i], "", "");
                }
                toolLacalIP.Text = "本机设备IP：" + GetLocalIP(IP_TYPE.DEVICE);
                toolLocalMesIP.Text = "本机MES IP：" + GetLocalIP(IP_TYPE.MES);

                toolPLCIP.Text = "PLC IP：" + PublicValue.configData.PLCIP;
                toolServerIP.Text = "服务器IP：" + PublicValue.configData.ServerIP;

                ProjectCode = PublicValue.ProjectCodes[PublicValue.configData.Proj];
                //判断是否本体组立还是预组立
                Linetype = (PublicValue.configData.Proj <= (int)PROINDEX.MainLine9
                         || PublicValue.configData.Proj >= (int)PROINDEX.HV) ? LINETYPE.Main : LINETYPE.Pre;

                //初始化CSV
                //FileSave = new FileData("", "", labLineNo.Text, "", "", labDeviceNo.Text);
                FileSave.LineNo = labLineNo.Text;
                FileSave.DeviceNo = labDeviceNo.Text;
            }
        }
        private void MESRepPLC(UDPMODE mode,string relCode)
        {
            string sendStr = (mode == UDPMODE.Start ? "1" : "2") + "," + relCode + "," + "         \r\n";
            byte[] sendBuff = Encoding.UTF8.GetBytes(sendStr);
            string repIP = UdpServerHLB.TargetPoint.ToString().Split(':')[0];
            int repPort = int.Parse(UdpServerHLB.TargetPoint.ToString().Split(':')[1]);
            UdpServerHLB.Write(sendBuff, UdpServerHLB.RecAddr, repIP, repPort);
        }
        private void PlcDoLogicThing()//放到l另一个定时器里面
        {
            
            PROINDEX thePro = (PROINDEX)PublicValue.configData.Proj;
            switch(thePro)
            {
                case PROINDEX.MainLine1:
                    {
                        //复位检测
                        if (PlcIoInputFlat[PublicValue.IN1_RESET] == true)
                        {
                            MainResetCheck();
                            PlcIoInputFlat[PublicValue.IN1_RESET] = false;
                        }
                        //实时检测螺钉机1
                        if (PlcIoInputFlat[PublicValue.IN1_SCREW_M6] == true)
                        {
                            ScrewPackCheck(HANDYID.Handy1,3,"M6");
                            PlcIoInputFlat[PublicValue.IN1_SCREW_M6] = false;
                        }
                        //步骤扫描
                        switch (ItemsStep)
                        {
                            case 0://前工程MES确认
                                {
                                    if (PlcIoInputFlat[PublicValue.IN1_QR_PANA] == true && ScannerIsOpen != true && IsUdpFinish == true)
                                    {//触发
                                        if (labJudge.Text == "OK")//判断是否下一次作业
                                            DisplayClear();
                                        OpenScaner(PublicValue.QR1);
                                        PlcIoInputFlat[PublicValue.IN1_QR_PANA] = false;
                                    }
                                    int nextStep = MainMesPreReq();
                                    if(nextStep ==1)
                                        OpenScaner(PublicValue.QR2);
                                }
                                break;
                            case 1://预充继电器QR
                                {
                                    if (PlcIoInputFlat[PublicValue.IN1_QR_RELAY] == true && ScannerIsOpen != true)
                                    {//触发
                                        OpenScaner(PublicValue.QR2);
                                        PlcIoInputFlat[PublicValue.IN1_QR_RELAY] = false;
                                    }
                                    if (QRbuff[PublicValue.QR2] != "")
                                    {
                                        string qr = QRbuff[PublicValue.QR2];
                                        QRbuff[PublicValue.QR2] = "";
                                        //格式检测
                                        if(CheckQRFomat( QRType.PreRelay,qr ))
                                        {
                                            UpdateGridItemJudge(ItemsStep, qr, "OK");
                                            ResetInputFlat();
                                            progWork.Value++;
                                            ItemsStep++;
                                        }
                                        else
                                        {
                                            //人为失误ERR修复
                                            NGBtnClick manSel = ManuDealNGshow(NGTpye.Operator, "部品混入！QR:"+ qr);
                                            if (manSel == NGBtnClick.CLEAR)
                                                break;
                                            UpdateGridItemJudge(ItemsStep, qr, "NG");
                                            //txtPana.BackColor = Color.Red;
                                            TotalJudgeMsg = "部品混入";
                                            ItemsStep = -1;
                                            
                                        }
                                   
                                    }
                                }
                                break;
                            case 2://CCD1检测
                                {
                                    if (PublicValue.configData.CCDUSE == "ON")
                                    {
                                        if (PlcIoInputFlat[PublicValue.IN1_STOP_CCD] == true)
                                        {
                                            ShowMsg("3秒后CCD检查");
                                            PublicValue.Delay(3000);//延时3秒
                                            ShowMsg("CCD检查");
                                            int nextStep = CCDnDeal(IV2control1);
                                            if (nextStep == 3)
                                            {
                                                PlcIoOutputFlat[PublicValue.OUT1_STOP_CCD] = true;
                                                //区别A1A2A3机种
                                                if (PublicValue.configData.TYPE == (int)TypeA123.A3)
                                                    HandyJobSelected(1, 2);//坐标1
                                                else
                                                {
                                                    //TConfigLine TypeA = ConfigLines[(int)PublicValue.configData.TYPE];//默认A3式样
                                                    PublicValue.configData.LD1 = TypeA.ScrewCount;
                                                    HandyJobSelected(1, TypeA.StartJob);
                                                }
                                            }
                                            PlcIoInputFlat[PublicValue.IN1_STOP_CCD] = false;

                                            if (nextStep == ItemsStep)//CCD再次触发判定
                                                PlcIoInputFlat[PublicValue.IN1_STOP_CCD] = true;

                                        }
                                    }
                                    else
                                    {
                                        //跳过CCD 2021.08.26
                                        UpdateGridItemJudge(ItemsStep, "100%", "OK");
                                        ResetInputFlat();
                                        progWork.Value++;
                                        ItemsStep++;
                                        PlcIoOutputFlat[PublicValue.OUT1_STOP_CCD] = true;
                                        //区别A1A2A3机种
                                        if (PublicValue.configData.TYPE == (int)TypeA123.A3)
                                            HandyJobSelected(1, 2);//坐标1
                                        else
                                        {
                                            //TConfigLine TypeA = ConfigLines[PublicValue.configData.TYPE];//默认A3式样
                                            PublicValue.configData.LD1 = TypeA.ScrewCount;
                                            HandyJobSelected(1, TypeA.StartJob);
                                        }
                                    }
                                }
                                break;
                            case 3://螺钉锁入M6*3
                                {
                                    ScrewDataRecDeal(HANDYID.Handy1, "M6");

                                }
                                break;
                            case 4://本工程MES确认
                                {
                                    int nextStep = MainMesSelfRecord();
                                    if (nextStep == 5)
                                    {
                                        PlcIoOutputFlat[PublicValue.OUT1_STOP_M6] = true;
                                        DataInit();
                                    }

                                }
                                break;
                        }
                    }
                    break;
                case PROINDEX.MainLine2:
                    {
                        //复位检测
                        if (PlcIoInputFlat[PublicValue.IN2_RESET] == true)
                        {
                            MainResetCheck();
                            PlcIoInputFlat[PublicValue.IN2_RESET] = false;
                        } 
                        //实时检测螺钉机1
                        if (PlcIoInputFlat[PublicValue.IN2_SCREW_M6] == true)
                        {
                            ScrewPackCheck(HANDYID.Handy1, 7, "M6");
                            PlcIoInputFlat[PublicValue.IN2_SCREW_M6] = false;
                        }
                        switch (ItemsStep)
                        {
                            case 0://前工程MES确认
                                {
                                    if (PlcIoInputFlat[PublicValue.IN2_BUTTON] == true && ScannerIsOpen != true && IsUdpFinish == true)
                                    {//触发
                                        if (labJudge.Text == "OK")//判断是否下一次作业
                                            DisplayClear();
                                        OpenScaner(PublicValue.QR1);
                                        PlcIoInputFlat[PublicValue.IN2_BUTTON] = false;
                                    }
                                    int nextStep = MainMesPreReq();
                                    if (nextStep == 1)
                                        OpenScaner(PublicValue.QR2);
                                }
                                break;
                            case 1://主继电器QR1
                                {
                                    if (PlcIoInputFlat[PublicValue.IN2_BUTTON] == true && ScannerIsOpen != true && IsUdpFinish == true)
                                    {//按下按钮
                                        OpenScaner(PublicValue.QR2);
                                        PlcIoInputFlat[PublicValue.IN2_BUTTON] = false;
                                    }
                                    QRType type;
                                    if (PublicValue.configData.TYPE == (int)TypeA123.A3|| PublicValue.configData.TYPE == (int)TypeA123.A2)
                                        type = QRType.MainRelayA1Left;
                                    else
                                        type = QRType.MainRelayA1Left;
                                    int nextStep = SubRefMesReq(type, PublicValue.QR2);
                                    if(nextStep == 2)
                                    {
                                        OpenScaner(PublicValue.QR3);
                                    }
                                }
                                break;
                            case 2://主继电器QR2
                                {
                                    QRType type;
                                    if (PublicValue.configData.TYPE == (int)TypeA123.A3 || PublicValue.configData.TYPE == (int)TypeA123.A2)
                                        type = QRType.MainRelayA1Left;
                                    else
                                        type = QRType.MainRelayA1Left;
                                    int nextStep = SubRefMesReq(type, PublicValue.QR3);
                                    if (nextStep == 3)
                                    {
                                        OpenScaner(PublicValue.QR4);
                                    }
                                }
                                break;
                            case 3://主继电器QR3
                                {
                                    QRType type;
                                    if (PublicValue.configData.TYPE == (int)TypeA123.A3 || PublicValue.configData.TYPE == (int)TypeA123.A2)
                                        type = QRType.MainRelayA1Left;
                                    else
                                        type = QRType.MainRelayA1Right;
                                    int nextStep = SubRefMesReq(type, PublicValue.QR4);
                                    if (nextStep == 4)
                                        OpenScaner(PublicValue.QR5);
                                    
                                }
                                break;
                            case 4://主继电器QR4
                                {
                                    QRType type;
                                    if (PublicValue.configData.TYPE == (int)TypeA123.A3 || PublicValue.configData.TYPE == (int)TypeA123.A2)
                                        type = QRType.MainRelayA1Left;
                                    else
                                        type = QRType.MainRelayA1Right;
                                    SubRefMesReq(type, PublicValue.QR5);
                                }
                                break;
                            case 5://升起治具
                                {
                                    if (PlcIoInputFlat[PublicValue.IN2_UP_OK] == true)
                                    {
                                        UpdateGridItemJudge(ItemsStep, "", "OK");
                                        ResetInputFlat();
                                        progWork.Value++;
                                        ItemsStep++;
                                        PlcIoInputFlat[PublicValue.IN2_UP_OK] = false;
                                    }
                                }
                                break;
                            case 6://铜片QR
                                {
                                    if (PlcIoInputFlat[PublicValue.IN2_QR_CU] == true)
                                    {//触发
                                        OpenScaner(PublicValue.QR6);
                                        PlcIoInputFlat[PublicValue.IN2_QR_CU] = false;
                                    }
                                    if (QRbuff[PublicValue.QR6] != "")
                                    {
                                        string qr = QRbuff[PublicValue.QR6];
                                        QRbuff[PublicValue.QR6] = "";
                                        //格式检测
                                        bool rel = CheckShuntQR(qr);
                                        if(rel)
                                        {
                                            UpdateGridItemJudge(ItemsStep, qr, "OK");
                                            ResetInputFlat();
                                            HandyJobSelected(1, 2);
                                            progWork.Value++;
                                            ItemsStep++;
                                        }
                                        else
                                        {
                                            UpdateGridItemJudge(ItemsStep, qr, "NG");
                                            ItemsStep = -1;
                                        }
                                    }
                                }
                                break;
                            case 7://螺钉锁入M6
                                {
                                   ScrewDataRecDeal(HANDYID.Handy1, "M6");

                                }
                                break;
                            case 8://本工程MES确认
                                {
                                    int nextStep = MainMesSelfRecord();
                                    if (nextStep == 9)
                                    {
                                        PlcIoOutputFlat[PublicValue.OUT2_STOP_M6] = true;
                                        DataInit();
                                    }
                                }
                                break;
                        }

                    }
                    break;
                case PROINDEX.MainLine3:
                    {
                        //复位检测
                        if (PlcIoInputFlat[PublicValue.IN3_RESET] == true)
                        {
                            MainResetCheck();
                            PlcIoInputFlat[PublicValue.IN3_RESET] = false;
                        }
                        //实时检测螺钉机1
                        if (PlcIoInputFlat[PublicValue.IN3_SCREW_M6] == true)
                        {
                            ScrewPackCheck(HANDYID.Handy1, 2, "M6");
                            PlcIoInputFlat[PublicValue.IN3_SCREW_M6] = false;
                        }
                        //实时检测螺钉机2
                        if (PlcIoInputFlat[PublicValue.IN3_SCREW_M4] == true)
                        {
                            ScrewPackCheck(HANDYID.Handy2, 3, "M4");
                            PlcIoInputFlat[PublicValue.IN3_SCREW_M4] = false;
                        }
                        switch (ItemsStep)
                        {
                            case 0://前工程MES确认
                                {
                                    if (PlcIoInputFlat[PublicValue.IN3_STOP_M6] == true && ScannerIsOpen != true && IsUdpFinish == true)
                                    {//触发
                                        if (labJudge.Text == "OK")//判断是否下一次作业
                                            DisplayClear();
                                        OpenScaner(PublicValue.QR1);
                                        PlcIoInputFlat[PublicValue.IN3_STOP_M6] = false;
                                    }
                                    MainMesPreReq();
                                }
                                break;
                            case 1://基板QR
                                {
                                    if (PlcIoInputFlat[PublicValue.IN3_QR_BOARD] == true && ScannerIsOpen != true && IsUdpFinish == true)
                                    {//触发                                       
                                        OpenScaner(PublicValue.QR2);
                                        PlcIoInputFlat[PublicValue.IN3_QR_BOARD] = false;
                                    }
                                    int nextStep = SubRefMesReq(QRType.BDSB, PublicValue.QR2);
                                    if (nextStep == 2)
                                    {
                                        HandyJobSelected(1, 2);//电批1
                                    }
                                }
                                break;
                            case 2://螺钉锁入M6
                                {
                                    int nextStep =  ScrewDataRecDeal( HANDYID.Handy1,"M6");
                                    if(nextStep == 3)
                                    {
                                        PlcIoOutputFlat[PublicValue.OUT3_STOP_M6] = true;
                                        HandyJobSelected(2, 2);//切换到下个坐标
                                    }

                                }
                                break;
                            case 3://螺钉锁入M4
                                {
                                    
                                    int nextStep = ScrewDataRecDeal(HANDYID.Handy2, "M4");
                                    if (nextStep == 4)
                                    {
                                        PlcIoOutputFlat[PublicValue.OUT3_STOP_M4] = true;
                                    }
                                }
                                break;
                            case 4://CCD1检查
                                {
                                    if (PublicValue.configData.CCDUSE == "ON")
                                    {
                                        if (PlcIoInputFlat[PublicValue.IN3_STOP_CCD] == true)
                                        {
                                            ShowMsg("1秒后CCD检查");
                                            PublicValue.Delay(1000);//延时3秒
                                            ShowMsg("CCD检查");
                                            int nextStep = CCDnDeal(IV2control1);
                                            if (nextStep == -1)
                                            {
                                                CCDOutputPLC(MES_RESULT.NG);
                                            }
                                            PlcIoInputFlat[PublicValue.IN3_STOP_CCD] = false;

                                            if (nextStep == ItemsStep)//CCD再次触发判定
                                                PlcIoInputFlat[PublicValue.IN3_STOP_CCD] = true;
                                        }
                                    }
                                    else
                                    {
                                        //跳过CCD 2021.08.26
                                        UpdateGridItemJudge(ItemsStep, "100%", "OK");
                                        ResetInputFlat();
                                        progWork.Value++;
                                        ItemsStep++;
                                    }
                             
                                   
                                }
                                break;
                            case 5://CCD2检查
                                {
                                    if (PublicValue.configData.CCDUSE == "ON")
                                    {
                                        int nextStep = CCDnDeal(IV2control2);
                                        //CCD结果输出PLC
                                        if (nextStep == 6)//OK
                                        {
                                            CCDOutputPLC(MES_RESULT.OK);
                                        }
                                        else if (nextStep == -1)
                                        {
                                            CCDOutputPLC(MES_RESULT.NG);
                                        }
                                    }
                                    else
                                    {
                                        //跳过CCD 2021.08.26
                                        UpdateGridItemJudge(ItemsStep, "100%", "OK");
                                        ResetInputFlat();
                                        progWork.Value++;
                                        ItemsStep++;
                                    }
                                }
                                break;
                            case 6://本工程MES确认
                                {
                                    int nextStep = MainMesSelfRecord();
                                    if (nextStep == 7)
                                    {
                                        DataInit();
                                    }

                                }
                                break;
                        }
                    }
                    break;
                case PROINDEX.MainLine4:
                    {
                        //复位检测
                        if (PlcIoInputFlat[PublicValue.IN4_RESET] == true)
                        {
                            MainResetCheck();
                            PlcIoInputFlat[PublicValue.IN4_RESET] = false;
                        }
                        switch (ItemsStep)
                        {
                            case 0://前工程MES确认
                                {
                                    if (PlcIoInputFlat[PublicValue.IN4_QR_PANA] == true && ScannerIsOpen != true && IsUdpFinish == true)
                                    {//触发
                                        if (labJudge.Text == "OK")//判断是否下一次作业
                                            DisplayClear();
                                        OpenScaner(PublicValue.QR1);
                                        PlcIoInputFlat[PublicValue.IN4_QR_PANA] = false;
                                    }
                                    MainMesPreReq();
                                }
                                break;
                            case 1://CCD1检查
                                {
                                    if (PublicValue.configData.CCDUSE == "ON")
                                    {
                                        if (PlcIoInputFlat[PublicValue.IN4_STOP_CCD] == true)
                                        {
                                            ShowMsg("3秒后CCD检查");
                                            PublicValue.Delay(3000);//延时3秒
                                            ShowMsg("CCD检查");
                                            int nextStep = CCDnDeal(IV2control1);
                                            PlcIoInputFlat[PublicValue.IN4_STOP_CCD] = false;

                                            if (nextStep == ItemsStep)//CCD再次触发判定
                                                PlcIoInputFlat[PublicValue.IN4_STOP_CCD] = true;
                                        }
                                    }
                                  else
                                    {
                                        //跳过CCD 2021.08.26
                                        UpdateGridItemJudge(ItemsStep, "100%", "OK");
                                        ResetInputFlat();
                                        progWork.Value++;
                                        ItemsStep++;
                                    }
                                }
                                break;
                            case 2://CCD2检查
                                {
                                    if (PublicValue.configData.CCDUSE == "ON")
                                    {
                                        CCDnDeal(IV2control2);
                                    }
                                    else
                                    {
                                        //跳过CCD 2021.08.26
                                        UpdateGridItemJudge(ItemsStep, "100%", "OK");
                                        ResetInputFlat();
                                        progWork.Value++;
                                        ItemsStep++;
                                    }
                                }
                                break;
                            case 3://CCD3查
                                {
                                    if (PublicValue.configData.CCDUSE == "ON")
                                    {
                                        CCDnDeal(IV2control3);
                                    }
                                    else
                                    {
                                        //跳过CCD 2021.08.26
                                        UpdateGridItemJudge(ItemsStep, "100%", "OK");
                                        ResetInputFlat();
                                        progWork.Value++;
                                        ItemsStep++;
                                    }
                                }
                                break;
                            case 4://CCD4检查
                                {
                                    if (PublicValue.configData.CCDUSE == "ON")
                                    {
                                        CCDnDeal(IV2control4);
                                    }
                                    else
                                    {
                                        //跳过CCD 2021.08.26
                                        UpdateGridItemJudge(ItemsStep, "100%", "OK");
                                        ResetInputFlat();
                                        progWork.Value++;
                                        ItemsStep++;
                                    }
                                }
                                break;
                            case 5://MES本工程确认
                                {
                                    int nextStep = MainMesSelfRecord();
                                    if (nextStep == 6)
                                    {
                                        PlcIoOutputFlat[PublicValue.OUT4_STOP_CCD] = true;
                                        DataInit();
                                    }
                                }
                                break;
                        }
                    }
                    break;
                case PROINDEX.MainLine5:
                    {
                        //复位检测
                        if (PlcIoInputFlat[PublicValue.IN5_RESET] == true)
                        {
                            MainResetCheck();
                            PlcIoInputFlat[PublicValue.IN5_RESET] = false;
                        }
                        //实时检测螺钉机1
                        if (PlcIoInputFlat[PublicValue.IN5_SCREW_M5] == true)
                        {
                            ScrewPackCheck(HANDYID.Handy1, 1, "M5");
                            PlcIoInputFlat[PublicValue.IN5_SCREW_M5] = false;
                        }
                        switch (ItemsStep)
                        {
                            case 0://前工程MES确认
                                {
                                    if (PlcIoInputFlat[PublicValue.IN5_STOP_M5] == true && ScannerIsOpen != true && IsUdpFinish == true)
                                    {//触发
                                        if (labJudge.Text == "OK")//判断是否下一次作业
                                            DisplayClear();
                                        OpenScaner(PublicValue.QR1);
                                        PlcIoInputFlat[PublicValue.IN5_STOP_M5] = false;
                                    }
                                    int nextStep = MainMesPreReq();
                                    if(nextStep == 1)
                                        HandyJobSelected(1, 2);//坐标1
                                }
                                break;
                            case 1://螺钉锁紧M5
                                {
                                    ScrewDataRecDeal(HANDYID.Handy1, "M5");
                                }
                                break;
                            case 2://MES本工程确认
                                {
                                    int nextStep = MainMesSelfRecord();
                                    if (nextStep == 3)
                                    {
                                        PlcIoOutputFlat[PublicValue.OUT5_STOP_M5] = true;
                                        DataInit();
                                    }
                                }
                                break;
                        }
                    }
                    break;
                case PROINDEX.MainLine6:
                    {
                        //复位检测
                        if (PlcIoInputFlat[PublicValue.IN6_RESET] == true)
                        {
                            MainResetCheck();
                            PlcIoInputFlat[PublicValue.IN6_RESET] = false;
                        }
                        //实时检测螺钉机1
                        if (PlcIoInputFlat[PublicValue.IN6_SCREW_M4] == true)
                        {
                            ScrewPackCheck(HANDYID.Handy1, 2, "M4");
                            PlcIoInputFlat[PublicValue.IN6_SCREW_M4] = false;
                        }
                        //实时检测螺钉机2
                        if (PlcIoInputFlat[PublicValue.IN6_SCREW_M6] == true)
                        {
                           
                            if (ItemsStep < 8)
                                ScrewPackCheck(HANDYID.Handy2, 7, "M6");
                            else
                            {
                                if (ItemsStep == 9)//锁螺钉步骤
                                {
                                    ScrewPackCount2++;
                                    if (ScrewPackCount2 <= 1)
                                    {
                                        UpdateGridItemJudge(ItemsStep,"M6*" + ScrewPackCount2, "");//表格中显示取出螺钉数量             
                                    }
                                    else
                                    {
                                        //人为失误ERR修复
                                        NGBtnClick manSel = ManuDealNGshow(NGTpye.Operator, "取出螺钉数异常！");
                                        if (manSel != NGBtnClick.CLEAR)
                                        {
                                            TotalJudgeMsg = "取出螺钉数异常！";
                                            ItemsStep = -1;
                                        }
                                        
                                    }
                                }
                                else
                                {
                                    //人为失误ERR修复
                                    NGBtnClick manSel = ManuDealNGshow(NGTpye.Operator, "目前不是锁螺钉步骤！");
                                    if (manSel == NGBtnClick.CLEAR)
                                    {
                                        TotalJudgeMsg = "目前不是锁螺钉步骤！";
                                        ItemsStep = -1;
                                    }
                                  
                                }
                            }
                            PlcIoInputFlat[PublicValue.IN6_SCREW_M6] = false;
                        }
                        //步骤扫描
                        switch (ItemsStep)
                        {
                            case 0://前工程MES确认
                                {
                                    if (PlcIoInputFlat[PublicValue.IN6_STOP_M4] == true && ScannerIsOpen != true && IsUdpFinish == true)
                                    {//触发
                                        if (labJudge.Text == "OK")//判断是否下一次作业
                                            DisplayClear();
                                        OpenScaner(PublicValue.QR1);
                                        PlcIoInputFlat[PublicValue.IN6_STOP_M4] = false;
                                    }
                                    int nextStep = MainMesPreReq();
                                    if (nextStep == 1)
                                        OpenScaner(PublicValue.QR2);//触发托盘QR扫描仪
                                }
                                break;
                            case 1://托盘QR
                                {
                                    if (QRbuff[PublicValue.QR2] != "")
                                    {
                                        string qr = QRbuff[PublicValue.QR2];
                                        QRbuff[PublicValue.QR2] = "";
                                        //格式检测逻辑处理
                                        if(CheckQRFomat(QRType.Panel,qr))
                                        {
                                            UpdateGridItemJudge(ItemsStep, qr, "OK");
                                            ResetInputFlat();
                                            HandyJobSelected(1, 2);//电批1
                                     
                                            progWork.Value++;
                                            ItemsStep++;
                                        }
                                        else
                                        {
                                            //人为失误ERR修复
                                            NGBtnClick manSel = ManuDealNGshow(NGTpye.Operator, "部品混入！QR:" + qr);
                                            if (manSel == NGBtnClick.CLEAR)
                                                break;
                                            UpdateGridItemJudge(ItemsStep, qr, "NG");
                                            //txtPana.BackColor = Color.Red;
                                            TotalJudgeMsg = "部品混入";
                                            ItemsStep = -1;
                                        }
                                   
                                    }
                                }
                                break;
                            case 2://螺钉锁紧M4
                                {
                                    int nextStep = ScrewDataRecDeal(HANDYID.Handy1, "M4");
                                    if (nextStep == 3)
                                    {
                                        PlcIoOutputFlat[PublicValue.OUT6_STOP_M4] = true;
                                    }
                                }
                                break;
                            case 3://CCD1检查
                                {
                                    if (PublicValue.configData.CCDUSE == "ON")
                                    {
                                        if (PlcIoInputFlat[PublicValue.IN6_STOP_CCD] == true)
                                        {
                                            ShowMsg("3秒后CCD检查");
                                            PublicValue.Delay(3000);//延时3秒
                                            ShowMsg("CCD检查");
                                            int nextStep = CCDnDeal(IV2control1);
                                            PlcIoInputFlat[PublicValue.IN6_STOP_CCD] = false;

                                            if (nextStep == ItemsStep)//CCD再次触发判定
                                                PlcIoInputFlat[PublicValue.IN6_STOP_CCD] = true;
                                        }
                                    }
                                    else
                                    {
                                        //跳过CCD 2021.08.26
                                        UpdateGridItemJudge(ItemsStep, "100%", "OK");
                                        ResetInputFlat();
                                        progWork.Value++;
                                        ItemsStep++;
                                    }
                                }
                                break;
                            case 4://CCD2检查
                                {
                                    if (PublicValue.configData.CCDUSE == "ON")
                                    {
                                        int nextStep = CCDnDeal(IV2control2);
                                        if (nextStep == 5)
                                        {
                                            PlcIoOutputFlat[PublicValue.OUT6_STOP_CCD] = true;
                                        }
                                        PlcIoInputFlat[PublicValue.IN6_STOP_CCD] = false;
                                    }
                                    else
                                    {
                                        //跳过CCD 2021.08.26
                                        UpdateGridItemJudge(ItemsStep, "100%", "OK");
                                        ResetInputFlat();
                                        PlcIoOutputFlat[PublicValue.OUT6_STOP_CCD] = true;
                                        progWork.Value++;
                                        ItemsStep++;
                                    }
                                }
                                break;
                            case 5://升起治具
                                {
                                    if (PlcIoInputFlat[PublicValue.IN6_UP_OK] == true)
                                    {
                                        UpdateGridItemJudge(ItemsStep, "", "OK");
                                        ResetInputFlat();
                                        progWork.Value++;
                                        ItemsStep++;
                                        if(PublicValue.configData.QR3 == "ON")
                                            OpenScaner(PublicValue.QR3);
                                        PlcIoInputFlat[PublicValue.IN6_UP_OK] = false;
                                    }
                                }
                                break;
                            case 6://水冷板QR
                                {
                                    if (PlcIoInputFlat[PublicValue.IN6_QR_WATER] == true)
                                    {//触发
                                        OpenScaner(PublicValue.QR3);
                                        PlcIoInputFlat[PublicValue.IN6_QR_WATER] = false;
                                    }
                                    int nextStep = SubRefMesReq(QRType.Water, PublicValue.QR3);
                                    if (nextStep == 7)
                                    {
                                        //HandyJobSelected(2, 2);//电批2
                                        //区别A1A2A3机种
                                        if (PublicValue.configData.TYPE == (int)TypeA123.A3)
                                            HandyJobSelected(2, 2);
                                        else
                                            HandyJobSelected(2, TypeA.StartJob);
                                        
                                    }
                                }
                                break;
                            case 7://螺钉锁紧M6
                                {
                                    int nextStep = ScrewDataRecDeal(HANDYID.Handy2, "M6");
                                    if(nextStep == 8)
                                    {
                                        ScrewPackCount2 = 0;//为下一个锁螺钉检测做准备
                                        OpenScaner(PublicValue.QR4);

                                    }
                                }
                                break;
                            case 8://保险丝QR
                                {
                                    if (PlcIoInputFlat[PublicValue.IN6_QR_SAFT] == true)
                                    {//触发
                                        OpenScaner(PublicValue.QR4);
                                        PlcIoInputFlat[PublicValue.IN6_QR_SAFT] = false;
                                    }
                                    int nextStep = SubRefMesReq(QRType.Safe, PublicValue.QR4);
                                    if (nextStep == 9)
                                    {
                                        if (PublicValue.configData.TYPE == (int)TypeA123.A3)
                                            HandyJobSelected(2, 7);//2-7
                                        else
                                            HandyJobSelected(2, 14);//9-14

                                    }

                                }
                                break;
                            case 9://螺钉锁紧M6
                                {
                                    if (handyData2.flat == true)
                                    {
                                        handyData2.flat = false;
                                        AddGridHandyData(handyData2);
                                        if (handyData2.judge == "O")
                                        {
                                            UpdateGridItemJudge(ItemsStep, "M6*1", "OK");
                                            //本工程确认后再松开气缸
                                            ResetInputFlat();
                                            progWork.Value++;
                                            ItemsStep++;

                                        }
                                        else
                                        {
                                            UpdateGridItemJudge(ItemsStep, "M6*1", "NG");
                                            TotalJudgeMsg = "NG";
                                            ItemsStep = -1;
                                        }
                                    }
                                }
                                break;
                            case 10://本工程确认
                                {
                                    int nextStep = MainMesSelfRecord();
                                    if (nextStep == 11)
                                    {
                                        PlcIoOutputFlat[PublicValue.OUT6_STOP_M6] = true;
                                        DataInit();

                                    }
                                }
                                break;
                        }
                    }
                    break;
                case PROINDEX.MainLine7:
                    {
                        //复位检测
                        if (PlcIoInputFlat[PublicValue.IN7_RESET] == true)
                        {
                            MainResetCheck();
                            PlcIoInputFlat[PublicValue.IN7_RESET] = false;
                        }
                        //实时检测螺钉机1
                        if (PlcIoInputFlat[PublicValue.IN7_SCREW_M4_1] == true)
                        {
                            ScrewPackCheck(HANDYID.Handy1, 1, "M4");
                            PlcIoInputFlat[PublicValue.IN7_SCREW_M4_1] = false;
                        }
                        //实时检测螺钉机2
                        if (PlcIoInputFlat[PublicValue.IN7_SCREW_M4_2] == true)
                        {
                            ScrewPackCheck(HANDYID.Handy2, 2, "M4");
                            PlcIoInputFlat[PublicValue.IN7_SCREW_M4_2] = false;
                        }
                        switch (ItemsStep)
                        {
                            case 0://前工程MES确认
                                {
                                    if (PlcIoInputFlat[PublicValue.IN7_QR_PANA] == true && ScannerIsOpen != true && IsUdpFinish == true)
                                    {//触发
                                        if (labJudge.Text == "OK")//判断是否下一次作业
                                            DisplayClear();
                                        OpenScaner(PublicValue.QR1);
                                        PlcIoInputFlat[PublicValue.IN7_QR_PANA] = false;
                                    }
                                    int nextStep = MainMesPreReq();
                                    if (nextStep == 1)
                                        HandyJobSelected(1, 2);//电批1
                                }
                                break;
                            case 1://螺钉M4
                                {
                                    int nextStep = ScrewDataRecDeal(HANDYID.Handy1, "M4");
                                    if (nextStep == 2)
                                    {
                                        PlcIoOutputFlat[PublicValue.OUT7_STOP_M4_1] = true;
                                        HandyJobSelected(2, 2);//电批2
                                    }
                                }
                                break;
                            case 2://螺钉M4
                                {
                                    int nextStep = ScrewDataRecDeal(HANDYID.Handy2, "M4");
                                    if (nextStep == 3)
                                    {
                                        PlcIoOutputFlat[PublicValue.OUT7_STOP_M4_2] = true;
                                    }
                                }
                                break;
                            case 3://CCD1检查
                                {
                                    if (PublicValue.configData.CCDUSE == "ON")
                                    {
                                        if (PlcIoInputFlat[PublicValue.IN7_STOP_CCD] == true)
                                        {
                                            ShowMsg("1秒后CCD检查");
                                            PublicValue.Delay(1000);//延时3秒
                                            ShowMsg("CCD检查");
                                            int nextStep = CCDnDeal(IV2control1);
                                            //CCD结果输出PLC
                                            if(nextStep == 4)//OK
                                            {
                                                CCDOutputPLC(MES_RESULT.OK);
                                            }
                                            else if(nextStep == -1)
                                            {
                                                CCDOutputPLC(MES_RESULT.NG);
                                            }

                                            PlcIoInputFlat[PublicValue.IN7_STOP_CCD] = false;

                                            if (nextStep == ItemsStep)//CCD再次触发判定
                                                PlcIoInputFlat[PublicValue.IN7_STOP_CCD] = true;
                                        }
                                    }
                                    else
                                    {
                                        //跳过CCD 2021.08.26
                                        UpdateGridItemJudge(ItemsStep, "100%", "OK");
                                        ResetInputFlat();
                                        progWork.Value++;
                                        ItemsStep++;
                                    }
                                
                                }
                                break;
                            case 4://本工程确认
                                {
                                    int nextStep = MainMesSelfRecord();
                                    if(nextStep == 5)
                                    {
                                        DataInit();
                                    }
                                }
                                break;
                        }
                    }
                    break;
                case PROINDEX.MainLine8:
                    {
                        //复位检测
                        if (PlcIoInputFlat[PublicValue.IN8_RESET] == true)
                        {
                            MainResetCheck();
                            PlcIoInputFlat[PublicValue.IN8_RESET] = false;
                        }
                        //实时检测螺钉机1
                        if (PlcIoInputFlat[PublicValue.IN8_SCREW_M4] == true)
                        {
                            ScrewPackCheck(HANDYID.Handy1, 1, "M4");
                            PlcIoInputFlat[PublicValue.IN8_SCREW_M4] = false;
                        }
                        switch (ItemsStep)
                        {
                            case 0://前工程确认
                                {
                                    if (PlcIoInputFlat[PublicValue.IN8_QR_PANA] == true && ScannerIsOpen != true && IsUdpFinish == true)
                                    {//触发
                                        if (labJudge.Text == "OK")//判断是否下一次作业
                                            DisplayClear();
                                        OpenScaner(PublicValue.QR1);
                                        PlcIoInputFlat[PublicValue.IN8_QR_PANA] = false;
                                    }
                                    int nextStep = MainMesPreReq();
                                    if(nextStep == 1)
                                        HandyJobSelected(1, 2);//坐标1
                                }
                                break;
                            case 1://螺钉锁入M4
                                {
                                    ScrewDataRecDeal(HANDYID.Handy1, "M4");
                                }
                                break;
                            case 2://本工程确认
                                {
                                    int nextStep = MainMesSelfRecord();
                                    if (nextStep == 3)
                                    {
                                        PlcIoOutputFlat[PublicValue.OUT8_STOP_M4] = true;
                                        DataInit();

                                    }
                                }
                                break;
                        }
                    }
                    break;
                case PROINDEX.MainLine9:
                    {
                        //复位检测
                        if (PlcIoInputFlat[PublicValue.IN9_RESET] == true)
                        {
                            MainResetCheck();
                            PlcIoInputFlat[PublicValue.IN9_RESET] = false;
                        }
                        switch (ItemsStep)
                        {
                            case 0://前工程确认
                                {
                                    if (PlcIoInputFlat[PublicValue.IN9_QR_PANA] == true && ScannerIsOpen != true && IsUdpFinish == true)
                                    {//触发
                                        if (labJudge.Text == "OK")//判断是否下一次作业
                                            DisplayClear();
                                        OpenScaner(PublicValue.QR1);
                                        PlcIoInputFlat[PublicValue.IN9_QR_PANA] = false;
                                    }
                                    MainMesPreReq();
                                }
                                break;
                            case 1://GM铭板照合
                                {
                                    string rel = MesAppUdpRec(UDPMODE.Start);//MES前工程确认
                     
                                    if (rel != "" && labJudge.Text == "----")
                                    {
                                        string codeErr = GetUdpErrCode(rel);
                                        bool isRepeat = false;
                                        if (PublicValue.configData.REPEAT == "ON")//允许重做
                                            if (codeErr == "22")
                                                isRepeat = true;
                                        if (codeErr == "00" || isRepeat)
                                        {
                                            UpdateGridItemJudge(ItemsStep, "E" + codeErr, "OK");
                                            ResetInputFlat();//为了防止在进入下一步之前已经触发了传感器，标志被置位
                                            progWork.Value++;
                                            ItemsStep++;
                                            PlcIoOutputFlat[PublicValue.OUT9_STOP_GM] = true;
                                        }
                                        else
                                        {
                                            UpdateGridItemJudge(ItemsStep, "E" + codeErr, "NG");
                                            TotalJudgeMsg = codeErr;
                                            ItemsStep = -1;
                                        }
                                    }
                                }
                                break;
                            case 2://外观检查确认
                                {
                                    if (PlcIoInputFlat[PublicValue.IN9_ENDBUTTON] == true)
                                    {
                                        UpdateGridItemJudge(ItemsStep, "", "OK");
                                        ResetInputFlat();//为了防止在进入下一步之前已经触发了传感器，标志被置位
                                        progWork.Value++;
                                        ItemsStep++;
                                        PlcIoInputFlat[PublicValue.IN9_ENDBUTTON] = false;
                                    }
                                }
                                break;
                            case 3://本工程确认
                                {
                                    int nextStep = MainMesSelfRecord();
                                    if (nextStep == 4)
                                    {
                                        PlcIoOutputFlat[PublicValue.OUT9_STOP_END] = true;
                                        DataInit();
                                    }
                                }
                                break;
                        }
                    }
                    break;
                case PROINDEX.RelayLine:
                    {
                        //复位检测
                        if (PlcIoInputFlat[PublicValue.INRealy_RESET] == true)
                        {
                            MainResetCheck();
                            PlcIoInputFlat[PublicValue.INRealy_RESET] = false;
                        }
                        //实时检测螺钉机1
                        if (PlcIoInputFlat[PublicValue.INRealy_SCREW_M5] == true)
                        {
                            ScrewPackCheck(HANDYID.Handy1, 4, "M5");
                            PlcIoInputFlat[PublicValue.INRealy_SCREW_M5] = false;
                        }
                        switch(ItemsStep)
                        {
                            case 0://主继电器QR1
                                {
                                    if (PlcIoInputFlat[PublicValue.INRealy_STOP_M5] == true && ScannerIsOpen != true && IsUdpFinish == true)
                                    {//到位
                                        if (txtPana.Text == "")
                                        {
                                            ShowMsg("生产指示No未录入");
                                            PlcIoInputFlat[PublicValue.INRealy_STOP_M5] = false;
                                            break;
                                        }
                                        if (labJudge.Text == "OK")//下一台
                                        {
                                            DisplayClear();
                                        }
                                        OpenScaner(PublicValue.QR1);
                                        PlcIoInputFlat[PublicValue.INRealy_STOP_M5] = false;
                                    }
                                    int nextStep = SubRefMesReq(QRType.MainRelayA2A3, PublicValue.QR1);
                                    MainRelay1QR = CurrSubQR;
                                    CurrPanaQR = CurrSubQR;//作用于履历保存的名称
                                    if (nextStep == 1)
                                    {
                                        WorkStartTimeCount = Environment.TickCount;
                                        handyData1.flat = false;//电批数据点检残留清除
                                        handyData2.flat = false;
                                        OpenScaner(PublicValue.QR2);
                                    }
                                }
                                break;
                            case 1://主继电器QR2
                                {
                                    int nextStep = SubRefMesReq(QRType.MainRelayA2A3, PublicValue.QR2);
                                    MainRelay2QR = CurrSubQR;

                                    if (nextStep == 2)
                                    {
                                        OpenScaner(PublicValue.QR3);
                                    }
                                }
                                break;
                            case 2://主继电器QR3
                                {
                                    int nextStep = SubRefMesReq(QRType.MainRelayA2A3, PublicValue.QR3);
                                    MainRelay3QR = CurrSubQR;
                                    if (nextStep == 3)
                                    {
                                        OpenScaner(PublicValue.QR4);
                                    }
                                }
                                break;
                            case 3://主继电器QR4
                                {
                                    int nextStep = SubRefMesReq(QRType.MainRelayA2A3, PublicValue.QR4);
                                    MainRelay4QR = CurrSubQR;
                                    if (nextStep == 4)
                                    {
                                        //区别A1A2A3机种
                                        if (PublicValue.configData.TYPE == (int)TypeA123.A3)
                                            HandyJobSelected(1, 2);//坐标1
                                        else
                                        {
                             
                                            PublicValue.configData.LD1 = TypeA.ScrewCount;
                                            HandyJobSelected(1, TypeA.StartJob);
                                        }
                                    }
                                }
                                break;
                            case 4://螺钉锁入M5
                                {
                                    int handyOKCount = HandyOKCount1;
                                    ScrewDataRecDeal(HANDYID.Handy1, "M5");
                                    if(handyOKCount == 1 && HandyOKCount1 == 2)
                                    {
                                        ServerAPPMsg = "";
                                        UdpSend(UDPMODE.End, "", txtPana.Text, MainRelay1QR, MES_RESULT.OK);
                                    }
                                    if (handyOKCount == 3 && HandyOKCount1 == 4)
                                    {
                                        ServerAPPMsg = "";
                                        UdpSend(UDPMODE.End, "", txtPana.Text, MainRelay2QR, MES_RESULT.OK);
                                    }
                                    if (handyOKCount == 5 && HandyOKCount1 == 6)
                                    {
                                        ServerAPPMsg = "";
                                        UdpSend(UDPMODE.End, "", txtPana.Text, MainRelay3QR, MES_RESULT.OK);
                                    }
                                    if (handyOKCount == 7 && HandyOKCount1 == 8)
                                    {
                                        ServerAPPMsg = "";
                                        UdpSend(UDPMODE.End, "", txtPana.Text, MainRelay4QR, MES_RESULT.OK);
                                        ItemsStep = 4;
                                    }
                                    //收到应答后才能进入下一步，做一个拦截
                                    if(HandyOKCount1 == PublicValue.configData.LD1 && ServerAPPMsg != "")
                                    {
                                        ItemsStep = 5;
                                    }
                                }
                                break;
                            case 5://本工程确认
                                {
                                    CurrSubQR = "";//追加2021.08.19
                                    int nextStep = MainMesSelfRecord();
                                    if (nextStep == 6)
                                    {
                                        PlcIoOutputFlat[PublicValue.OUTRealy_STOP_M5] = true;
                                        DataInit();

                                    }
                                }
                                break;
                        }
                    }
                    break;
                case PROINDEX.BDSBLine:
                    {
                        //复位检测
                        if (PlcIoInputFlat[PublicValue.INBDSB_RESET] == true)
                        {
                            MainResetCheck();
                            PlcIoInputFlat[PublicValue.INBDSB_RESET] = false;
                        }
                        //实时检测螺钉机1
                        if (PlcIoInputFlat[PublicValue.INBDSB_SCREW_M4] == true)
                        {
                            ScrewPackCheck(HANDYID.Handy1, 1, "M4");
                            PlcIoInputFlat[PublicValue.INBDSB_SCREW_M4] = false;
                        }
                        switch (ItemsStep)
                        {
                            case 0://基板QR
                                {
                                    if (PlcIoInputFlat[PublicValue.INBDSB_QR_BOARD] == true && ScannerIsOpen != true && IsUdpFinish == true)
                                    {//到位
                                        if (txtPana.Text == "")
                                        {
                                            ShowMsg("生产指示No未录入");
                                            PlcIoInputFlat[PublicValue.INBDSB_QR_BOARD] = false;
                                            break;
                                        }
                                        if(labJudge.Text == "OK")//下一台
                                        {
                                            DisplayClear();
                                        }
                                        OpenScaner(PublicValue.QR1);
                                        PlcIoInputFlat[PublicValue.INBDSB_QR_BOARD] = false;
                                    }
                                    int nextStep = SubRefMesReq(QRType.BDSB, PublicValue.QR1);
                                    CurrPanaQR = CurrSubQR;
                                    if (nextStep == 1)
                                    {
                                        WorkStartTimeCount = Environment.TickCount;
                                        handyData1.flat = false;//电批数据点检残留清除
                                        handyData2.flat = false;
                                        HandyJobSelected(1, 2);
                                    }
                                }
                                break;
                            case 1://螺钉锁入M4
                                {
                                    int nextStep =  ScrewDataRecDeal(HANDYID.Handy1, "M4");
                                    if(nextStep == 2)
                                        PlcIoOutputFlat[PublicValue.OUTBDSB_STOP_M4] = true;

                                }
                                break;
                            case 2://CCD1检查
                                {
                                    if (PublicValue.configData.CCDUSE == "ON")
                                    {
                                        if (PlcIoInputFlat[PublicValue.INBDSB_STOP_CCD] == true)
                                        {
                                            ShowMsg("3秒后CCD检查");
                                            PublicValue.Delay(3000);//延时3秒
                                            ShowMsg("CCD检查");
                                            int nextStep = CCDnDeal(IV2control1);
                                            if (nextStep == 3)
                                                PlcIoOutputFlat[PublicValue.OUTBDSB_STOP_CCD] = true;
                                            PlcIoInputFlat[PublicValue.INBDSB_STOP_CCD] = false;

                                            if (nextStep == ItemsStep)//CCD再次触发判定
                                                PlcIoInputFlat[PublicValue.INBDSB_STOP_CCD] = true;
                                        }
                                    }
                                    else
                                    {
                                        //跳过CCD 2021.08.26
                                        UpdateGridItemJudge(ItemsStep, "100%", "OK");
                                        ResetInputFlat();
                                        progWork.Value++;
                                        ItemsStep++;
                                    }
                                 
                                }
                                break;
                            case 3://本工程确认
                                {
                                    int nextStep = MainMesSelfRecord();
                                    if (nextStep == 4)
                                    {
                                        PlcIoOutputFlat[PublicValue.OUTBDSB_STOP_CCD] = true;
                                        DataInit();
                                    }
                                }
                                break;
                        }
                    }
                    break;
                case PROINDEX.WaterLine:
                    {
                        //复位检测
                        if (PlcIoInputFlat[PublicValue.INSAFT_RESET] == true)
                        {
                            MainResetCheck();
                            PlcIoInputFlat[PublicValue.INSAFT_RESET] = false;
                        }
                        switch (ItemsStep)
                        {
                            case 0://水冷板QR
                                {
                                    if (PlcIoInputFlat[PublicValue.INWATER_QR_WATER] == true && ScannerIsOpen != true && IsUdpFinish == true)
                                    {//到位
                                        if (txtPana.Text == "")
                                        {
                                            ShowMsg("生产指示No未录入");
                                            PlcIoInputFlat[PublicValue.INWATER_QR_WATER] = false;
                                            break;
                                        }
                                        if (labJudge.Text == "OK")//下一台
                                        {
                                            DisplayClear();
                                        }
                                        OpenScaner(PublicValue.QR1);
                                        PlcIoInputFlat[PublicValue.INWATER_QR_WATER] = false;
                                    }
                                    int nextStep = SubRefMesReq(QRType.Water, PublicValue.QR1);
                                    CurrPanaQR = CurrSubQR;//作用于履历保存的名称
                                    if (nextStep == 1)
                                    {
                                        WorkStartTimeCount = Environment.TickCount;
                                    }

                                }
                                break;
                            case 1://CCD1检查
                                {
                                    if (PublicValue.configData.CCDUSE == "ON")
                                    {
                                        if (PlcIoInputFlat[PublicValue.INWATER_STOP_CCD] == true)
                                        {
                                            ShowMsg("3秒后CCD检查");
                                            PublicValue.Delay(3000);//延时3秒
                                            ShowMsg("CCD检查");
                                            int nextStep = CCDnDeal(IV2control1);
                                            PlcIoInputFlat[PublicValue.INWATER_STOP_CCD] = false;

                                            if (nextStep == ItemsStep)//CCD再次触发判定
                                                PlcIoInputFlat[PublicValue.INWATER_STOP_CCD] = true;
                                        }
                                    }
                                    else
                                    {
                                        UpdateGridItemJudge(ItemsStep, "100%", "OK");
                                        ResetInputFlat();
                                        progWork.Value++;
                                        ItemsStep++;
                                    }
                                }

                                break;
                            case 2://CCD2检查
                                {
                                    if (PublicValue.configData.CCDUSE == "ON")
                                    {
                                        CCDnDeal(IV2control2);
                                    }
                                    else
                                    {
                                        //跳过CCD 2021.08.26
                                        UpdateGridItemJudge(ItemsStep, "100%", "OK");
                                        ResetInputFlat();
                                        progWork.Value++;
                                        ItemsStep++;
                                    }
                          
                                }
                                break;
                            case 3://CCD3检查
                                {
                                    if (PublicValue.configData.CCDUSE == "ON")
                                    {
                                        CCDnDeal(IV2control3);
                                    }
                                    else
                                    {
                                        //跳过CCD 2021.08.26
                                        UpdateGridItemJudge(ItemsStep, "100%", "OK");
                                        ResetInputFlat();
                                        progWork.Value++;
                                        ItemsStep++;
                                    }

                                }
                                break;
                            case 4://本工程确认
                                {
                                    int nextStep = MainMesSelfRecord();
                                    if (nextStep == 5)
                                    {
                                        PlcIoOutputFlat[PublicValue.OUTWATER_STOP_CCD] = true;
                                        DataInit();
                                    }
                                }
                                break;
                        }

                    }
                    break;
                case PROINDEX.SafeLine:
                    {
                        //复位检测
                        if (PlcIoInputFlat[PublicValue.INSAFT_RESET] == true)
                        {
                            MainResetCheck();
                            PlcIoInputFlat[PublicValue.INSAFT_RESET] = false;
                        }
                        //实时检测螺钉机1
                        if (PlcIoInputFlat[PublicValue.INSAFT_SCREW_M6] == true)
                        {
                            ScrewPackCheck(HANDYID.Handy1, 1, "M6");
                            PlcIoInputFlat[PublicValue.INSAFT_SCREW_M6] = false;
                        }
                        switch (ItemsStep)
                        {
                            case 0://保险丝QR
                                {
                                    if (PlcIoInputFlat[PublicValue.INSAFT_STOP_M6] == true && ScannerIsOpen != true && IsUdpFinish == true)
                                    {//到位
                                        if (txtPana.Text == "")
                                        {
                                            ShowMsg("生产指示No未录入");
                                            PlcIoInputFlat[PublicValue.INSAFT_STOP_M6] = false;
                                            break;
                                        }
                                        if (labJudge.Text == "OK")//下一台
                                        {
                                            DisplayClear();
                                        }
                                        OpenScaner(PublicValue.QR1);
                                        PlcIoInputFlat[PublicValue.INSAFT_STOP_M6] = false;
                                    }
                                    int nextStep = SubRefMesReq(QRType.Safe, PublicValue.QR1);
                                    CurrPanaQR = CurrSubQR;
                                    if (nextStep == 1)
                                    {
                                        WorkStartTimeCount = Environment.TickCount;
                                        handyData1.flat = false;//电批数据点检残留清除
                                        handyData2.flat = false;
                                        HandyJobSelected(1, 2);
                                    }
                                }
                                break;
                            case 1://螺钉锁入M6
                                {
                                    ScrewDataRecDeal(HANDYID.Handy1, "M6");
                                }
                                break;
                            case 2://本工程确认
                                {
                                    int nextStep = MainMesSelfRecord();
                                    if (nextStep == 3)
                                    {
                                        PlcIoOutputFlat[PublicValue.OUTSAFT_STOP_M6] = true;
                                        DataInit();
                                    }
                                }
                                break;
                        }
                    }
                    break;
                case PROINDEX.HV:
                    {
                        if(PublicValue.configData.DeviceMES == "ON")//检查机自身的追溯方式
                        {
                            DoLogicForHV_LV_BDSB();
                        }
                        else//PMRZ追溯方案
                        {
                            //实时检测复位
                            //TotalJudgeMsg = "";
                            //DataInit();
                            //DisplayClear();
                            //ERRSound.Stop();
                            //实时检测异常报警
                            if (CheckPlcIoEdge(PublicValue.Err1CheckHV, CheckEdgeMode.Up))
                            {
                                TotalJudgeMsg = "设备异常";
                                ItemsStep = -1;
                            }
                            switch (ItemsStep)
                            {
                                case 0://前工程MES确认
                                    {
                                        switch (DeviceStep)
                                        {
                                            case 0: //读取产品进入设备的传感器，新的开始，清空画面
                                                {
                                                    //if (Environment.TickCount - EndTimeCount < 10000 && EndTimeCount != 0)//一台结束后至少10秒才能进行下一台
                                                    //    break;
                                                    if (CheckPlcIoEdge(PublicValue.StartCheckHV, CheckEdgeMode.Up))
                                                    {
                                                        ShowMsg("产品进入");
                                                        if (labJudge.Text != "")//判断是否次新的作业
                                                        {
                                                            //自动复位
                                                            TotalJudgeMsg = "";
                                                            DataInit();
                                                            ERRSound.Stop();
                                                            //清空画面
                                                            DisplayClear();
                                                            ProjSwitchInit();
                                                            DeviceStep++;
                                                        }
                                                    }
                                                }
                                                break;
                                            case 1://检测是否扫码完成//读取QR内容
                                                {
                                                    ShowMsg("开始读码");

                                                    //Thread.Sleep(5000);//PLC QR内容延迟更新，需要延时
                                                    PublicValue.Delay(5000);
                                                    string qr = GetPlcQR(PublicValue.QRAddrHV);
                                                    if (qr != null)
                                                    {
                                                        CurrPanaQR = qr;
                                                        txtPana.Text = CurrPanaQR;
                                                        CsvSaveInit(CurrPanaQR);
                                                        WorkStartTimeCount = Environment.TickCount;
                                                        UdpSend(UDPMODE.Start, CurrPanaQR);
                                                        DeviceStep++;
                                                        ShowMsg("检测中");
                                                    }
                                                    else
                                                    {
                                                        ShowMsg("QR获取失败！");
                                                        TotalJudgeMsg = "QR获取失败";
                                                        ItemsStep = -1;
                                                    }
                                                    //}
                                                }
                                                break;
                                            case 2://接受前工程MES确认
                                                {
                                                    string rel = MesAppUdpRec(UDPMODE.Start);//MES前工程确认
                                                    if (rel != "")
                                                    {
                                                        string codeErr = GetUdpErrCode(rel);
                                                        if (codeErr == "00")
                                                        {
                                                            UpdateGridItemJudge(ItemsStep, "E" + codeErr, "OK");
                                                            progWork.Value++;
                                                            ItemsStep++;
                                                        }
                                                        else
                                                        {
                                                            UpdateGridItemJudge(ItemsStep, "E" + codeErr, "NG");
                                                            TotalJudgeMsg = codeErr;
                                                            ItemsStep = -1;
                                                        }
                                                    }
                                                }
                                                break;
                                        }
                                    }
                                    break;
                                case 1://HV检查
                                    {
                                        //读取总判定结果
                                        if (CheckPlcIoEdge(PublicValue.IsOKCheckHV, CheckEdgeMode.Up))
                                        {
                                            //TotalJudgeMsg = "OK";
                                            UpdateGridItemJudge(ItemsStep, "", "OK");
                                            UdpSend(UDPMODE.End, CurrPanaQR);
                                            progWork.Value++;
                                            ItemsStep++;
                                        }
                                        if (CheckPlcIoEdge(PublicValue.IsNGCheckHV, CheckEdgeMode.Up))
                                        {
                                            TotalJudgeMsg = "NG";
                                            UpdateGridItemJudge(ItemsStep, "", "NG");
                                            ItemsStep = -1;
                                        }
                                    }
                                    break;
                                case 2://本工程确认
                                    {
                                        int nextStep = MainMesSelfRecord();
                                        if (nextStep == 3)
                                        {
                                            DataInit();
                                            ProjSwitch(PROINDEX.LV);
                                        }
                                    }
                                    break;
                            }
                        }
                    }
                    break;
                case PROINDEX.LV:
                    {
                        if(PublicValue.configData.DeviceMES == "ON")//检查机自身的追溯方式
                        {
                            DoLogicForHV_LV_BDSB();
                        }
                        else
                        {
                            //实时检测复位
                            //TotalJudgeMsg = "";
                            //DataInit();
                            //DisplayClear();
                            //ERRSound.Stop();
                            //实时检测异常报警
                            if (CheckPlcIoEdge(PublicValue.Err1CheckLV, CheckEdgeMode.Up))
                            {
                                TotalJudgeMsg = "设备异常";
                                ItemsStep = -1;
                                ProjSwitch(PROINDEX.HV);
                            }
                            switch (ItemsStep)
                            {
                                case 0://前工程MES确认
                                    {
                                        switch (DeviceStep)
                                        {
                                            case 0: //读取产品进入设备的传感器，新的开始，清空画面
                                                {
                                                    //if (Environment.TickCount - EndTimeCount < 10000 && EndTimeCount != 0)//一台结束后至少10秒才能进行下一台
                                                    //    break;
                                                    if (CheckPlcIoEdge(PublicValue.StartCheckLV, CheckEdgeMode.Up))
                                                    {
                                                        ShowMsg("产品进入");
                                                        if (labJudge.Text != "")//判断是否次新的作业
                                                        {
                                                            //自动复位
                                                            TotalJudgeMsg = "";
                                                            DataInit();
                                                            ERRSound.Stop();
                                                            //清空画面
                                                            DisplayClear();
                                                            ProjSwitchInit();
                                                            DeviceStep++;
                                                        }
                                                    }
                                                }
                                                break;
                                            case 1://检测是否扫码完成//读取QR内容
                                                {
                                                    //if(CheckPlcIoEdge(PublicValue.StartRdQrFlatHV, CheckEdgeMode.Up))
                                                    //{
                                                    ShowMsg("开始读码");

                                                    //Thread.Sleep(5000);//PLC QR内容延迟更新，需要延时
                                                    PublicValue.Delay(5000);
                                                    string qr = GetPlcQR(PublicValue.QRAddrLV);
                                                    if (qr != null)
                                                    {
                                                        CurrPanaQR = qr;
                                                        txtPana.Text = CurrPanaQR;
                                                        CsvSaveInit(CurrPanaQR);
                                                        WorkStartTimeCount = Environment.TickCount;
                                                        UdpSend(UDPMODE.Start, CurrPanaQR);
                                                        DeviceStep++;
                                                        ShowMsg("检测中");
                                                    }
                                                    else
                                                    {
                                                        ShowMsg("QR获取失败！");
                                                        TotalJudgeMsg = "QR获取失败";
                                                        ItemsStep = -1;
                                                        ProjSwitch(PROINDEX.HV);

                                                    }
                                                    //}
                                                }
                                                break;
                                            case 2://接受前工程MES确认
                                                {
                                                    string rel = MesAppUdpRec(UDPMODE.Start);//MES前工程确认
                                                    if (rel != "")
                                                    {
                                                        string codeErr = GetUdpErrCode(rel);
                                                        if (codeErr == "00")
                                                        {
                                                            UpdateGridItemJudge(ItemsStep, "E" + codeErr, "OK");
                                                            progWork.Value++;
                                                            ItemsStep++;
                                                        }
                                                        else
                                                        {
                                                            UpdateGridItemJudge(ItemsStep, "E" + codeErr, "NG");
                                                            TotalJudgeMsg = codeErr;
                                                            ItemsStep = -1;
                                                            ProjSwitch(PROINDEX.HV);

                                                        }
                                                    }
                                                }
                                                break;
                                        }
                                    }
                                    break;
                                case 1://LV检查
                                    {
                                        //读取总判定结果
                                        if (CheckPlcIoEdge(PublicValue.IsOKCheckLV, CheckEdgeMode.Up))
                                        {
                                            //TotalJudgeMsg = "OK";
                                            UpdateGridItemJudge(ItemsStep, "", "OK");
                                            UdpSend(UDPMODE.End, CurrPanaQR);
                                            progWork.Value++;
                                            ItemsStep++;
                                        }
                                        if (CheckPlcIoEdge(PublicValue.IsNGCheckLV, CheckEdgeMode.Up))
                                        {
                                            TotalJudgeMsg = "NG";
                                            UpdateGridItemJudge(ItemsStep, "", "NG");
                                            ItemsStep = -1;
                                            ProjSwitch(PROINDEX.HV);

                                        }
                                    }
                                    break;
                                case 2://本工程确认
                                    {
                                        int nextStep = MainMesSelfRecord();
                                        if (nextStep == 3)
                                        {
                                            DataInit();
                                            //EndTimeCount = Environment.TickCount;
                                            ProjSwitch(PROINDEX.BDSB);
                                        }
                                    }
                                    break;
                            }
                        }

                    }
                    break;
                case PROINDEX.BDSB:
                    {
                        if (PublicValue.configData.DeviceMES == "ON")//检查机自身的追溯方式
                        {
                            DoLogicForHV_LV_BDSB();
                        }
                        else
                        {
                            //实时检测复位
                            //TotalJudgeMsg = "";
                            //DataInit();
                            //DisplayClear();
                            //ERRSound.Stop();
                            //实时检测异常报警
                            if (CheckPlcIoEdge(PublicValue.Err1CheckBDSB, CheckEdgeMode.Up))
                            {
                                TotalJudgeMsg = "设备异常";
                                ItemsStep = -1;
                                ProjSwitch(PROINDEX.HV);

                            }
                            switch (ItemsStep)
                            {
                                case 0://前工程MES确认
                                    {
                                        switch (DeviceStep)
                                        {
                                            case 0: //读取产品进入设备的传感器，新的开始，清空画面
                                                {
                                                    //if (Environment.TickCount - EndTimeCount < 10000 && EndTimeCount != 0)//一台结束后至少10秒才能进行下一台
                                                    //    break;
                                                    if (CheckPlcIoEdge(PublicValue.StartCheckBDSB, CheckEdgeMode.Up))
                                                    {
                                                        ShowMsg("产品进入");
                                                        if (labJudge.Text != "")//判断是否次新的作业
                                                        {
                                                            //自动复位
                                                            TotalJudgeMsg = "";
                                                            DataInit();
                                                            ERRSound.Stop();
                                                            //清空画面
                                                            DisplayClear();
                                                            ProjSwitchInit();
                                                            DeviceStep++;
                                                        }
                                                    }
                                                }
                                                break;
                                            case 1://检测是否扫码完成//读取QR内容
                                                {
                                                    //if(CheckPlcIoEdge(PublicValue.StartRdQrFlatHV, CheckEdgeMode.Up))
                                                    //{
                                                    ShowMsg("开始读码");

                                                    //Thread.Sleep(5000);//PLC QR内容延迟更新，需要延时
                                                    PublicValue.Delay(5000);
                                                    string qr = GetPlcQR(PublicValue.QRAddrBDSB);
                                                    if (qr != null)
                                                    {
                                                        CurrPanaQR = qr;
                                                        txtPana.Text = CurrPanaQR;
                                                        CsvSaveInit(CurrPanaQR);
                                                        WorkStartTimeCount = Environment.TickCount;
                                                        UdpSend(UDPMODE.Start, CurrPanaQR);
                                                        DeviceStep++;
                                                        ShowMsg("检测中");
                                                    }
                                                    else
                                                    {
                                                        ShowMsg("QR获取失败！");
                                                        TotalJudgeMsg = "QR获取失败";
                                                        ItemsStep = -1;
                                                        ProjSwitch(PROINDEX.HV);

                                                    }
                                                    //}
                                                }
                                                break;
                                            case 2://接受前工程MES确认
                                                {
                                                    string rel = MesAppUdpRec(UDPMODE.Start);//MES前工程确认
                                                    if (rel != "")
                                                    {
                                                        string codeErr = GetUdpErrCode(rel);
                                                        if (codeErr == "00")
                                                        {
                                                            UpdateGridItemJudge(ItemsStep, "E" + codeErr, "OK");
                                                            progWork.Value++;
                                                            ItemsStep++;
                                                        }
                                                        else
                                                        {
                                                            UpdateGridItemJudge(ItemsStep, "E" + codeErr, "NG");
                                                            TotalJudgeMsg = codeErr;
                                                            ItemsStep = -1;
                                                            ProjSwitch(PROINDEX.HV);

                                                        }
                                                    }
                                                }
                                                break;
                                        }
                                    }
                                    break;
                                case 1://BDSB检查
                                    {
                                        //读取总判定结果
                                        if (CheckPlcIoEdge(PublicValue.IsOKCheckBDSB, CheckEdgeMode.Up))
                                        {
                                            //TotalJudgeMsg = "OK";
                                            UpdateGridItemJudge(ItemsStep, "", "OK");
                                            UdpSend(UDPMODE.End, CurrPanaQR);
                                            progWork.Value++;
                                            ItemsStep++;
                                        }
                                        if (CheckPlcIoEdge(PublicValue.IsNGCheckBDSB, CheckEdgeMode.Up))
                                        {
                                            TotalJudgeMsg = "NG";
                                            UpdateGridItemJudge(ItemsStep, "", "NG");
                                            ItemsStep = -1;
                                            ProjSwitch(PROINDEX.HV);

                                        }
                                    }
                                    break;
                                case 2://本工程确认
                                    {
                                        int nextStep = MainMesSelfRecord();
                                        if (nextStep == 3)
                                        {
                                            DataInit();
                                            ProjSwitch(PROINDEX.HV);
                                        }
                                    }
                                    break;
                            }
                        }
                    }
                    break;

            }
            //进入下一步骤清空扫描仪缓存
            if (ItemsStep != LastItemsStep)
            {
                LastItemsStep = ItemsStep;
                QRBuffClear();
                PressQR = "";
                handyData1.flat = false;
                handyData2.flat = false;
            }
            ResultJudgeDeal();
        }
        private void DoLogicForHV_LV_BDSB()
        {
            string judgePLC = "";
            
            if (UdpServerHLB.IsRecData)//监控PLC数据
            {
                string recData = Encoding.UTF8.GetString(UdpServerHLB.RecData(),0, UdpServerHLB.RecDataLen);
                if (recData.Substring(recData.Length - 2) != "\r\n")
                {
                    ShowMsg("异常:接收到PLC数据不完整！");
                    return;
                }
                string[] arrData = recData.Split(',');
                plcData = new PLCUdpData()
                {
                    Mode = arrData[0],
                    ProjCode = arrData[1],
                    DeviceID = arrData[2],
                    Program = arrData[3],
                    ToolCode = arrData[4],//治具番号5位
                    LotCode = arrData[5],//批次号11位
                    SerNo = arrData[6],//序列号7位
                    RefCode = arrData[7],//制品番号12位
                    UserCode = arrData[8],//作业者番号7位
                    Judge = arrData[9],//判定2位
                    Remark = arrData[10].Substring(0, 10),//备用预留10位
                    EndCode = arrData[10].Substring(10)//结束符2位
                };
                CurrPanaQR = arrData[7] + arrData[5] + arrData[6];
                if (arrData[0] == "1")//确认通信
                {
                    //初始化一些数据
                    TotalJudgeMsg = "";
                    DataInit();
                    DisplayClear();
                    ERRSound.Stop();
                    //获取接收到数据的IP端口
                    string repIP = UdpServerHLB.TargetPoint.ToString().Split(':')[0];
                    if (repIP == PublicValue.configData.HVPLCIP)
                        PublicValue.configData.Proj = (int)PROINDEX.HV;
                    else if (repIP == PublicValue.configData.LVPLCIP)
                        PublicValue.configData.Proj = (int)PROINDEX.LV;
                    else if (repIP == PublicValue.configData.BDSBPLCIP)
                        PublicValue.configData.Proj = (int)PROINDEX.BDSB;

                    ProjSwitchInit();
                    txtPana.Text = CurrPanaQR;
                    comOperator.Text = plcData.UserCode;
                    labDeviceNo.Text = plcData.DeviceID;
                    //初始履历
                    //CsvSaveInit(CurrPanaQR);
                    FileSave.Program = plcData.Program.Trim();
                    FileSave.RefNo = plcData.RefCode.Trim();
                    FileSave.LotNo = plcData.LotCode.Trim();
                    FileSave.SerNo = plcData.SerNo.Trim();
                    FileSave.DeviceNo = plcData.DeviceID.Trim();

                    WorkStartTimeCount = Environment.TickCount;
                    UdpSend(plcData);
                    ItemsStep = 0;
                }
                else if (arrData[0] == "2")//登录通信
                {
                    judgePLC = plcData.Judge;//PLC判定
                    //判断是不是MASTER，如果是则直接对judgePLC = "OK"
                    if (IsMater(CurrPanaQR))
                        judgePLC = "OK";
                    ItemsStep = 1;
                }
            }
            switch (ItemsStep)
            {
                case 0://前工程MES确认
                    {
                        string rel = MesAppUdpRec(UDPMODE.Start);//MES前工程确认
                        if (rel != "")
                        {
                            string codeErr = GetUdpErrCode(rel);
                            ShowMsg(rel);

                            bool isRepeat = false;
                            if (PublicValue.configData.REPEAT == "ON")
                                if (codeErr == "22")
                                    isRepeat = true;
                            //判断是不是MASTER，如果是则直接对codeErr = "00"
                            if (IsMater(CurrPanaQR))
                            {
                                ShowMsg("Master");
                                codeErr = "00";

                            }

                            MESRepPLC(UDPMODE.Start, isRepeat? "00": codeErr);
                            
                            if (codeErr == "00" || isRepeat)
                            {
                                UpdateGridItemJudge(ItemsStep, "E" + codeErr, "OK");
                                progWork.Value++;
                                ItemsStep++;
                            }
                            else
                            {
                                UpdateGridItemJudge(ItemsStep, "E" + codeErr, "NG");
                                TotalJudgeMsg = codeErr;
                                ItemsStep = -1;
                            }
                        }
                    }
                    break;
                case 1://HV检查
                    {
                        if (judgePLC == "OK")
                        {
                            UpdateGridItemJudge(ItemsStep, "", "OK");
                            progWork.Value++;
                            ItemsStep++;
                        }
                        else if (judgePLC == "NG")
                        {
                            MESRepPLC(UDPMODE.End, "00");//NG也要回复才能排出
                            TotalJudgeMsg = "NG";
                            UpdateGridItemJudge(ItemsStep, "", "NG");
                            ItemsStep = -1;
                        }
                    }
                    break;
                case 2://本工程确认
                    {
                        int nextStep = MainMesSelfRecord();
                        if (nextStep == 3)
                        {
                            DataInit();
                        }
                    }
                    break;
            }
        }
        private void DataInit()
        {
            WorkStartTimeCount = 0;
            ScrewPackCount1 = 0;
            ScrewPackCount2 = 0;
            ItemsStep = 0;
            DeviceStep = 0;
            HandyOKCount1 = 0;
            HandyOKCount2 = 0;
            handyData1.flat = false;
            handyData2.flat = false;
            ServerAPPMsg = "";
            PressQR = "";

        }
        private void ResetInputFlat()
        {
            for(int i = 0;i<16;i++)
            {
                PlcIoInputFlat[i] = false;
            }
        }
        /// <summary>
        /// 获取MES的结果内容
        /// </summary>
        /// <param name="code">结果码</param>
        /// <returns></returns>
        public string GetErrorMsg(string code)
        {
            string strMsg = code;
            switch (code)
            {
                case "00": strMsg = "通过工序正常"; break;
                case "20": strMsg = "此部品未在生产下达计划内"; break;
                case "21": strMsg = "前工程NG"; break;
                case "22": strMsg = "此工序已完成过"; break;
                case "40": strMsg = "工程编号未在服务器上注册"; break;
                case "41": strMsg = "设备编号未在服务器上注册"; break;
                case "42": strMsg = "程序名称未在服务器上注册"; break;
                case "43": strMsg = "治具番号未在服务器上注册"; break;
                case "44": strMsg = "作业者番号未在服务器上注册"; break;
                case "45": strMsg = "产品部件号未在服务器上注册"; break;
                case "46": strMsg = "要使用的材料未在服务器上注册"; break;
                case "47": strMsg = "生产指示番号未在服务器登录"; break;
                case "48": strMsg = "此组立缺少材料登录"; break;
                case "49": strMsg = "使用材料已产出"; break;
                case "50": strMsg = "预组立未产出"; break;
                case "51": strMsg = "预组立材料不足"; break;
                case "52": strMsg = "预组立QR数超出"; break;

                case "80": strMsg = "数据格式不正确"; break;
                case "81": strMsg = "标头不正确"; break;
                case "A0": strMsg = "服务器数据库停止"; break;
                case "A1": strMsg = "数据库登录失败"; break;
            }
            return strMsg;
        }
        public string GetUdpErrCode(string data)
        {
            string err = null;
            if (data.Length == 14)
            {
                if (data.Substring(12, 2) == "\r\n")
                {
                    err = data.Substring(1, 2);
                }
            }
            return err;
        }
        private void ResultJudgeDeal()
        {

            if (TotalJudgeMsg == "")
                return;
            if(TotalJudgeMsg == "OK")
            {
                labJudge.Text = "OK";
                panJudge.BackColor = Color.LimeGreen;

            }
            else if(TotalJudgeMsg == "NG")
            {
                labJudge.Text = "NG";
                panJudge.BackColor = Color.Red;
                ERRSound.PlayLooping();
                if(Linetype == LINETYPE.Pre)//预组立中NG时要发送给MES  
                    UdpSend(UDPMODE.End,"", txtPana.Text, "", MES_RESULT.NG);
            }
            else
            {
                string errMeg = GetErrorMsg(TotalJudgeMsg);//检索是不是MES的报警;
                if (errMeg != TotalJudgeMsg)//MES的异常
                {
                    labCheck.Text = errMeg;
                    TotalJudgeMsg = "NG";
                    labJudge.Text = "NG";
                    panJudge.BackColor = Color.Red;
                }
                else//设备异常
                {
                    labCheck.Text = TotalJudgeMsg;
                    labJudge.Text = "ERR";
                    panJudge.BackColor = Color.Red;
                }
                panCheck.BackColor = Color.Red;
                ERRSound.PlayLooping();

            }
            if(TotalJudgeMsg != "OK")
            {
                //if (PublicValue.configData.Handy1 == "ON")
                //{
                //    HandyJobSelected(1, 1);//坐标1
                //}
                //if (PublicValue.configData.Handy2 == "ON")
                //{
                //    HandyJobSelected(2, 1);//坐标1
                //}
            }
            //履历保存
            FileSave.DataAddToBuff("作业时长", labTime.Text.Substring(0, labTime.Text.Length - 1), "s", "", "", "", "");
            FileSave.DataAddToBuff("作业者名", comOperator.Text, "", "", "", "", "");
            FileSave.DataAddToBuff("总判定", "", "", "", "", (TotalJudgeMsg == "OK" || TotalJudgeMsg == "NG") ? TotalJudgeMsg : "ERR",
                                                             (TotalJudgeMsg == "OK" || TotalJudgeMsg == "NG") ? "" : TotalJudgeMsg);
            if(CurrPanaQR != "")
            {
                string csvName = FileData.GetCsvName(Linetype, CurrPanaQR);
                FileSave.DataSaveCSV(csvName);
            }
            else
            {
                FileSave.BufferClear();
                ShowMsg("CSV保存失败！");
            }
            TotalJudgeMsg = "";
            WorkStartTimeCount = 0;
            
        }
        /// <summary>
        /// 串口初始化
        /// </summary>
        /// <returns></returns>
        public bool PortInit(SerialPort serialPort)
        {
            try
            {
                string serNo;
                if (serialPort == serialHandy1)
                    serNo = "1";
                else
                    serNo = "2";
                serialPort.PortName = INI.Read("Section Content", "HandyPort"+ serNo, "", PublicValue.ConfigPath);
                serialPort.BaudRate = Convert.ToInt32(INI.Read("Section Content", "HandyBaud"+ serNo, "", PublicValue.ConfigPath).ToString().Trim());
                serialPort.Parity = System.IO.Ports.Parity.None;
                serialPort.DataBits = 8;
                serialPort.StopBits = System.IO.Ports.StopBits.One;
                serialPort.ReceivedBytesThreshold = 1;
                serialPort.Open();
            }
            catch
            {
                return false;

            }
            return true;
        }
        private void DisplayClear()
        {
            progWork.Value = 0;
            labTime.Text = "0s";
            if(Linetype == LINETYPE.Main)
                txtPana.Text = "";
            txtPana.BackColor = Color.White;
            labCheck.Text = "正常";
            panCheck.BackColor = Color.LimeGreen;
            //txtQRScan.Text = "";
            txtQRScan.SelectAll();
            dataGridViewData.Rows.Clear();
            for (int i = 0; i < dataGridViewItems.Rows.Count; i++)
            {
                dataGridViewItems.Rows[i].Cells[2].Value = "";
                dataGridViewItems.Rows[i].Cells[3].Value = "";
                dataGridViewItems.Rows[i].Cells[3].Style.BackColor = Color.White;

            }
            labJudge.Text = "----";
            panJudge.BackColor = Color.White;

            handyData1.flat = false;//电批数据点检残留清除
            handyData2.flat = false;
        }
        private void FrmMain_Load(object sender, EventArgs e)
        {
            DataGridUiInit();
            ItemsGridUiInit();
            DisplayClear();
            BaseInit();
            txtQRScan.Focus();
        }
        private void UdpSend(PLCUdpData udpData)
        {
            MesSendData dataMes = new MesSendData()
            {
                Mode = udpData.Mode,
                ProjCode = udpData.ProjCode,
                DeviceID = udpData.DeviceID,
                Program = udpData.Program,
                ToolCode = udpData.ToolCode,
                LotCode = udpData.LotCode,
                SerNo = udpData.SerNo,
                RefCode = udpData.RefCode,
                UserCode = udpData.UserCode,
                Judge = udpData.Judge
            };
            string strSend = dataMes.SendMsg();
            byte[] arrSendServer = Encoding.Default.GetBytes(strSend);
            udpClient.SendTo(arrSendServer, targetPoint);
            UdpLog.LogSave(LogType.SD, strSend);
        }
        private void UdpSend(UDPMODE md, string panaQR, MES_RESULT rel = MES_RESULT.OK)
        {
            MesSendData dataMes = new MesSendData()
            {
                Mode = md == UDPMODE.Start ? "1" : "2",
                ProjCode = ProjectCode,
                DeviceID = PublicValue.configData.DeviceNo,
                Program = panaQR.Substring(0, 12),
                ToolCode = "",
                LotCode = panaQR.Substring(12, 11),
                SerNo = panaQR.Substring(23),
                RefCode = panaQR.Substring(0, 12),
                UserCode = comOperator.Text,
                Judge = rel == MES_RESULT.OK ? "OK" : "NG"
            };
            string strSend = dataMes.SendMsg();
            byte[] arrSendServer = Encoding.Default.GetBytes(strSend);
            udpClient.SendTo(arrSendServer, targetPoint);
            UdpLog.LogSave(LogType.SD, strSend);
        }
        private void UdpSend(UDPMODE md, string panaQR, string productQR,string materialQR, MES_RESULT rel)
        {
            MesSendData dataMes = new MesSendData()
            {
                Mode = md == UDPMODE.Start ? "1" : "2",
                ProjCode = ProjectCode,
                DeviceID = PublicValue.configData.DeviceNo,
                Program = panaQR == "" ? panaQR : panaQR.Substring(0, 12),
                ToolCode = "",
                LotCode = panaQR == ""? panaQR:panaQR.Substring(12, 11),
                SerNo = panaQR == "" ? panaQR : panaQR.Substring(23),
                RefCode = panaQR == "" ? panaQR : panaQR.Substring(0, 12),
                ProductCode = productQR,
                MaterialCode = materialQR,
                UserCode = comOperator.Text,
                Judge = rel == MES_RESULT.OK?"OK":"NG"
            };
            string strSend = dataMes.SendMsg();
            byte[] arrSendServer = Encoding.Default.GetBytes(strSend);
            udpClient.SendTo(arrSendServer, targetPoint);
            UdpLog.LogSave(LogType.SD, strSend);
        }
        private string MesAppUdpRec(UDPMODE md)
        {
            string rel = "";
            if (ServerAPPMsg != "")
            {
                rel = ServerAPPMsg;
                IsUdpFinish = true;               
                //UdpLog.LogSave(LogType.REC, rel);
                ServerAPPMsg = "";
            }
            return rel;
        }

        /// <summary>
        /// 接收APP Server的信息
        /// </summary>
        private void RecServerAPPMsg()
        {
            while (true)
            {
                try
                {
                    EndPoint sendPoint = new IPEndPoint(IPAddress.Any, 0);//IPAddress.Any,0
                    byte[] buffer = new byte[1024];
                    int length = udpClient.ReceiveFrom(buffer, ref sendPoint);
                    //UdpSendTimeCount = 0;
                    string strMsgRec = System.Text.Encoding.UTF8.GetString(buffer, 0, length);
                    //Deal_APP_Msg(strMsgRec);
                    ServerAPPMsg = strMsgRec;
                    UdpLog.LogSave(LogType.REC, ServerAPPMsg);
                }
                catch (Exception e)
                {
                    //throw e;
                }
            }
        }
        /// <summary>
        /// UDP服务连接开启
        /// </summary>
        /// <param name="local_ip">本机IP</param>
        /// <param name="local_port">本机端口</param>
        /// <param name="target_ip">目标IP</param>
        /// <param name="target_port">目标端口</param>
        /// <returns></returns>
        public bool UPDConnectServer(string local_ip, string local_port, string target_ip, string target_port)
        {
            IPEndPoint endPoint = new IPEndPoint(IPAddress.Parse(local_ip), int.Parse(local_port));//本地IP端口
            udpClient = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            targetPoint = new IPEndPoint(IPAddress.Parse(target_ip), int.Parse(target_port));//本地IP端口
            try
            {
                udpClient.Bind(endPoint);
            }
            catch (SocketException se)
            {
                return false;
            }
            threadClientAPP = new Thread(RecServerAPPMsg);
            threadClientAPP.IsBackground = true;
            threadClientAPP.Start();
            return true;
        }
        private bool DeviceInit()
        {
            bool relCon = true;
            string pcIp = GetLocalIP(IP_TYPE.DEVICE);
            string mesIp = GetLocalIP(IP_TYPE.MES);//不插网线是null然后程序错误
            if (pcIp == null || mesIp == null)
            {
                ShowMsg("IP获取失败，请确认网络连接！");
                return false;
            }
            //UDP监控MES Server
            UPDConnectServer(mesIp, PublicValue.configData.ServerPort, PublicValue.configData.ServerIP, PublicValue.configData.ServerPort);
            //PLC
            if ((PROINDEX)PublicValue.configData.Proj == PROINDEX.HV ||
                (PROINDEX)PublicValue.configData.Proj == PROINDEX.LV ||
                (PROINDEX)PublicValue.configData.Proj == PROINDEX.BDSB)
            {
                if(PublicValue.configData.DeviceMES == "ON")//检查机自身的追溯方式
                {
                    UdpServerHLB = new OmronFinsUdp(pcIp, int.Parse(PublicValue.configData.HVPLCPort));
                    bool rel = UdpServerHLB.StartBind();
                    if (rel)
                    {
                        ShowMsg("检查机监控启动完成");
                    }
                }
                else
                {
                    PLCcontrolHV = new OmronFINS(pcIp, PublicValue.configData.HVPLCIP, int.Parse(PublicValue.configData.HVPLCPort));
                    bool rel = PLCcontrolHV.StartConnect();
                    if (rel)
                    {
                        ShowMsg("HV连接成功");
                    }
                    PLCcontrolLV = new OmronFINS(pcIp, PublicValue.configData.LVPLCIP, int.Parse(PublicValue.configData.LVPLCPort));
                    rel = PLCcontrolLV.StartConnect();
                    if (rel)
                    {
                        ShowMsg("LV连接成功");
                    }
                    PLCcontrolBDSB = new OmronFINS(pcIp, PublicValue.configData.BDSBPLCIP, int.Parse(PublicValue.configData.BDSBPLCPort));
                    rel = PLCcontrolBDSB.StartConnect();
                    if (rel)
                    {
                        ShowMsg("BDSB连接成功");
                    }
                    if ((PROINDEX)PublicValue.configData.Proj == PROINDEX.HV)
                        PLCcontrol = PLCcontrolHV;
                    else if ((PROINDEX)PublicValue.configData.Proj == PROINDEX.LV)
                        PLCcontrol = PLCcontrolLV;
                    else if ((PROINDEX)PublicValue.configData.Proj == PROINDEX.BDSB)
                        PLCcontrol = PLCcontrolBDSB;
                }

            }
            else
            {
                PLCcontrol = new OmronFINS(pcIp, PublicValue.configData.PLCIP, int.Parse(PublicValue.configData.PLCPort));
                bool rel = PLCcontrol.StartConnect();
                if (!rel)
                {
                    relCon = false;
                    ShowMsg("PLC连接失败");

                }
            }

            //电批
            if (PublicValue.configData.Handy1 == "ON")
            {
                bool rel = PortInit(serialHandy1);
                if (!rel)
                {
                    relCon = false;
                    ShowMsg("电批端口1打开失败");


                }
            }
            if (PublicValue.configData.Handy2 == "ON")
            {
                bool rel = PortInit(serialHandy2);
                if (!rel)
                {
                    relCon = false;
                    ShowMsg("电批端口2打开失败");

                }
            }
            //CCD
            if (PublicValue.configData.CCDUSE == "ON")
            {
                if (PublicValue.configData.CCD1 == "ON")
                {
                    IV2control1 = new IV2Navigator(pcIp, PublicValue.configData.CCDIP1, int.Parse(PublicValue.configData.CCDPort1));
                    bool rel = IV2control1.StartConnect();
                    if (!rel)
                    {
                        relCon = false;
                        ShowMsg("CCD1连接失败！");
                    }
                }
                if (PublicValue.configData.CCD2 == "ON")
                {
                    IV2control2 = new IV2Navigator(pcIp, PublicValue.configData.CCDIP2, int.Parse(PublicValue.configData.CCDPort2));
                    bool rel = IV2control2.StartConnect();
                    if (!rel)
                    {
                        ShowMsg("CCD2连接失败！");
                        relCon = false;


                    }
                }
                if (PublicValue.configData.CCD3 == "ON")
                {
                    IV2control3 = new IV2Navigator(pcIp, PublicValue.configData.CCDIP3, int.Parse(PublicValue.configData.CCDPort3));
                    bool rel = IV2control3.StartConnect();
                    if (!rel)
                    {
                        ShowMsg("CCD3连接失败！");
                        relCon = false;

                    }
                }
                if (PublicValue.configData.CCD4 == "ON")
                {
                    IV2control4 = new IV2Navigator(pcIp, PublicValue.configData.CCDIP4, int.Parse(PublicValue.configData.CCDPort4));
                    bool rel = IV2control4.StartConnect();
                    if (!rel)
                    {
                        ShowMsg("CCD4连接失败！");
                        relCon = false;

                    }
                }
            }
            if (PublicValue.configData.WatchImg == "ON")
            {
                WatchImageInit();
                ShowMsg("启动图片监控");
            }
            return relCon;

        }
        private void AddGridItemJudge(string itemName,string result,string judge)
        {
            dataGridViewItems.Rows.Add(new string[] { (dataGridViewItems.Rows.Count+1).ToString(), itemName, result,judge });
            
        }
        private void UpdateGridItemJudge(int itemNo, string result, string judge)
        {
            if(result != "")
                dataGridViewItems.Rows[itemNo].Cells[2].Value = result;
            if(judge != "")
                dataGridViewItems.Rows[itemNo].Cells[3].Value = judge;
            if (judge == "OK")
                dataGridViewItems.Rows[itemNo].Cells[3].Style.BackColor = Color.LimeGreen;
            else if (judge == "NG")
                dataGridViewItems.Rows[itemNo].Cells[3].Style.BackColor = Color.Red;
            else if (judge == "--")
                dataGridViewItems.Rows[itemNo].Cells[3].Style.BackColor = Color.Yellow;

            dataGridViewItems.FirstDisplayedScrollingRowIndex = itemNo - 3 > 0 ? itemNo - 3 : 0;
            //填充CSV缓冲区
            if (judge == "OK" || judge == "NG")
                FileSave.DataAddToBuff(PublicValue.ItemList[PublicValue.configData.Proj, itemNo], result, "", "", "", judge, "");

        }
        private void AddGridHandyData(HandyData handyData)
        {
            dataGridViewData.Rows.Add(new string[] { (dataGridViewData.Rows.Count+1).ToString(), handyData.f_trq,
                        handyData.rundown_time, handyData.pos_x, handyData.pos_y, handyData.pos_z, handyData.judge=="O"?"OK":"NG" });
            if (handyData.judge == "O")           
                dataGridViewData.Rows[dataGridViewData.Rows.Count - 1].Cells[6].Style.BackColor = Color.LimeGreen;
            else
                dataGridViewData.Rows[dataGridViewData.Rows.Count - 1].Cells[6].Style.BackColor = Color.Red;
            dataGridViewData.FirstDisplayedScrollingRowIndex = dataGridViewData.Rows.Count - 1;
            //填充CSV缓冲区
            FileSave.DataAddToBuff("螺钉-"+ dataGridViewData.Rows.Count.ToString()+" 扭矩值", 
                                    handyData.f_trq, "N·m", handyData.low_f_trq, 
                                    handyData.hig_f_trq,handyData.judge == "O" ? "OK" : "NG", "");
            FileSave.DataAddToBuff("螺钉-" + dataGridViewData.Rows.Count.ToString()+" RUNDOWN角度值",
                                    handyData.rundown_time, "dge", "","", "", "");
            FileSave.DataAddToBuff("螺钉-" + dataGridViewData.Rows.Count.ToString() + " FINAL角度值",
                                    handyData.f_ang, "dge", "", "", "", "");
            FileSave.DataAddToBuff("螺钉-" + dataGridViewData.Rows.Count.ToString() + " 位置X",
                                    handyData.pos_x, "mm", "", "", "", "");
            FileSave.DataAddToBuff("螺钉-" + dataGridViewData.Rows.Count.ToString() + " 位置Y",
                                    handyData.pos_y, "mm", "", "", "", "");
            FileSave.DataAddToBuff("螺钉-" + dataGridViewData.Rows.Count.ToString() + " 位置Z",
                                    handyData.pos_z, "mm", "", "", "", "");
        }
        private void serialHandy_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            PublicValue.Delay(50);
            int len = serialHandy1.BytesToRead;//获取可以读取的字节数
            byte[] buff = new byte[len];//创建缓存数据数组
            serialHandy1.Read(buff, 0, len);//把数据读取到buff数组
            if (buff.Length == 293)
            {
                if (buff[0] == 0x02 && buff[291] == 0x03)
                {
                    serialHandy1.Write(new byte[1] { 0x06 }, 0, 1);//应答成功
                    handyData1.ch = Encoding.Default.GetString(buff, 3, 2);
                    handyData1.date = Encoding.Default.GetString(buff, 13, 12);
                    handyData1.judge = Encoding.Default.GetString(buff, 25, 1);
                    handyData1.f_trq = Encoding.Default.GetString(buff, 26, 7);
                    handyData1.f_ang = Encoding.Default.GetString(buff, 33, 7);
                    handyData1.rundown_time = Encoding.Default.GetString(buff, 134, 7);
                    handyData1.low_f_trq = Encoding.Default.GetString(buff, 194, 7);
                    handyData1.hig_f_trq = Encoding.Default.GetString(buff, 201, 7);
                    handyData1.pos_x = Encoding.Default.GetString(buff, 266, 6);
                    handyData1.pos_y = Encoding.Default.GetString(buff, 272, 6);
                    handyData1.pos_z = Encoding.Default.GetString(buff, 278, 6);
                    handyData1.flat = true;
                }
            }
            //else
            //{
            //    HandyPort1.Write(new byte[1] { 0x15 }, 0, 1);//应答失败
            //}
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            toolNowTime.Text = "时间：" + DateTime.Now;
            if (WorkStartTimeCount != 0)
            {
                labTime.Text = (((float)(Environment.TickCount - WorkStartTimeCount))/1000).ToString("0.0") + "s";
            }
            if(PublicValue.configData.Proj<=(int)PROINDEX.SafeLine)//检查机IO不在次检测
                PLCIOUpdate();
            PlcDoLogicThing();
            timer1.Enabled = true;
        }
        private NGBtnClick ManuDealNGshow(NGTpye tpye, string frmMsg = "")
        {
            ERRSound.PlayLooping();
            NGBtnClick btnClick;
            FrmNG frmCCD = new FrmNG();
            if(frmMsg != "")
                frmCCD.MsgShow = frmMsg;
            frmCCD.NGTpye = tpye;
            frmCCD.ShowDialog();
            ERRSound.Stop();
            btnClick = frmCCD.ClickBtn;
            frmCCD.Dispose();
            return btnClick;
        }
        private void serialHandy2_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            PublicValue.Delay(50);
            int len = serialHandy2.BytesToRead;//获取可以读取的字节数
            byte[] buff = new byte[len];//创建缓存数据数组
            serialHandy2.Read(buff, 0, len);//把数据读取到buff数组
            if (buff.Length == 293)
            {
                if (buff[0] == 0x02 && buff[291] == 0x03)
                {
                    serialHandy2.Write(new byte[1] { 0x06 }, 0, 1);//应答成功
                    handyData2.ch = Encoding.Default.GetString(buff, 3, 2);
                    handyData2.date = Encoding.Default.GetString(buff, 13, 12);
                    handyData2.judge = Encoding.Default.GetString(buff, 25, 1);
                    handyData2.f_trq = Encoding.Default.GetString(buff, 26, 7);
                    handyData2.f_ang = Encoding.Default.GetString(buff, 33, 7);
                    handyData2.rundown_time = Encoding.Default.GetString(buff, 134, 7);
                    handyData2.low_f_trq = Encoding.Default.GetString(buff, 194, 7);
                    handyData2.hig_f_trq = Encoding.Default.GetString(buff, 201, 7);
                    handyData2.pos_x = Encoding.Default.GetString(buff, 266, 6);
                    handyData2.pos_y = Encoding.Default.GetString(buff, 272, 6);
                    handyData2.pos_z = Encoding.Default.GetString(buff, 278, 6);
                    handyData2.flat = true;
                }
            }
            //else
            //{
            //    HandyPort1.Write(new byte[1] { 0x15 }, 0, 1);//应答失败
            //}
        }
        
        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult.OK == MessageBox.Show("是否要关闭程序？", "关闭提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question))
            {
                udpClient.Close();
                if(PLCcontrol != null)
                    PLCcontrol.StopConnect();
                //HandyPort1.Close();
                //INI.Write("Section Content", "ScrewTimes", configData.ScrewTimes.ToString(), PublicValue.ConfigPath);
                this.FormClosing -= new FormClosingEventHandler(this.FrmMain_FormClosing);

                Application.Exit();
                //System.Environment.Exit(0);
            }
            else
            {
                e.Cancel = true;  //取消。返回窗体
            }
        }
        private void QRBuffClear()
        {
            for (int i = 0; i < 6; i++)
            {
                QRbuff[i] = "";
            }
        }
        private void FrmMain_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void dataGridViewItems_KeyDown(object sender, KeyEventArgs e)
        {
            if (PublicValue.configData.HandyScaner == "OFF")
                return;

            if (e.KeyCode == Keys.Enter)
            {
                if (labJudge.Text == "OK")//判断是否下一次作业
                    DisplayClear();
                for (int i = 0; i < 6; i++)
                {
                    if (PressQR != "")
                        QRbuff[i] = PressQR;
                }
                ShowMsg(PressQR);
                PressQR = "";
                dataGridViewItems.Focus();
            }
            else
            {
                if (e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9)
                {
                    PressQR += e.KeyCode.ToString().Substring(1);
                }
                else if (e.KeyCode >= Keys.A && e.KeyCode <= Keys.Z)
                {
                    PressQR += e.KeyCode.ToString();
                }
                else
                {
                    if (e.KeyCode == Keys.Space)
                        PressQR += " ";
                    else if (e.KeyCode == Keys.OemMinus)
                        PressQR += "-";
                    else if (e.KeyCode == Keys.ShiftKey)
                        PressQR += "";
                    else
                    {
                        //警示存在特殊字符
                        ShowMsg("存在特殊字符！");
                        PressQR = "";
                    }
                }
            }
        }

        private void txtQRScan_KeyDown(object sender, KeyEventArgs e)
        {
            if (PublicValue.configData.HandyScaner == "OFF")
                return;

            if (e.KeyCode == Keys.Enter)
            {
                if (labJudge.Text == "OK")//判断是否下一次作业
                    DisplayClear();
                for (int i = 0; i < 6; i++)
                {
                    if (txtQRScan.Text != "")
                        QRbuff[i] = txtQRScan.Text;
                }
                ShowMsg(txtQRScan.Text);
                txtQRScan.SelectAll();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            if (txtQRScan.Text == "1test")
            {
                handyData1.judge = "O";
                handyData1.f_trq = "TEST";
                handyData1.f_ang = "TEST";
                handyData1.rundown_time = "TEST";
                handyData1.low_f_trq = "TEST";
                handyData1.hig_f_trq = "TEST";
                handyData1.pos_x = "TEST";
                handyData1.pos_y = "TEST";
                handyData1.pos_z = "TEST";
                handyData1.flat = true;
                return;
            }
            if (txtQRScan.Text == "2test")
            {
                handyData2.judge = "O";
                handyData2.f_trq = "TEST";
                handyData2.f_ang = "TEST";
                handyData2.rundown_time = "TEST";
                handyData2.low_f_trq = "TEST";
                handyData2.hig_f_trq = "TEST";
                handyData2.pos_x = "TEST";
                handyData2.pos_y = "TEST";
                handyData2.pos_z = "TEST";
                handyData2.flat = true;
                return;

            }
            if (DialogResult.OK == MessageBox.Show("是否要复位？", "复位确认", MessageBoxButtons.OKCancel, MessageBoxIcon.Question))
            {
                MainResetCheck();
                txtQRScan.Text = "";
                txtQRScan.Focus();
            }
      
        }
        private void WatchImageInit()
        {
            try
            {
                //FileSystemWatcher fileWatcher = new FileSystemWatcher();
                fileWatcher.Path = PublicValue.configData.ImgPath;
                fileWatcher.IncludeSubdirectories = true;//监控包括子目录
                fileWatcher.Filter = "*.jpeg";
                fileWatcher.EnableRaisingEvents = true;
            }
            catch
            {
                ShowMsg("图片路径监控失败！");
            }
    
        }
        private string GetNewCCDImg(string picName)
        {
            string newName = string.Empty;
            if(picName.Length == 33)//00013_001_NG_20210416_174719.jpeg
            {
                string judge = picName.Substring(10, 2);
                newName = CurrPanaQR +"_"+ DateTime.Now.ToString("yyyyMMdd_HHmmssfff")+"_"+ judge;
            }
            return newName;
        }

        private void fileWatcher_Created(object sender, FileSystemEventArgs e)
        {
            if(CurrPanaQR != "")//前工程确认后进行处理
            {
                string filePath = e.FullPath;
                string newName = GetNewCCDImg(Path.GetFileName(e.Name));
                if (newName != "")
                {
                    string fileDir = Path.GetDirectoryName(filePath);
                    string suffix = Path.GetExtension(filePath);
                    if (File.Exists(filePath))
                    {
                        File.Move(filePath, fileDir + "\\" + newName + suffix);
                        ShowMsg("图片命名成功");
                    }
                    else
                    {
                        ShowMsg("监控路径不存在");
                    }
                }
                else
                {
                    ShowMsg("图片新名称不能为空");
                }
            }

        }

        private void FrmMain_Shown(object sender, EventArgs e)
        {
            bool rel = DeviceInit(); //需要追加IP获取校验          
            if (rel)
                timer1.Enabled = true;
            else
            {
                labJudge.Text = "ERR";
                panJudge.BackColor = Color.Red;
                labCheck.Text = "ERR";
                panCheck.BackColor = Color.Red;
            }
        }

        private void comOperator_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtQRScan.Enabled == true)
                txtQRScan.Focus();
            else
                dataGridViewItems.Focus();
        }
    }
}
