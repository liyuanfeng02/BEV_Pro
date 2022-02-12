using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
//using System.Speech.Synthesis;
using System.Text;
using System.Windows.Forms;

namespace Common
{
    //新增内容
    //修改代码12345
    //add code 333
    public enum HANDYID//电批ID
    {
        Handy1,
        Handy2,
    }
    public enum TypeA123
    { 
        A1,//A1&A4
        A2,//A2&A5
        A3//A3&A6
    }

    public enum QRType
    { 
        Pana,
        MainRelayA2A3,//主继电器A3
        MainRelayA1Left,//主继电器A1A2左边
        MainRelayA1Right,//主继电器A1A2右边
        BDSB,//基板
        Safe,//保险丝
        Water,//水冷板
        Panel,//托盘
        PreRelay,//预充继电器
        CuQR,//铜片QR
    }

    public enum PROINDEX//工程索引
    {
        MainLine1,//本体组立1
        MainLine2,
        MainLine3,
        MainLine4,
        MainLine5,
        MainLine6,
        MainLine7,
        MainLine8,
        MainLine9,
        RelayLine,//主继电器预组立
        BDSBLine,//BDSB预组立
        WaterLine,//冷水板预装
        SafeLine,//保险丝预装
        HV,//HV检查
        LV,//LV检查
        BDSB,//BDSB检查

    }
    public enum PLCIO
    { 
        BIT0,
        BIT1,
        BIT2,
        BIT3,
        BIT4,
        BIT5,
        BIT6,
        BIT7,
        BIT8,
        BIT9,
        BIT10,
        BIT11,
        BIT12,
        BIT13,
        BIT14,
        BIT15,

    }
    public struct OmronBitAddr
    {
        public MemoryAreaCode AreaCode;//内存区
        public byte[] WdAddr;//字地址
        public int BitNo;//位地址
    }
    public enum CheckEdgeMode
    { 
        Up,
        Down
    }

    public struct ConfigData
    {
        public string DeviceMES;//是否启用检查机追溯

        public string HVPLCIP;//HV
        public string HVPLCPort;
        public string HVDeviceNo;
        public string LVPLCIP;//LV
        public string LVPLCPort;
        public string LVDeviceNo;
        public string BDSBPLCIP;//BDSB
        public string BDSBPLCPort;
        public string BDSBDeviceNo;


        public string NewAppPath;//高版本软件路径
        public string AutoUpdateAppPath;//自动更新APP路径

        public int TYPE;//产品式样索引
        public string REPEAT;//允许产品追溯重复作业
        public string CCDUSE;//启用CCD，OFF跳过CCD检查
        public string OmronScaner;//欧姆龙扫描仪启用
        public string HandyScaner;//手持式扫描仪启用
        public string WatchImg;//CCD图片监控启用

        public int Proj;//工程名索引
        public string LineNo;//生产线号
        public string DeviceNo;//装置设备号
        public int LD1;//螺钉数1
        public int LD2;//螺钉数2
        public string Handy1;//电批1
        public string HandyPort1;//电批端口号
        public string HandyBaud1;//电批波特率
        public string Handy2;//电批2
        public string HandyPort2;//电批端口号
        public string HandyBaud2;//电批波特率
        public string QR1;//QR1使用标志
        public string QRIP1;//QR1IP地址
        public string QRPort1;//QR1端口
        public string QR2;//QR1使用标志
        public string QRIP2;//QR1IP地址
        public string QRPort2;//QR1端口
        public string QR3;//QR1使用标志
        public string QRIP3;//QR1IP地址
        public string QRPort3;//QR1端口
        public string QR4;//QR1使用标志
        public string QRIP4;//QR1IP地址
        public string QRPort4;//QR1端口
        public string QR5;//QR1使用标志
        public string QRIP5;//QR1IP地址
        public string QRPort5;//QR1端口
        public string QR6;//QR1使用标志
        public string QRIP6;//QR1IP地址
        public string QRPort6;//QR1端口
        public string PLCIP;
        public string PLCPort;
        public string ServerIP;
        public string ServerPort;
        public string HandyIP1;//电批IP地址
        public string HandyNetPort1;//电批网络端口
        public string HandyIP2;//电批IP地址
        public string HandyNetPort2;//电批网络端口
        public string CCD1;
        public string CCDIP1;
        public string CCDPort1;
        public string CCD2;
        public string CCDIP2;
        public string CCDPort2;
        public string CCD3;
        public string CCDIP3;
        public string CCDPort3;
        public string CCD4;
        public string CCDIP4;
        public string CCDPort4;
        public string ShuntPath;//日本电阻分流值
        public string ImgPath;//CCD图片的路径
        public string LDErr;//是否监控螺钉数量
        public string Passward;

        public int ScrewTimes;//螺钉打入次数
        public int ScrewLimit;//次数的管理
    }
    class PublicValue
    {
        public const int QR1 = 0;
        public const int QR2 = 1;
        public const int QR3 = 2;
        public const int QR4 = 3;
        public const int QR5 = 4;
        public const int QR6 = 5;
        //第一Q         = 0
        //第二QR        = 1
        //CCD到位感应   = 2
        //螺钉感应      = 4
        //复位          = 7
        //STOP1托盘感应 = 9

        //STOP1气缸     = 0
        //STOP2气缸     = 2


        //本体组立1
        public static int IN1_STOP_CCD = (int)PLCIO.BIT2;
        public static int IN1_STOP_M6 = (int)PLCIO.BIT9;
        public static int IN1_QR_PANA = (int)PLCIO.BIT0;
        public static int IN1_QR_RELAY = (int)PLCIO.BIT1;//继电器
        public static int IN1_SCREW_M6 = (int)PLCIO.BIT4;//M6螺钉机
        public static int IN1_RESET = (int)PLCIO.BIT7;
        public static int OUT1_STOP_CCD = (int)PLCIO.BIT2;
        public static int OUT1_STOP_M6 = (int)PLCIO.BIT0;
        //本体组立2
        public static int IN2_QR_PANA = (int)PLCIO.BIT0;
        public static int IN2_STOP_M6 = (int)PLCIO.BIT5;
        public static int IN2_SCREW_M6 = (int)PLCIO.BIT4;//M6螺钉机
        public static int IN2_BUTTON = (int)PLCIO.BIT4;//按钮
        public static int IN2_QR_CU = (int)PLCIO.BIT4;//铜片
        public static int IN2_RESET = (int)PLCIO.BIT7; 
        public static int IN2_UP_OK = (int)PLCIO.BIT7; //治具上升到位
        public static int IN2_DOWN_OK = (int)PLCIO.BIT7; //治具下降到位
        public static int OUT2_STOP_M6 = (int)PLCIO.BIT0;

