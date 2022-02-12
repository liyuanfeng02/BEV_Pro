using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public struct TConfigLine
    {
        public string[] TypeRef;//品番名称
        public int ScrewCount;//锁入螺钉总数
        public int StartJob;//锁入螺钉的其实工作组
        public string[] CCD1CH;
        public string[] CCD2CH;
        public string[] CCD3CH;
        public string[] CCD4CH;

    }
    class TypeConfig
    {
        public static TConfigLine[] ReadConfig(string filePath)
        {
            try
            {
                TConfigLine[] configLines = new TConfigLine[] { };
                if (File.Exists(filePath))
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
                    lineStr.Remove(lineStr[0]);//移除标题
                    string[] arrStr = lineStr.ToArray();
                    configLines = new TConfigLine[arrStr.Length];
                    for (int i = 0; i < arrStr.Length; i++)
                    {
                        configLines[i] = new TConfigLine();
                        string[] partLine = arrStr[i].Split(',');
                        //式样
                        configLines[i].TypeRef = partLine[0].Split('&');
                        //主继电器预装螺钉设定
                        string s = partLine[1].Substring(1, partLine[1].Length - 2);
                        string[] arrS = s.Split('-');
                        configLines[i].ScrewCount = Int32.Parse(arrS[0]);
                        configLines[i].StartJob = Int32.Parse(arrS[1]);
                        //CCD通道设定
                        string[] CCDpart = partLine[2].Split('&');
                        for (int j = 0; j < CCDpart.Length; j++)
                        {
                            CCDpart[j] = CCDpart[j].Substring(1, CCDpart[j].Length - 2);//去除方括号
                            string no = CCDpart[j].Substring(0, 1);
                            string chStr = CCDpart[j].Substring(2);
                            string[] sCH = chStr.Split('-');
                            if (no == "1")
                                configLines[i].CCD1CH = sCH;
                            else if (no == "2")
                                configLines[i].CCD2CH = sCH;
                            else if (no == "3")
                                configLines[i].CCD3CH = sCH;
                            else if (no == "4")
                                configLines[i].CCD4CH = sCH;
                        }
                    }
                }
                return configLines;
            }
            catch
            {
                return null;
            }


        }

    }
}
