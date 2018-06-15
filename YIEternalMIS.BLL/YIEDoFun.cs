/*************************************************************************************
    * 类 名 称：       YIEDoFun
    * 命名空间：       YIEternalMIS.BLL
    * 文 件 名：       YIEDoFun
    * 创建时间：       2017/6/7 11:16:29
    * 作    者：        王宏巍
    * 说   明：        获取
    * 修改时间：
    * 修 改 人：
*************************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YIEternalMIS.BLL
{
    public static class YIEDoFun
    {
        /// <summary>
        /// 获取服务器时间
        /// </summary>
        /// <returns></returns>
        public static DateTime DoGetServerDateTime()
        {
            return new YIESysRegister().GetServerDateTime();
        }
    }
}