        //本体组立3
        public static int IN3_STOP_M6 = (int)PLCIO.BIT0;
        public static int IN3_STOP_M4 = (int)PLCIO.BIT2;
        public static int IN3_STOP_CCD = (int)PLCIO.BIT2;
        public static int IN3_QR_BOARD = (int)PLCIO.BIT1;//基板
        public static int IN3_SCREW_M6 = (int)PLCIO.BIT4;//M6螺钉机
        public static int IN3_SCREW_M4 = (int)PLCIO.BIT4;//M4螺钉机
        public static int IN3_RESET = (int)PLCIO.BIT7;
        public static int OUT3_STOP_M6 = (int)PLCIO.BIT0;
        public static int OUT3_STOP_M4 = (int)PLCIO.BIT0;


        //本体组立4
        public static int IN4_STOP_CCD = (int)PLCIO.BIT2;
        public static int IN4_QR_PANA = (int)PLCIO.BIT0;
        public static int IN4_RESET = (int)PLCIO.BIT7;
        public static int OUT4_STOP_CCD = (int)PLCIO.BIT0;

        //本体组立5
        public static int IN5_STOP_M5 = (int)PLCIO.BIT2;
        public static int IN5_SCREW_M5 = (int)PLCIO.BIT4;//M5螺钉机
        public static int IN5_RESET = (int)PLCIO.BIT7;
        public static int OUT5_STOP_M5 = (int)PLCIO.BIT0;

        //本体组立6
        public static int IN6_STOP_M4 = (int)PLCIO.BIT5;
        public static int IN6_STOP_CCD = (int)PLCIO.BIT2;
        public static int IN6_STOP_M6 = (int)PLCIO.BIT5;
        public static int IN6_QR_WATER = (int)PLCIO.BIT1;//水冷板
        public static int IN6_SCREW_M4 = (int)PLCIO.BIT4;//M4螺钉机
        public static int IN6_SCREW_M6 = (int)PLCIO.BIT4;//M6螺钉机
        public static int IN6_RESET = (int)PLCIO.BIT7;
        public static int IN6_QR_SAFT = (int)PLCIO.BIT7;//保险丝
        public static int IN6_UP_OK = (int)PLCIO.BIT7; //治具上升到位
        public static int IN6_DOWN_OK = (int)PLCIO.BIT7; //治具下降到位
        public static int OUT6_STOP_M4 = (int)PLCIO.BIT5;
        public static int OUT6_STOP_CCD = (int)PLCIO.BIT0;
        public static int OUT6_STOP_M6 = (int)PLCIO.BIT0;
        //本体组立7
        public static int IN7_STOP_M4_1 = (int)PLCIO.BIT5;
        public static int IN7_STOP_M4_2 = (int)PLCIO.BIT5;
        public static int IN7_STOP_CCD = (int)PLCIO.BIT2;
        public static int IN7_QR_PANA = (int)PLCIO.BIT0;
        public static int IN7_QR_SAFT = (int)PLCIO.BIT1;//保险丝
        public static int IN7_SCREW_M4_1 = (int)PLCIO.BIT4;//M4螺钉机
        public static int IN7_SCREW_M4_2 = (int)PLCIO.BIT4;//M4螺钉机
        public static int IN7_RESET = (int)PLCIO.BIT7;
        public static int OUT7_STOP_M4_1 = (int)PLCIO.BIT5;
        public static int OUT7_STOP_M4_2 = (int)PLCIO.BIT5;
        public static int OUT7_STOP_CCD = (int)PLCIO.BIT0;

        //本体组立8
        public static int IN8_STOP_M4 = (int)PLCIO.BIT5;
        public static int IN8_QR_PANA = (int)PLCIO.BIT0;
        public static int IN8_SCREW_M4 = (int)PLCIO.BIT4;//M4螺钉机
        public static int IN8_RESET = (int)PLCIO.BIT7;
        public static int OUT8_STOP_M4 = (int)PLCIO.BIT5;

        //本体组立9
        public static int IN9_QR_PANA = (int)PLCIO.BIT0;
        public static int IN9_RESET = (int)PLCIO.BIT7;
        public static int IN9_ENDBUTTON = (int)PLCIO.BIT0;
        public static int OUT9_STOP_GM = (int)PLCIO.BIT5;
        public static int OUT9_STOP_END = (int)PLCIO.BIT5;

        //主继电器预装
        public static int INRealy_STOP_M5 = (int)PLCIO.BIT5;
        public static int INRealy_RESET = (int)PLCIO.BIT7;
        public static int INRealy_SCREW_M5 = (int)PLCIO.BIT4;//M5螺钉机
        public static int OUTRealy_STOP_M5 = (int)PLCIO.BIT7;

        //BDSB基板预装
        public static int INBDSB_STOP_M4 = (int)PLCIO.BIT5;
        public static int INBDSB_RESET = (int)PLCIO.BIT7;
        public static int INBDSB_STOP_CCD = (int)PLCIO.BIT2;
        public static int INBDSB_QR_BOARD = (int)PLCIO.BIT2;
        public static int INBDSB_SCREW_M4 = (int)PLCIO.BIT4;//M4螺钉机
        public static int OUTBDSB_STOP_M4 = (int)PLCIO.BIT4;
        public static int OUTBDSB_STOP_CCD = (int)PLCIO.BIT4;

