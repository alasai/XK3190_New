/*************************************************************************************
    * 类 名 称：       MyDateTimeHelper
    * 命名空间：       YIEternalMIS.Common
    * 文 件 名：       MyDateTimeHelper
    * 创建时间：       2017/6/19 11:17:13
    * 作    者：        王宏巍
    * 说   明：        时间操作类
    * 修改时间：
    * 修 改 人：
*************************************************************************************/
using System;
using System.Globalization;

namespace YIEternalMIS.Common
{

    /// <summary>
    /// 时间操作类
    /// </summary>
    public class MyDateTimeHelper
    {
        #region Method

        /// <summary>
        /// 哪天
        /// </summary>
        /// <param name="days">7天前:-7 7天后:+7</param>
        /// <param name="dateTime">日期时间</param>
        /// <returns>返回值</returns>
        public static string GetTheDay(int? days, DateTime dateTime)
        {
            int day = days ?? 0;
            return dateTime.AddDays(day).ToShortDateString();
        }

        /// <summary>
        /// 周日
        /// </summary>
        /// <param name="weeks">上周-1 下周+1 本周0</param>
        /// <param name="dateTime">日期时间</param>
        /// <returns>返回值</returns>
        public static string GetSunday(int? weeks, DateTime dateTime)
        {
            int week = weeks ?? 0;
            return dateTime.AddDays(Convert.ToDouble((0 - Convert.ToInt16(dateTime.DayOfWeek))) + 7 * week).ToShortDateString();
        }

        /// <summary>
        /// 周六
        /// </summary>
        /// <param name="weeks">上周-1 下周+1 本周0</param>
        /// <param name="dateTime">日期时间</param>
        /// <returns>返回值</returns>
        public static string GetSaturday(int? weeks, DateTime dateTime)
        {
            int week = weeks ?? 0;
            return dateTime.AddDays(Convert.ToDouble((6 - Convert.ToInt16(dateTime.DayOfWeek))) + 7 * week).ToShortDateString();
        }

        /// <summary>
        /// 月第一天
        /// </summary>
        /// <param name="months">上月-1 本月0 下月1</param>
        /// <param name="dateTime">日期时间</param>
        /// <returns>返回值</returns>
        public static string GetFirstDayOfMonth(int? months, DateTime dateTime)
        {
            int month = months ?? 0;
            return DateTime.Parse(DateTime.Now.ToString("yyyy-MM-01")).AddMonths(month).ToShortDateString();
        }

        /// <summary>
        /// 月最后一天
        /// </summary>
        /// <param name="months">上月0 本月1 下月2</param>
        /// <param name="dateTime">日期时间</param>
        /// <returns>返回值</returns>
        public static string GetLastDayOfMonth(int? months, DateTime dateTime)
        {
            int month = months ?? 0;
            //string ls = 
            return DateTime.Parse(dateTime.ToString("yyyy-MM-01 23:59:59")).AddMonths(month).AddDays(-1).ToString();
        }

        /// <summary>
        /// 年度第一天
        /// </summary>
        /// <param name="dateTime">日期时间</param>
        /// <returns>返回值</returns>
        public static string GetFirstDayOfYear(DateTime dateTime)
        {
            int year = Convert.ToInt32(dateTime.Year);
            return DateTime.Parse(dateTime.ToString("yyyy-01-01")).AddYears(year).ToShortDateString();
        }

        /// <summary>
        /// 年度最后一天
        /// </summary>
        /// <param name="dateTime">日期时间</param>
        /// <returns>返回值</returns>
        public static string GetLastDayOfYear(DateTime dateTime)
        {
            int year = Convert.ToInt32(dateTime.Year);
            return DateTime.Parse(dateTime.ToString("yyyy-01-01")).AddYears(year).AddDays(-1).ToShortDateString();
        }

        /// <summary>
        /// 季度第一天
        /// </summary>
        /// <param name="quarters">上季度-1 下季度+1</param>
        /// <param name="dateTime">日期时间</param>
        /// <returns>返回值</returns>
        public static string GetFirstDayOfQuarter(int? quarters, DateTime dateTime)
        {
            int quarter = quarters ?? 0;
            return dateTime.AddMonths(quarter * 3 - ((dateTime.Month - 1) % 3)).ToString("yyyy-MM-01");
        }

        /// <summary>
        /// 季度最后一天
        /// </summary>
        /// <param name="quarters">上季度0 本季度1 下季度2</param>
        /// <param name="dateTime">日期时间</param>
        /// <returns>返回值</returns>
        public static string GetLastDayOfQuarter(int? quarters, DateTime dateTime)
        {
            int quarter = quarters ?? 0;
            return
                DateTime.Parse(dateTime.AddMonths(quarter * 3 - ((dateTime.Month - 1) % 3)).ToString("yyyy-MM-01")).AddDays(-1).
                    ToShortDateString();
        }

        /// <summary>
        /// 中文星期
        /// </summary>
        /// <param name="dateTime">日期时间</param>
        /// <returns>返回值</returns>
        public static string GetDayOfWeekCN(DateTime dateTime)
        {
            var day = new[] { "星期日", "星期一", "星期二", "星期三", "星期四", "星期五", "星期六" };
            return day[Convert.ToInt16(dateTime.DayOfWeek)];
        }

        /// <summary>
        /// 获取星期数字形式,周一开始
        /// </summary>
        /// <param name="dateTime">日期时间</param>
        /// <returns>返回值</returns>
        public int GetDayOfWeekNum(DateTime dateTime)
        {
            int day = (Convert.ToInt16(dateTime.DayOfWeek) == 0) ? 7 : Convert.ToInt16(dateTime.DayOfWeek);
            return day;
        }

        /// <summary> 
        /// 取指定日期是一年中的第几周 
        /// </summary> 
        /// <param name="dtime">日期时间</param> 
        /// <returns>数字 一年中的第几周</returns> 
        public static int GetWeekofyear(DateTime dtime)
        {
            return CultureInfo.CurrentCulture.Calendar.GetWeekOfYear(dtime, CalendarWeekRule.FirstDay,
                                                                     DayOfWeek.Sunday);
        }

        /// <summary> 
        /// 取指定日期是一月中的第几天 
        /// </summary> 
        /// <param name="dtime">日期时间</param> 
        /// <returns>数字 一月中的第几天</returns> 
        public static int GetDayofmonth(DateTime dtime)
        {
            return CultureInfo.CurrentCulture.Calendar.GetDayOfMonth(dtime);
        }

        #endregion

    }
}
