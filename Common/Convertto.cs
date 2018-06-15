/*************************************************************************************
    * 类 名 称：       Convertto
    * 命名空间：       Common
    * 文 件 名：       Convertto
    * 创建时间：       2017/6/2 9:20:34
    * 作    者：        王宏巍
    * 说   明：        对象转换工具
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

namespace YIEternalMIS.Common
{

    /// <summary>    
    ///数据转换器, 实际封装.Net的Convert对象.
    /// </summary>
    public class Convertto
    {
        /// <summary>
        /// 将日期转换为指定格式的字符串
        /// </summary>
        /// <param name="dt">日期</param>
        /// <param name="format">日期格式, 如: yyyy-MM-dd</param>
        /// <returns>返回字符串类型</returns>
        public static string ToDateString(DateTime dt, string format)
        {
            return dt.ToString(format, DateTimeFormatInfo.CurrentInfo);
        }

        /// <summary>
        /// 将日期转换为年/月/日格式的字符串
        /// </summary>
        /// <param name="dt">日期</param>
        /// <returns>返回字符串类型</returns>
        public static string ToCharYYYYMMDDLong(DateTime dt)
        {
            return dt.ToString("yyyy/MM/dd", DateTimeFormatInfo.CurrentInfo);
        }

        /// <summary>
        /// 将日期转换为年月(YYMM)格式的字符串
        /// </summary>
        /// <param name="dt">日期</param>
        /// <returns>返回字符串类型</returns>
        public static string ToCharYYMM(DateTime dt)
        {
            return dt.ToString("yyMM", DateTimeFormatInfo.CurrentInfo);
        }

        /// <summary>
        /// 将日期转换为年(YY)格式的字符串
        /// </summary>
        /// <param name="dt">日期</param>
        /// <returns>返回字符串类型</returns>
        public static string ToCharYY(DateTime dt)
        {
            return dt.ToString("yy", DateTimeFormatInfo.CurrentInfo);
        }

        /// <summary>
        /// 将日期转换为年(YYYY)格式的字符串
        /// </summary>
        /// <param name="dt">日期</param>
        /// <returns>返回字符串类型</returns>
        public static string ToCharYYYY(DateTime dt)
        {
            return dt.ToString("yyyy", DateTimeFormatInfo.CurrentInfo);
        }


        /// <summary>
        /// 将日期转换为年月(YYYYMM)格式的字符串
        /// </summary>
        /// <param name="dt">日期</param>
        /// <returns>返回字符串类型</returns>
        public static string ToCharYYYYMM(DateTime dt)
        {
            return dt.ToString("yyyyMM", DateTimeFormatInfo.CurrentInfo);
        }

        /// <summary>
        /// 将日期转换为年月日(YYYYMMDD)格式的字符串，当日期为系统最小日期否返回空字符串
        /// </summary>
        /// <param name="dt">日期</param>
        /// <returns>返回字符串类型</returns>
        public static string ToCharYYYYMMDD(DateTime dt)
        {
            string temp = dt.ToString("yyyyMMdd", DateTimeFormatInfo.CurrentInfo);
            if (temp == "00010101") temp = "";
            return temp;
        }

        /// <summary>
        /// 将日期转换为年月日时分秒(YYYYMMDDHHMMSS)格式的字符串
        /// </summary>
        /// <param name="dt">日期</param>
        /// <returns>返回字符串类型</returns>
        public static string ToCharYYYYMMDDHHMMSS(DateTime dt)
        {
            return dt.ToString("yyyyMMddHHmmss", DateTimeFormatInfo.CurrentInfo);
        }

        /// <summary>
        /// 将日期转换为日/月/年 时:分:秒(DD/MM/YYYY HH:MM:SS)格式的字符串
        /// </summary>
        /// <param name="dt">日期</param>
        /// <returns>返回字符串类型</returns>
        public static string ToCharDD_MM_YYYY_HHMMSS(DateTime dt)
        {
            return dt.ToString("dd/MM/yyyy HH:mm:ss", DateTimeFormatInfo.CurrentInfo);
        }

        /// <summary>
        /// 将日期转换为年/月/日 时:分:秒(YYYY/MM/DD HH:MM:SS)格式的字符串
        /// </summary>
        /// <param name="dt">日期</param>
        /// <returns>返回字符串类型</returns>
        public static string ToCharYYYY_MM_DD_HHMMSS(DateTime dt)
        {
            return dt.ToString("yyyy/MM/dd HH:mm:ss", DateTimeFormatInfo.CurrentInfo);
        }

        /// <summary>
        /// 将日期转换为年月日 时:分:秒(YYYYMMDD HH:MM:SS)格式的字符串
        /// </summary>
        /// <param name="dt">日期</param>
        /// <returns>返回字符串类型</returns>
        public static string ToCharYYYYMMDDHHMMSS000(DateTime dt)
        {
            return dt.ToString("yyyyMMdd HH:mm:ss:000", DateTimeFormatInfo.CurrentInfo);
        }

        /// <summary>
        /// 将日期转换为年月日(YYMMDD)格式的字符串
        /// </summary>
        /// <param name="dt">日期</param>
        /// <returns>返回字符串类型</returns>
        public static string ToCharYYMMDD(DateTime dt)
        {
            return dt.ToString("yyMMdd", DateTimeFormatInfo.CurrentInfo);
        }

        /// <summary>
        /// 转换为Boolean类型
        /// </summary>
        /// <param name="o">必须是可转换为Boolean类型的字符串如"True","False",或其它特殊对象</param>
        /// <returns>返回bool类型</returns>
        public static bool ToBoolean(object o)
        {
            if (null == o) return false;
            try
            {
                return Convert.ToBoolean(o.ToString());
            }
            catch { return false; }
        }

        /// <summary>
        /// 转换为浮点类型
        /// </summary>
        /// <param name="o"></param>
        /// <returns></returns>
        public static float ToFloat(object o)
        {
            if (null == o) return 0;
            try
            {
                return (float)Convert.ToDouble(o.ToString());
            }
            catch { return 0; }
        }

        /// <summary>
        /// 转换为decimal类型(有效十进制数)
        /// </summary>
        /// <param name="o"></param>
        /// <returns></returns>
        public static decimal ToDecimal(object o)
        {
            if (null == o) return 0;
            try
            {
                return Convert.ToDecimal(o.ToString());
            }
            catch { return 0; }
        }

        /// <summary>
        /// 四舍五入
        /// </summary>
        /// <param name="d"></param>
        /// <returns></returns>
        public static object ToDecimalFormat(decimal d)
        {

            return (object)(decimal.Round(d, Globals.DEF_DECIMAL_ROUND).ToString(Globals.DEF_DECIMAL_FORMAT));
        }

        /// <summary>
        /// 转换为日期对象
        /// </summary>
        /// <param name="o">日期对象(泛型)，如为空的字段数据DBNull.NULL</param>
        /// <returns></returns>
        public static DateTime ToDateTime(DateTime? o)
        {
            if (null == o) return DateTime.MinValue;
            try
            {
                return DateTime.Parse(o.ToString());
            }
            catch { return DateTime.MinValue; }
        }

        /// <summary>
        /// 转换日期字符串. 对象为空则返回'null'字符串(无单引号). 
        /// 用于动态组合SQL字符串.
        /// </summary>
        /// <param name="o">日期对象</param>
        /// <param name="dateFormat">日期格式</param>
        /// <param name="quotationMark">返回的日期字符串是否打上单引号</param>        
        public static string ToDateTimeString(object o, string dateFormat, bool quotationMark)
        {
            try
            {
                DateTime? dateGenType = ToDateTime(o);
                string datestr = string.Empty;
                if (dateGenType == null)
                    return "null";
                else
                {
                    DateTime dt = DateTime.Parse(dateGenType.ToString());
                    datestr = dt.ToString(dateFormat, DateTimeFormatInfo.CurrentInfo);
                }
                if (quotationMark)
                    return "'" + datestr + "'";
                else
                    return datestr;
            }
            catch
            {
                return "null";
            }
        }

        public static DateTime ToNotNULLDateTime(object o )
        {
           return ToDateTime(ToDateTime(o));
        }
        /// <summary>
        /// 转换为日期对象
        /// </summary>
        /// <param name="o"></param>
        /// <returns></returns>
        public static DateTime? ToDateTime(object o)
        {
            if (null == o) return null;
            try
            {
                return Convert.ToDateTime(o.ToString());
            }
            catch { return null; }
        }

        /// <summary>
        /// 转换为整数
        /// </summary>
        /// <param name="o"></param>
        /// <returns></returns>
        public static int ToInt(object o)
        {
            if (null == o) return 0;
            try
            {
                return Convert.ToInt32(o.ToString());
            }
            catch { return 0; }
        }

        /// <summary>
        /// 转换为字符串
        /// </summary>
        /// <param name="obj">当对象为空，返回string.Empty</param>
        /// <returns></returns>
        public static string ToString(object obj)
        {
            if (obj == null) return string.Empty;
            return obj.ToString().Trim();
        }
    }
}