        //保险丝预装
        public static int INSAFT_STOP_M6 = (int)PLCIO.BIT0;
        public static int INSAFT_SCREW_M6 = (int)PLCIO.BIT4;//M6螺钉机
        public static int INSAFT_RESET = (int)PLCIO.BIT7;
        public static int OUTSAFT_STOP_M6 = (int)PLCIO.BIT0;

        //水冷板预装
        public static int INWATER_QR_WATER = (int)PLCIO.BIT1;//水冷板
        public static int INWATER_STOP_CCD = (int)PLCIO.BIT2;
        public static int INWATER_RESET = (int)PLCIO.BIT7;
        public static int OUTWATER_STOP_CCD = (int)PLCIO.BIT0;
        /// <summary>
        /// 本的分流电阻文件路径
        /// </summary>
        //public static string ShuntPath = "";//日本的分流电阻文件路径

        //HV检查
        public static OmronBitAddr Err1CheckHV = new OmronBitAddr 
        { AreaCode = MemoryAreaCode.CIOWord, WdAddr = new byte[] { 0x00, 0x00, 0x00 }, BitNo = 1 };//CIO0.01//设备异常1检查
        public static OmronBitAddr StartCheckHV = new OmronBitAddr
        { AreaCode = MemoryAreaCode.CIOWord, WdAddr = new byte[] { 0x00, 0x02, 0x00 }, BitNo = 13 };//CI02.13//产品进入设备感应开始
        public static OmronBitAddr StartRdQrFlatHV = new OmronBitAddr 
        {AreaCode = MemoryAreaCode.WRWord, WdAddr = new byte[] { 0x17, 0x0E, 0x00 }, BitNo = 9 };//W5902.09//开始读取PLC QR标志
        public static OmronBitAddr QRAddrHV = new OmronBitAddr
        { AreaCode = MemoryAreaCode.DMWord, WdAddr = new byte[] { 0x11, 0x62, 0x00 } };//DM4450//QR地址
        public static OmronBitAddr IsOKCheckHV = new OmronBitAddr
        { AreaCode = MemoryAreaCode.WRWord, WdAddr = new byte[] { 0x00, 0xF3, 0x00 }, BitNo = 4 };//W243.04//检测OK标志
        public static OmronBitAddr IsNGCheckHV = new OmronBitAddr
        { AreaCode = MemoryAreaCode.WRWord, WdAddr = new byte[] { 0x00, 0xF3, 0x00 }, BitNo = 5 };//W243.05//检测NG标志

        //LV检查
        public static OmronBitAddr Err1CheckLV = new OmronBitAddr
        { AreaCode = MemoryAreaCode.CIOWord, WdAddr = new byte[] { 0x00, 0x00, 0x00 }, BitNo = 1 };//CIO0.01//设备异常1检查
        public static OmronBitAddr StartCheckLV = new OmronBitAddr
        { AreaCode = MemoryAreaCode.CIOWord, WdAddr = new byte[] { 0x00, 0x02, 0x00 }, BitNo = 13 };//CI02.13//产品进入设备感应开始
        public static OmronBitAddr StartRdQrFlatLV = new OmronBitAddr
        { AreaCode = MemoryAreaCode.WRWord, WdAddr = new byte[] { 0x17, 0x0E, 0x00 }, BitNo = 9 };//W5902.09//开始读取PLC QR标志
        public static OmronBitAddr QRAddrLV = new OmronBitAddr
        { AreaCode = MemoryAreaCode.DMWord, WdAddr = new byte[] { 0x11, 0x62, 0x00 } };//DM4450//QR地址
        public static OmronBitAddr IsOKCheckLV = new OmronBitAddr
        { AreaCode = MemoryAreaCode.WRWord, WdAddr = new byte[] { 0x00, 0xF3, 0x00 }, BitNo = 4 };//W243.04//检测OK标志
        public static OmronBitAddr IsNGCheckLV = new OmronBitAddr
        { AreaCode = MemoryAreaCode.WRWord, WdAddr = new byte[] { 0x00, 0xF3, 0x00 }, BitNo = 5 };//W243.05//检测NG标志

        //BDSB检查
        public static OmronBitAddr Err1CheckBDSB = new OmronBitAddr
        { AreaCode = MemoryAreaCode.CIOWord, WdAddr = new byte[] { 0x00, 0x00, 0x00 }, BitNo = 1 };//CIO0.01//设备异常1检查
        public static OmronBitAddr StartCheckBDSB = new OmronBitAddr
        { AreaCode = MemoryAreaCode.CIOWord, WdAddr = new byte[] { 0x00, 0x02, 0x00 }, BitNo = 13 };//CI02.13//产品进入设备感应开始
        public static OmronBitAddr StartRdQrFlatBDSB = new OmronBitAddr
        { AreaCode = MemoryAreaCode.WRWord, WdAddr = new byte[] { 0x17, 0x0E, 0x00 }, BitNo = 9 };//W5902.09//开始读取PLC QR标志
        public static OmronBitAddr QRAddrBDSB = new OmronBitAddr
        { AreaCode = MemoryAreaCode.DMWord, WdAddr = new byte[] { 0x11, 0x62, 0x00 } };//DM4450//QR地址
        public static OmronBitAddr IsOKCheckBDSB = new OmronBitAddr
        { AreaCode = MemoryAreaCode.WRWord, WdAddr = new byte[] { 0x00, 0xF3, 0x00 }, BitNo = 4 };//W243.04//检测OK标志
        public static OmronBitAddr IsNGCheckBDSB = new OmronBitAddr
        { AreaCode = MemoryAreaCode.WRWord, WdAddr = new byte[] { 0x00, 0xF3, 0x00 }, BitNo = 5 };//W243.05//检测NG标志


        /// <summary>
        /// 配置文件路径
        /// </summary>
        public static string ConfigPath = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "system.ini");
        //public static SpeechSynthesizer SpeechWord = new System.Speech.Synthesis.SpeechSynthesizer();
        public static TypeA123 TypeIndex = TypeA123.A3;//样式索引  0：A1    1：A2    2：A3
        //synth.SpeakAsync("请在感应器上作业");
        public static string Version = "2021.11.02 Ver" + System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString();
        //public static string WorkerName;

