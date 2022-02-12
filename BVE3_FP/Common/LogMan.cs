using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Common
{
    //准备推送到远程
    public enum LogType
    { 
        SD,
        REC
    }

    class LogMan
    {
        public string HearderStr;//文件标题头
        public string FilePathDir;//程序所在文件夹 
        public string FileExtension { get; }//文件后缀名 

        public string FileDirName { get; }//保存的文件夹名
        /// <summary>
        /// 类实例初始化
        /// </summary>
        /// <param name="file_type">文件类型</param>
        /// <param name="hearder">欲设置的项名</param>
        /// <param name="file_dir_name">要写入的新字符串</param>
        /// <returns></returns>
        public LogMan(string file_type, string hearder = "", string file_dir_name = "LOG", string basic_Dir = "")
        {
            FileExtension = file_type;
            HearderStr = hearder;
            FileDirName = file_dir_name;
            if (basic_Dir == "")
                FilePathDir = AppDomain.CurrentDomain.BaseDirectory + FileDirName;
            else
                FilePathDir = basic_Dir + "\\" + FileDirName;
        }
        /// <summary>
        /// 文件保存
        /// </summary>
        /// <param name="data_str">写入内容</param>
        /// <param name="file_name">自定义文件名</param>
        /// <param name="IsDateDir">是否自动创建年月日文件夹</param>
        /// <param name="IsAppend">是否追加保存true:追加，fales:覆盖</param>
        /// <returns></returns>
        public bool LogSave(LogType logType, string data_str, string file_name = "", bool IsDateDir = true, bool IsAppend = true)
        {
            try
            {
                string type = (logType == LogType.SD ? "SD" : "RE");
                if (file_name == "")
                {
                    file_name = DateTime.Now.ToString(type+"yyyyMMdd_HHmmss_fff");
                }
                string file_path = "";

                if (Directory.Exists(FilePathDir) == false)
                {
                    Directory.CreateDirectory(FilePathDir);
                }
                if (IsDateDir == true)
                {
                    string dirY = FilePathDir + "\\" + DateTime.Now.ToString("yyyy");
                    if (Directory.Exists(dirY) == false)
                    {
                        Directory.CreateDirectory(dirY);
                    }
                    string dirM = dirY + "\\" + DateTime.Now.ToString("MM");
                    if (Directory.Exists(dirM) == false)
                    {
                        Directory.CreateDirectory(dirM);
                    }
                    string dirD = dirM + "\\" + DateTime.Now.ToString("dd");
                    if (Directory.Exists(dirD) == false)
                    {
                        Directory.CreateDirectory(dirD);
                    }
                    string dirType = dirD + "\\" + type;
                    if (Directory.Exists(dirType) == false)
                    {
                        Directory.CreateDirectory(dirType);
                    }
                    file_path = dirType + "\\" + file_name + FileExtension;
                }
                else
                {
                    file_path = FilePathDir + "\\" + file_name + FileExtension;
                }
                if (!File.Exists(file_path) && HearderStr != "")
                {
                    using (StreamWriter writer = new StreamWriter(file_path, IsAppend, Encoding.Default))
                    {
                        writer.WriteLine(HearderStr);
                        writer.WriteLine(data_str);
                    }
                }
                else
                {
                    using (StreamWriter writer = new StreamWriter(file_path, IsAppend, Encoding.Default))
                    {
                        writer.WriteLine(data_str);
                        writer.WriteLine("字符长度:"+data_str.Length);
                    }
                }
            }
            catch
            {
                return false;
            }
            return true;
        }
    }
}
