using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
namespace Common
{
    class DataMangement
    {
        public string HearderStr;//文件标题头
        public string FilePathDir;//程序所在文件夹 
        public string FileExtension { get; }//文件后缀名 
        
        public string FileDirName { get; }//保存的文件夹名
        /// <summary>
        /// 履历管理
        /// </summary>
        /// <param name="file_type">文件的后缀名</param>
        /// <param name="hearder">文件的首行标题</param>
        /// <param name="file_dir_name">文件所在文件夹</param>
        /// <param name="basic_Dir">文件所在绝对路径</param>
        public DataMangement(string file_type,string hearder = "",string file_dir_name = "DATA",string basic_Dir = "")
        {
            FileExtension = file_type;
            HearderStr = hearder;
            FileDirName = file_dir_name;
            if(basic_Dir == "")
                FilePathDir = AppDomain.CurrentDomain.BaseDirectory + "\\" + FileDirName;
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
        /// <returns>非零表示成功，零表示失败</returns>
        public bool Data_Save(string data_str, string file_name = "", bool IsDateDir = true,bool IsAppend = true)
        {
            try
            {
                if (file_name == "")
                {
                    file_name = DateTime.Now.ToString("yyyyMMdd");
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
                    file_path = dirD + "\\" + file_name + FileExtension;
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
