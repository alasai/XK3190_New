/*************************************************************************************
    * 类 名 称：       Globals
    * 命名空间：       Common
    * 文 件 名：       Globals
    * 创建时间：       2017/6/2 10:00:10
    * 作    者：        王宏巍
    * 说   明：
    * 修改时间：
    * 修 改 人：
*************************************************************************************/
using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Globalization;
using System.IO;
using System.Collections;
using System.Data;

namespace YIEternalMIS.Common
{
    public class Globals
    {
        public const string DEF_PROGRAM_NAME = "Global\\" + "YIEternalMIS";
        public const string DEF_DATE_FORMAT = "yyyy-MM-dd";// "dd/MM/yyyy";
        public const string DEF_LONE_DATE_FORMAT = "yyyy-MM-dd hh:mm:ss";//"dd/MM/yyyy hh:mm:ss";
        public const string DEF_YYYYMMDD = "yyyyMMdd";
        public const string DEF_YYYYMMDD_LONG = "yyyy-MM-dd";//"yyyy/MM/dd";
        public const string DEF_DATE_LONG_FORMAT = "yyyy-MM-dd hh:mm:ss";//"yyyy/MM/dd hh:mm:ss";                
        public const string DEF_NULL_DATETIME = "1900-1-1";
        public const string DEF_NULL_VALUE = "NULL";
        public const string DEF_CURRENCY = "RMB";//预设货币
        public const string DEF_DECIMAL_FORMAT = "0.00"; //输出格式        
        public const string DEF_NO_TEXT = "*自动生成*";
        public const string INI_CFG_PATH = @"\Config\YIEternalMIS.ini";
        public const string INI_USER = @"\Config\user.ini";
        public const string DEF_SYSTEM_DB = "YIEMIS.System";
        public const string DEF_MASTER_DB = "master";
        public const int DEF_DECIMAL_ROUND = 2;//四舍五入小数位
        //Img公用路径格式
        public const string Img32 = @"{0}\images\32\{1}_32x32.png";
        public const string Img16 = @"{0}\images\16\{1}_16x16.png";

        public const string MsgType1 = "        新闻公告通知";
        public const string MsgType1Img = "ShowHideComment";
        public const string MsgImg = "Comment";
        public const string MsgUpImg = "Status";

        /// <summary>
        /// 加载Debug\Images目录下的的图片
        /// </summary>
        /// <param name="imgFileName">文件名</param>
        /// <returns></returns>
        public static Image LoadImage(string imgFileName)
        {
            string file = Application.StartupPath + @"\images\" + imgFileName;
            if (File.Exists(file))
                return Image.FromFile(file);
            else
                return null;
        }

        public static Image LoadImage(string imgFileName, int iImgType)
        {

            string file;
            if (iImgType == 32) file = string.Format(Img32, Application.StartupPath, imgFileName);
            else if (iImgType == 16) file = string.Format(Img16, Application.StartupPath, imgFileName);
            else return null;
            if (File.Exists(file))
                return Image.FromFile(file);
            else
                return null;
        }

        /// <summary>
        /// 加载Debug\Images目录下的的图片
        /// </summary>
        /// <param name="imgFileName">文件名</param>
        /// <returns></returns>
        public static Bitmap LoadBitmap(string imgFileName)
        {
            string file = Application.StartupPath + @"\images\" + imgFileName;

            if (File.Exists(file))
                return new Bitmap(Bitmap.FromFile(file));
            else
                return null;
        }
    }
}
