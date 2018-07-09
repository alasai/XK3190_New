using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YIEternalMIS.Common;

namespace YIEternalMIS.Common
{
    public class SerialPortConfig
    {
        public static string IniFile { get; set; }
        /// <summary>
        /// 去头勾标串口号
        /// </summary>
        public static string HeadHookPort { get; set; }
        /// <summary>
        /// 称重勾标串口号
        /// </summary>
        public static string WeightHookPort { get; set; }
        /// <summary>
        /// 称串口
        /// </summary>
        public static string WeightPort { get; set; }

        ///// <summary>
        /// 读取配置
        /// </summary>
        public static void Read()
        {
            IniFile cfg = new IniFile(IniFile);
            if (cfg != null)
            {
                HeadHookPort = cfg.IniReadValue("SerialPort", "HeadHookPort");
                WeightHookPort = cfg.IniReadValue("SerialPort", "WeightHookPort");
                WeightPort = cfg.IniReadValue("SerialPort", "WeightPort");
            }
        }

        public static string Read(string key)
        {
            IniFile cfg = new IniFile(IniFile);
            if (cfg != null)
            {
                return cfg.IniReadValue("SerialPort", key);
            }

            return string.Empty;
        }

        /// <summary>
        /// 将配置写入INI文件
        /// </summary>
        public void Write(string key,string val)
        {
            IniFile cfg = new IniFile(IniFile);
            if (cfg != null)
            {
                cfg.IniWriteValue("SerialPort", key, val);
            }
        }
    }
}