        public static string[] Projects = new string[] {           
            "本体组立1","本体组立2","本体组立3","本体组立4","本体组立5",
            "本体组立6","本体组立7","本体组立8","本体组立9",
            "主继电器预装","BDSB基板预装" ,"水冷板预装","保险丝预装",
            "HV检查","LV检查","BDSB检查",
        };
        public static string[] ProjectCodes = new string[] {
            "980A","980B","980C","980D","980E",
            "980F","980G","980H","980I",
            "975A","975B","975D","975C",
            "990A","990B","990C",
        };
        public static ConfigData configData;
        public static string[,] ItemList = new string[,]
        {           
            { "前工程MES确认","预充继电器QR","CCD1检查","螺钉锁紧M6判定","本工程MES确认" ,"END","","","","","",""},                                             //本体组立1
            { "前工程MES确认","主继电器1QR","主继电器2QR","主继电器3QR","主继电器4QR","升起治具","铜片QR" ,"螺钉锁入M6判定","本工程MES确认" ,"END","",""},      //本体组立2
            { "前工程MES确认","基板QR","螺钉锁紧M6判定","螺钉锁紧M4判定","CCD1检查","CCD2检查","本工程MES确认","END" ,"","" ,"",""},                            //本体组立3
            { "前工程MES确认","CCD1检查","CCD2检查","CCD3检查","CCD4检查","本工程MES确认","END","","" ,"","" ,""},                                              //本体组立4
            { "前工程MES确认","螺钉锁紧M5判定","本工程MES确认","END","","" ,"","" ,"","","",""},                                                                //本体组立5
            { "前工程MES确认","托盘QR","螺钉锁紧M4判定","CCD1检查","CCD2检查","升起治具","水冷板QR","螺钉锁紧M6判定","保险丝QR","螺钉锁紧M6判定","本工程MES确认","END"},//本体组立6
            { "前工程MES确认","螺钉锁紧M4判定","螺钉锁紧M4判定","CCD1检查","本工程确认" ,"END","" ,"","","","",""},                                             //本体组立7
            { "前工程MES确认","螺钉锁紧M4判定","本工程MES确认","END","","" ,"","","" ,"","",""},                                                                //本体组立8
            { "前工程MES确认","GM铭板照合","外观确认检查","本工程MES确认","END","" ,"","" ,"","","",""},                                                        //本体组立9
            { "主继电器1QR","主继电器2QR","主继电器3QR","主继电器4QR","螺钉锁入M5判定" ,"本工程MES确认","END" ,"","","","",""},                                 //主继电器预装
            { "基板QR","螺钉锁紧M4判定","CCD1检查","本工程MES确认","END","" ,"","","","","",""},                                                                //BDSB基板预装
            { "水冷板QR","CCD1检查","CCD2检查","CCD3检查","本工程MES确认","END","" ,"","","","",""},                                                            //水冷板预装
            { "保险丝QR","螺钉锁紧M6判定","本工程MES确认","END","","" ,"","","","","",""},                                                                      //保险丝预装
            { "前工程MES确认","HV检查","本工程MES确认","END","","" ,"","" ,"","","",""},                                                                        //HV检查
            { "前工程MES确认","LV检查","本工程MES确认","END","","" ,"","" ,"","","",""},                                                                        //LV检查
            { "前工程MES确认","BDSB检查","本工程MES确认","END","","" ,"","" ,"","","",""},                                                                      //BDSB检查

        };      
        public static bool SystemInit()
        {
            try
            {
                if (!File.Exists(PublicValue.ConfigPath))
                {
                    MessageBox.Show("system文件不存在！");
                    return false ;
                }
                configData.DeviceMES = INI.Read("Section CheckDevice", "DeviceMES", "", PublicValue.ConfigPath);

                configData.HVPLCIP = INI.Read("Section CheckDevice", "HVPLCIP", "", PublicValue.ConfigPath);
                configData.HVPLCPort = INI.Read("Section CheckDevice", "HVPLCPort", "", PublicValue.ConfigPath);
                configData.HVDeviceNo = INI.Read("Section CheckDevice", "HVDeviceNo", "", PublicValue.ConfigPath);
                configData.LVPLCIP = INI.Read("Section CheckDevice", "LVPLCIP", "", PublicValue.ConfigPath);
                configData.LVPLCPort = INI.Read("Section CheckDevice", "LVPLCPort", "", PublicValue.ConfigPath);
                configData.LVDeviceNo = INI.Read("Section CheckDevice", "LVDeviceNo", "", PublicValue.ConfigPath);
                configData.BDSBPLCIP = INI.Read("Section CheckDevice", "BDSBPLCIP", "", PublicValue.ConfigPath);
                configData.BDSBPLCPort = INI.Read("Section CheckDevice", "BDSBPLCPort", "", PublicValue.ConfigPath);
                configData.BDSBDeviceNo = INI.Read("Section CheckDevice", "BDSBDeviceNo", "", PublicValue.ConfigPath);

                configData.AutoUpdateAppPath = INI.Read("Section Content", "AutoUpdateAppPath", "", PublicValue.ConfigPath);
                configData.NewAppPath = INI.Read("Section Content", "NewAppPath", "", PublicValue.ConfigPath);

                configData.TYPE = Convert.ToInt32(INI.Read("Section Content", "TYPE", "", PublicValue.ConfigPath));
                configData.REPEAT = INI.Read("Section Content", "REPEAT", "ON", PublicValue.ConfigPath);
                configData.CCDUSE = INI.Read("Section Content", "CCDUSE", "ON", PublicValue.ConfigPath);

                configData.OmronScaner = INI.Read("Section Content", "OmronScaner", "ON", PublicValue.ConfigPath);
                configData.HandyScaner = INI.Read("Section Content", "HandyScaner", "ON", PublicValue.ConfigPath);

                configData.WatchImg = INI.Read("Section Content", "WatchImg ", "ON", PublicValue.ConfigPath);

                configData.Proj = Convert.ToInt32(INI.Read("Section Content", "Proj", "", PublicValue.ConfigPath));
                configData.LineNo = INI.Read("Section Content", "LineNo", "", PublicValue.ConfigPath);
                configData.DeviceNo = INI.Read("Section Content", "DeviceNo", "", PublicValue.ConfigPath);
                configData.LD1 = Convert.ToInt32(INI.Read("Section Content", "LD1", "", PublicValue.ConfigPath));
                configData.LD2 = Convert.ToInt32(INI.Read("Section Content", "LD2", "", PublicValue.ConfigPath));

                configData.Handy1 = INI.Read("Section Content", "Handy1", "", PublicValue.ConfigPath);
                configData.HandyPort1 = INI.Read("Section Content", "HandyPort1", "", PublicValue.ConfigPath);
                configData.HandyBaud1 = INI.Read("Section Content", "HandyBaud1", "", PublicValue.ConfigPath);

                configData.Handy2 = INI.Read("Section Content", "Handy2", "", PublicValue.ConfigPath);
                configData.HandyPort2 = INI.Read("Section Content", "HandyPort2", "", PublicValue.ConfigPath);
                configData.HandyBaud2 = INI.Read("Section Content", "HandyBaud2", "", PublicValue.ConfigPath);

                configData.QR1 = INI.Read("Section Content", "QR1", "", PublicValue.ConfigPath);
                configData.QRIP1 = INI.Read("Section Content", "QRIP1", "", PublicValue.ConfigPath);
                configData.QRPort1 = INI.Read("Section Content", "QRPort1", "", PublicValue.ConfigPath);

                configData.QR2 = INI.Read("Section Content", "QR2", "", PublicValue.ConfigPath);
                configData.QRIP2 = INI.Read("Section Content", "QRIP2", "", PublicValue.ConfigPath);
                configData.QRPort2 = INI.Read("Section Content", "QRPort2", "", PublicValue.ConfigPath);

                configData.QR3 = INI.Read("Section Content", "QR3", "", PublicValue.ConfigPath);
                configData.QRIP3 = INI.Read("Section Content", "QRIP3", "", PublicValue.ConfigPath);
                configData.QRPort3 = INI.Read("Section Content", "QRPort3", "", PublicValue.ConfigPath);

                configData.QR4 = INI.Read("Section Content", "QR4", "", PublicValue.ConfigPath);
                configData.QRIP4 = INI.Read("Section Content", "QRIP4", "", PublicValue.ConfigPath);
                configData.QRPort4 = INI.Read("Section Content", "QRPort4", "", PublicValue.ConfigPath);

                configData.QR5 = INI.Read("Section Content", "QR5", "", PublicValue.ConfigPath);
                configData.QRIP5 = INI.Read("Section Content", "QRIP5", "", PublicValue.ConfigPath);
                configData.QRPort5 = INI.Read("Section Content", "QRPort5", "", PublicValue.ConfigPath);

                configData.QR6 = INI.Read("Section Content", "QR6", "", PublicValue.ConfigPath);
                configData.QRIP6 = INI.Read("Section Content", "QRIP6", "", PublicValue.ConfigPath);
                configData.QRPort6 = INI.Read("Section Content", "QRPort6", "", PublicValue.ConfigPath);

                configData.PLCIP = INI.Read("Section Content", "PLCIP", "", PublicValue.ConfigPath);
                configData.PLCPort = INI.Read("Section Content", "PLCPort", "", PublicValue.ConfigPath);

                configData.ServerIP = INI.Read("Section Content", "ServerIP", "", PublicValue.ConfigPath);
                configData.ServerPort = INI.Read("Section Content", "ServerPort", "", PublicValue.ConfigPath);

                configData.HandyIP1 = INI.Read("Section Content", "HandyIP1", "", PublicValue.ConfigPath);
                configData.HandyNetPort1 = INI.Read("Section Content", "HandyNetPort1", "", PublicValue.ConfigPath);

                configData.HandyIP2 = INI.Read("Section Content", "HandyIP2", "", PublicValue.ConfigPath);
                configData.HandyNetPort2= INI.Read("Section Content", "HandyNetPort2", "", PublicValue.ConfigPath);

                configData.CCD1 = INI.Read("Section Content", "CCD1", "", PublicValue.ConfigPath);
                configData.CCDIP1 = INI.Read("Section Content", "CCDIP1", "", PublicValue.ConfigPath);
                configData.CCDPort1 = INI.Read("Section Content", "CCDPort1", "", PublicValue.ConfigPath);

                configData.CCD2 = INI.Read("Section Content", "CCD2", "", PublicValue.ConfigPath);
                configData.CCDIP2 = INI.Read("Section Content", "CCDIP2", "", PublicValue.ConfigPath);
                configData.CCDPort2 = INI.Read("Section Content", "CCDPort2", "", PublicValue.ConfigPath);

                configData.CCD3 = INI.Read("Section Content", "CCD3", "", PublicValue.ConfigPath);
                configData.CCDIP3 = INI.Read("Section Content", "CCDIP3", "", PublicValue.ConfigPath);
                configData.CCDPort3 = INI.Read("Section Content", "CCDPort3", "", PublicValue.ConfigPath);

                configData.CCD4 = INI.Read("Section Content", "CCD4", "", PublicValue.ConfigPath);
                configData.CCDIP4 = INI.Read("Section Content", "CCDIP4", "", PublicValue.ConfigPath);
                configData.CCDPort4 = INI.Read("Section Content", "CCDPort4", "", PublicValue.ConfigPath);

                configData.ShuntPath = INI.Read("Section Content", "ShuntPath", "", PublicValue.ConfigPath);
                configData.ImgPath = INI.Read("Section Content", "ImgPath", "", PublicValue.ConfigPath);
                configData.LDErr = INI.Read("Section Content", "LDErr", "", PublicValue.ConfigPath);
                configData.Passward = INI.Read("Section Content", "Passward", "", PublicValue.ConfigPath);

                configData.ScrewTimes = Convert.ToInt32(INI.Read("Section Content", "ScrewTimes", "", PublicValue.ConfigPath));
                configData.ScrewLimit = Convert.ToInt32(INI.Read("Section Content", "ScrewLimit", "", PublicValue.ConfigPath));

                //PLC IO配置
                //本体组立1
                IN1_STOP_CCD = Convert.ToInt32(INI.Read("PLC Point", "IN1_STOP_CCD", "", PublicValue.ConfigPath));
                IN1_STOP_M6 = Convert.ToInt32(INI.Read("PLC Point", "IN1_STOP_M6", "", PublicValue.ConfigPath));
                IN1_QR_PANA = Convert.ToInt32(INI.Read("PLC Point", "IN1_QR_PANA", "", PublicValue.ConfigPath));
                IN1_QR_RELAY = Convert.ToInt32(INI.Read("PLC Point", "IN1_QR_RELAY", "", PublicValue.ConfigPath));//继电器
                IN1_SCREW_M6 = Convert.ToInt32(INI.Read("PLC Point", "IN1_SCREW_M6", "", PublicValue.ConfigPath));//M6螺钉机
                IN1_RESET = Convert.ToInt32(INI.Read("PLC Point", "IN1_RESET", "", PublicValue.ConfigPath));
                OUT1_STOP_CCD = Convert.ToInt32(INI.Read("PLC Point", "OUT1_STOP_CCD", "", PublicValue.ConfigPath));
                OUT1_STOP_M6 = Convert.ToInt32(INI.Read("PLC Point", "OUT1_STOP_M6", "", PublicValue.ConfigPath));

                //本体组立2
                IN2_QR_PANA = Convert.ToInt32(INI.Read("PLC Point", "IN2_QR_PANA", "", PublicValue.ConfigPath));
                IN2_STOP_M6 = Convert.ToInt32(INI.Read("PLC Point", "IN2_STOP_M6", "", PublicValue.ConfigPath));
                IN2_SCREW_M6 = Convert.ToInt32(INI.Read("PLC Point", "IN2_SCREW_M6", "", PublicValue.ConfigPath));//M6螺钉机
                IN2_BUTTON = Convert.ToInt32(INI.Read("PLC Point", "IN2_BUTTON", "", PublicValue.ConfigPath));//按钮
                IN2_QR_CU = Convert.ToInt32(INI.Read("PLC Point", "IN2_QR_CU", "", PublicValue.ConfigPath));//铜片
                IN2_RESET = Convert.ToInt32(INI.Read("PLC Point", "IN2_RESET", "", PublicValue.ConfigPath));
                IN2_UP_OK = Convert.ToInt32(INI.Read("PLC Point", "IN2_UP_OK ", "", PublicValue.ConfigPath));
                IN2_DOWN_OK = Convert.ToInt32(INI.Read("PLC Point", "IN2_DOWN_OK  ", "", PublicValue.ConfigPath));

                OUT2_STOP_M6 = Convert.ToInt32(INI.Read("PLC Point", "OUT2_STOP_M6", "", PublicValue.ConfigPath));

                //本体组立3
                IN3_STOP_M6 = Convert.ToInt32(INI.Read("PLC Point", "IN3_STOP_M6", "", PublicValue.ConfigPath));
                IN3_STOP_M4 = Convert.ToInt32(INI.Read("PLC Point", "IN3_STOP_M4", "", PublicValue.ConfigPath));
                IN3_QR_BOARD = Convert.ToInt32(INI.Read("PLC Point", "IN3_QR_BOARD", "", PublicValue.ConfigPath));//基板
                IN3_SCREW_M6 = Convert.ToInt32(INI.Read("PLC Point", "IN3_SCREW_M6", "", PublicValue.ConfigPath));//M6螺钉机
                IN3_SCREW_M4 = Convert.ToInt32(INI.Read("PLC Point", "IN3_SCREW_M4", "", PublicValue.ConfigPath));//M4螺钉机
                IN3_RESET = Convert.ToInt32(INI.Read("PLC Point", "IN3_RESET", "", PublicValue.ConfigPath));
                IN3_STOP_CCD = Convert.ToInt32(INI.Read("PLC Point", "IN3_STOP_CCD", "", PublicValue.ConfigPath));
                OUT3_STOP_M6 = Convert.ToInt32(INI.Read("PLC Point", "OUT3_STOP_M6", "", PublicValue.ConfigPath));
                OUT3_STOP_M4 = Convert.ToInt32(INI.Read("PLC Point", "OUT3_STOP_M4", "", PublicValue.ConfigPath));

                //本体组立4
                IN4_STOP_CCD = Convert.ToInt32(INI.Read("PLC Point", "IN4_STOP_CCD", "", PublicValue.ConfigPath));
                IN4_QR_PANA = Convert.ToInt32(INI.Read("PLC Point", "IN4_QR_PANA", "", PublicValue.ConfigPath));
                IN4_RESET = Convert.ToInt32(INI.Read("PLC Point", "IN4_RESET", "", PublicValue.ConfigPath));
                OUT4_STOP_CCD = Convert.ToInt32(INI.Read("PLC Point", "OUT4_STOP_CCD", "", PublicValue.ConfigPath));

                //本体组立5
                IN5_STOP_M5 = Convert.ToInt32(INI.Read("PLC Point", "IN5_STOP_M5", "", PublicValue.ConfigPath));
                IN5_SCREW_M5 = Convert.ToInt32(INI.Read("PLC Point", "IN5_SCREW_M5", "", PublicValue.ConfigPath));//M5螺钉机
                IN5_RESET = Convert.ToInt32(INI.Read("PLC Point", "IN5_RESET", "", PublicValue.ConfigPath));
                OUT5_STOP_M5 = Convert.ToInt32(INI.Read("PLC Point", "OUT5_STOP_M5", "", PublicValue.ConfigPath));

                //本体组立6
                IN6_STOP_M4 = Convert.ToInt32(INI.Read("PLC Point", "IN6_STOP_M4", "", PublicValue.ConfigPath));
                IN6_STOP_CCD = Convert.ToInt32(INI.Read("PLC Point", "IN6_STOP_CCD", "", PublicValue.ConfigPath));
                IN6_STOP_M6 = Convert.ToInt32(INI.Read("PLC Point", "IN6_STOP_M6", "", PublicValue.ConfigPath));
                IN6_QR_WATER = Convert.ToInt32(INI.Read("PLC Point", "IN6_QR_WATER", "", PublicValue.ConfigPath));//水冷板
                IN6_SCREW_M4 = Convert.ToInt32(INI.Read("PLC Point", "IN6_SCREW_M4", "", PublicValue.ConfigPath));//M4螺钉机
                IN6_SCREW_M6 = Convert.ToInt32(INI.Read("PLC Point", "IN6_SCREW_M6", "", PublicValue.ConfigPath));//M6螺钉机
                IN6_RESET = Convert.ToInt32(INI.Read("PLC Point", "IN6_RESET", "", PublicValue.ConfigPath));
                IN6_QR_SAFT = Convert.ToInt32(INI.Read("PLC Point", "IN6_QR_SAFT", "", PublicValue.ConfigPath));//保险丝
                IN6_UP_OK = Convert.ToInt32(INI.Read("PLC Point", "IN6_UP_OK ", "", PublicValue.ConfigPath));
                IN6_DOWN_OK = Convert.ToInt32(INI.Read("PLC Point", "IN6_DOWN_OK  ", "", PublicValue.ConfigPath));
                OUT6_STOP_M4 = Convert.ToInt32(INI.Read("PLC Point", "OUT6_STOP_M4", "", PublicValue.ConfigPath));
                OUT6_STOP_CCD = Convert.ToInt32(INI.Read("PLC Point", "OUT6_STOP_CCD", "", PublicValue.ConfigPath));
                OUT6_STOP_M6 = Convert.ToInt32(INI.Read("PLC Point", "OUT6_STOP_M6", "", PublicValue.ConfigPath));
                //本体组立7
                IN7_STOP_M4_1 = Convert.ToInt32(INI.Read("PLC Point", "IN7_STOP_M4_1", "", PublicValue.ConfigPath));
                IN7_STOP_M4_2 = Convert.ToInt32(INI.Read("PLC Point", "IN7_STOP_M4_2", "", PublicValue.ConfigPath));
                IN7_STOP_CCD = Convert.ToInt32(INI.Read("PLC Point", "IN7_STOP_CCD", "", PublicValue.ConfigPath));
                IN7_QR_PANA = Convert.ToInt32(INI.Read("PLC Point", "IN7_QR_PANA", "", PublicValue.ConfigPath));
                IN7_QR_SAFT = Convert.ToInt32(INI.Read("PLC Point", "IN7_QR_SAFT", "", PublicValue.ConfigPath));//保险丝
                IN7_SCREW_M4_1 = Convert.ToInt32(INI.Read("PLC Point", "IN7_SCREW_M4_1", "", PublicValue.ConfigPath));//M4螺钉机
                IN7_SCREW_M4_2 = Convert.ToInt32(INI.Read("PLC Point", "IN7_SCREW_M4_2", "", PublicValue.ConfigPath));//M4螺钉机
                IN7_RESET = Convert.ToInt32(INI.Read("PLC Point", "IN7_RESET", "", PublicValue.ConfigPath));
                OUT7_STOP_M4_1 = Convert.ToInt32(INI.Read("PLC Point", "OUT7_STOP_M4_1", "", PublicValue.ConfigPath));
                OUT7_STOP_M4_2 = Convert.ToInt32(INI.Read("PLC Point", "OUT7_STOP_M4_2", "", PublicValue.ConfigPath));
                OUT7_STOP_CCD = Convert.ToInt32(INI.Read("PLC Point", "OUT7_STOP_CCD", "", PublicValue.ConfigPath));

                //本体组立8
                IN8_STOP_M4 = Convert.ToInt32(INI.Read("PLC Point", "IN8_STOP_M4", "", PublicValue.ConfigPath));
                IN8_QR_PANA = Convert.ToInt32(INI.Read("PLC Point", "IN8_QR_PANA", "", PublicValue.ConfigPath));
                IN8_SCREW_M4 = Convert.ToInt32(INI.Read("PLC Point", "IN8_SCREW_M4", "", PublicValue.ConfigPath));//M4螺钉机
                IN8_RESET = Convert.ToInt32(INI.Read("PLC Point", "IN8_RESET", "", PublicValue.ConfigPath));
                OUT8_STOP_M4 = Convert.ToInt32(INI.Read("PLC Point", "OUT8_STOP_M4", "", PublicValue.ConfigPath));

                //本体组立9
                IN9_RESET = Convert.ToInt32(INI.Read("PLC Point", "IN9_RESET", "", PublicValue.ConfigPath));
                IN9_QR_PANA = Convert.ToInt32(INI.Read("PLC Point", "IN9_QR_PANA", "", PublicValue.ConfigPath));
                IN9_ENDBUTTON = Convert.ToInt32(INI.Read("PLC Point", "IN9_ENDBUTTON", "", PublicValue.ConfigPath));
                OUT9_STOP_GM = Convert.ToInt32(INI.Read("PLC Point", "OUT9_STOP_GM", "", PublicValue.ConfigPath));
                OUT9_STOP_END = Convert.ToInt32(INI.Read("PLC Point", "OUT9_STOP_END", "", PublicValue.ConfigPath));

                //主继电器预装
                INRealy_STOP_M5 = Convert.ToInt32(INI.Read("PLC Point", "INRealy_STOP_M5", "", PublicValue.ConfigPath));
                INRealy_RESET = Convert.ToInt32(INI.Read("PLC Point", "INRealy_RESET", "", PublicValue.ConfigPath));
                INRealy_SCREW_M5 = Convert.ToInt32(INI.Read("PLC Point", "INRealy_SCREW_M5", "", PublicValue.ConfigPath));//M5螺钉机
                OUTRealy_STOP_M5 = Convert.ToInt32(INI.Read("PLC Point", "OUTRealy_STOP_M5", "", PublicValue.ConfigPath));

                //BDSB基板预装
                INBDSB_STOP_M4 = Convert.ToInt32(INI.Read("PLC Point", "INBDSB_STOP_M4", "", PublicValue.ConfigPath));
                INBDSB_RESET = Convert.ToInt32(INI.Read("PLC Point", "INBDSB_RESET", "", PublicValue.ConfigPath));
                INBDSB_STOP_CCD = Convert.ToInt32(INI.Read("PLC Point", "INBDSB_STOP_CCD", "", PublicValue.ConfigPath));
                INBDSB_QR_BOARD = Convert.ToInt32(INI.Read("PLC Point", "INBDSB_QR_BOARD", "", PublicValue.ConfigPath));
                INBDSB_SCREW_M4 = Convert.ToInt32(INI.Read("PLC Point", "INBDSB_SCREW_M4", "", PublicValue.ConfigPath));//M4螺钉机
                OUTBDSB_STOP_M4 = Convert.ToInt32(INI.Read("PLC Point", "OUTBDSB_STOP_M4", "", PublicValue.ConfigPath));
                OUTBDSB_STOP_CCD = Convert.ToInt32(INI.Read("PLC Point", "OUTBDSB_STOP_CCD", "", PublicValue.ConfigPath));

                //保险丝预装
                INSAFT_STOP_M6 = Convert.ToInt32(INI.Read("PLC Point", "INSAFT_STOP_M6", "", PublicValue.ConfigPath));
                INSAFT_SCREW_M6 = Convert.ToInt32(INI.Read("PLC Point", "INSAFT_SCREW_M6", "", PublicValue.ConfigPath));//M6螺钉机
                INSAFT_RESET = Convert.ToInt32(INI.Read("PLC Point", "INSAFT_RESET", "", PublicValue.ConfigPath));
                OUTSAFT_STOP_M6 = Convert.ToInt32(INI.Read("PLC Point", "OUTSAFT_STOP_M6", "", PublicValue.ConfigPath));

                //水冷板预装
                INWATER_QR_WATER = Convert.ToInt32(INI.Read("PLC Point", "INWATER_QR_WATER", "", PublicValue.ConfigPath));//水冷板
                INWATER_STOP_CCD = Convert.ToInt32(INI.Read("PLC Point", "INWATER_STOP_CCD", "", PublicValue.ConfigPath));
                INWATER_RESET = Convert.ToInt32(INI.Read("PLC Point", "INWATER_RESET", "", PublicValue.ConfigPath));
                OUTWATER_STOP_CCD = Convert.ToInt32(INI.Read("PLC Point", "OUTWATER_STOP_CCD", "", PublicValue.ConfigPath));

                

            }
            catch
            {
                MessageBox.Show("system文件出错！");
                return false;
            }
            return true;
        }
        public static void Delay(int milli_second)
        {
            int start = Environment.TickCount;
            while (Math.Abs(Environment.TickCount - start) < milli_second)//毫秒
            {
                Application.DoEvents();//可执行某无聊的操作
            }
        }
        /// <summary>
        /// 确认版本号并自动调用更新程序
        /// </summary>
        /// <param name="newAppPath">新程序的路径</param>
        /// <param name="autoUpdateAppPath">自动更新程序的路径</param>
        public static bool AutoUpdate(string newAppPath, string autoUpdateAppPath)
        {
            //获取本身的版本号
            var Ver = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version;//程序集版本
            //string Ver2 = Application.ProductVersion.ToString();//文件版本
            //string Ver3 = System.Deployment.Application.ApplicationDeployment.CurrentDeployment.CurrentVersion.ToString();//部署版本
            //访问共享文件夹
            if (File.Exists(newAppPath))
            {
                //获取指定exe程序的版本号
                var newVer = AssemblyName.GetAssemblyName(newAppPath).Version;
                //对比版本号，确认是否需要自动更新
                if (Ver.CompareTo(newVer) < 0)
                {
                    if (File.Exists(autoUpdateAppPath))
                    {
                        //打开自动更新程序
                        System.Diagnostics.Process.Start(autoUpdateAppPath);
                        //本程序关闭
                        return true;

                    }
                    else//没有找到自动更新程序
                    {
                        MessageBox.Show("未找到自动更新程序！");
                    }
                }
            }
            return false;

        }
        /// <summary>
        /// 获取可使用的串口
        /// </summary>
        /// <returns>串口名称</returns>
        public static string[] GetPortNames()
        {
            return System.IO.Ports.SerialPort.GetPortNames();
        }
        public static bool IsNumberic(string val)
        {
            //判断是否为整数字符串
            //是的话则将其转换为数字并将其设为out类型的输出值、返回true, 否则为false
            int result = -1;   //result 定义为out 用来输出值
            try
            {
                result = Convert.ToInt32(val);
                return true;
            }
            catch
            {
                return false;
            }
        }
        /// <summary>
        /// 判断应用是否正在运行
        /// </summary>
        /// <returns></returns>
        public static bool IsAppOpen()
        {
            int processCount = 0;
            System.Diagnostics.Process[] pa = System.Diagnostics.Process.GetProcesses();//获取当前进程数组。
            foreach (System.Diagnostics.Process PTest in pa)
            {
                if (PTest.ProcessName == System.Diagnostics.Process.GetCurrentProcess().ProcessName)
                {
                    processCount += 1;
                }
            }
            if (processCount > 1)
            {
                return true;
            }
            return false;
        }
        public static string SerialRead(System.IO.Ports.SerialPort QRPort,int waitTime = 50)
        {
            string str = string.Empty;
            int TimeCount = Environment.TickCount;//记录当前时间
            do
            {
                int count = QRPort.BytesToRead;
                if (count <= 0)
                {
                    if ((Environment.TickCount - TimeCount) < waitTime)//间隔50ms没有数据过来就结束本包数据的接收
                    {
                        continue;
                    }
                    else
                    {
                        //str = "err:" + str;//标记不是完整的数据包
                        break;
                    }
                }
                byte[] readBuffer = new byte[count];
                Application.DoEvents();
                QRPort.Read(readBuffer, 0, count);
                str += System.Text.Encoding.Default.GetString(readBuffer);
                TimeCount = Environment.TickCount;
            } while (QRPort.BytesToRead > 0 || str.Substring(str.Length - 1) != "\r");//数据包的结束符
            return str;
        }
    }
}
