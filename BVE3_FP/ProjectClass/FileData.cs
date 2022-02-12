using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;

namespace BVE3_FP.ProjectClass
{
    public enum LINETYPE
    {
        Main,//本体组立
        Pre//预组立
    }
    class FileData
    {
        public string Program;//程序名
        public string RefNo;//品番
        public string LineNo;//线名
        public string LotNo;//批次
        public string SerNo;//序列号
        public string DeviceNo;//设备号
        public string Date;//日期
        public string Time;
        public string ItemNo;
        public string ItemName;
        public string TestValue;
        public string Unit;//单位
        public string LowerLimit;
        public string UpperLimit;
        public string Result;
        public string Remark;
        private List<string> CsvBufferList = new List<string> { };//CSV缓冲区
        DataMangement localData;
        public FileData(string program, string refNo, string lineNo, string lotNo, string serNo, string deviceNo)
        {
            Program = program;
            RefNo = refNo;
            LineNo = lineNo;
            LotNo = lotNo;
            SerNo = serNo;
            DeviceNo = deviceNo;
            Date = "";
            Time = "";
            ItemNo = "";
            ItemName = "";
            TestValue = "";
            Unit = "";
            LowerLimit = "";
            UpperLimit = "";
            Result = "";
            Remark = "";
            localData = new DataMangement(".csv");
        }
        public void DataAddToBuff(string itemName,string testValue,string unit, string lowerLimit,string upperLimit,string result,string remark)
        {
            Date = DateTime.Now.ToString("yyyy/M/dd");
            Time = DateTime.Now.ToString("HH:mm:ss");
            ItemNo = (CsvBufferList.Count+1).ToString();
            ItemName = itemName;
            TestValue = testValue;
            Unit = unit;
            LowerLimit = lowerLimit;
            UpperLimit = upperLimit;
            Result = result;
            Remark = remark;
            string data = Program + "," + RefNo + "," + LineNo + "," + LotNo + "," + SerNo + ","
                        + DeviceNo + "," + Date + "," + Time + "," + ItemNo + "," + ItemName + ","
                        + TestValue + "," + Unit + "," + LowerLimit + "," + UpperLimit + ","
                        + Result + "," + Remark;
            CsvBufferList.Add(data);
        }
        public string GetBufffStr()
        {
            string data = "";
            foreach (string item in CsvBufferList)
            {
                data += item + "\r\n";
            }
            return data;
        }
        public void BufferClear()
        {
            CsvBufferList.Clear();
        }
        public static string GetCsvName(LINETYPE lineType ,string panaQR)
        {
            if(lineType == LINETYPE.Main)
            {
                string sRef = panaQR.Substring(0, 12);
                string sLot = panaQR.Substring(12, 11);
                string sSer = panaQR.Substring(23);
                if (sRef != "" && sLot != "" && sSer != "")
                {
                    string strRef = string.Format("{0,-12}", sRef.Trim()); //从左道右
                    string strLot = string.Format("{0,-11}", sLot.Trim());
                    string strSer = string.Format("{0,-7}", sSer.Trim());
                    string strTime = DateTime.Now.ToString("yyyyMMddHHmmss");
                    string csv_name = strRef + strLot + strSer + "_" + strTime;
                    return csv_name;
                }
            }
            else
            {
                string strTime = DateTime.Now.ToString("yyyyMMddHHmmss");
                string csv_name = panaQR + "_" + strTime;
                return csv_name;
            }
            return null;
        }
        public bool DataSaveCSV(string csvName)
        {
            string data = GetBufffStr();
            bool rel = localData.Data_Save(data,csvName);
            BufferClear();
            return rel;
        }
    }
}
