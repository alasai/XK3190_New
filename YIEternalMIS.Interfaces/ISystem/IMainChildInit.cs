/*************************************************************************************
     * 类 名 称：       IMainChildInit
     * 命名空间：       YIEternalMIS.Interfaces
     * 文 件 名：       IMainChildInit
     * 创建时间：       2017/6/21 14:21:07
     * 作    者：        王宏巍
     * 说   明：
     * 修改时间：
     * 修 改 人：
 *************************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.XtraNavBar;

namespace YIEternalMIS.Interfaces
{
    public interface IMainChildInit
    {
        /// <summary>
        /// 初始化待办事项
        /// </summary>
        /// <param name="obj"></param>
        void InitNavbusiness(object obj);

        /// <summary>
        /// 初始化公告
        /// </summary>
        /// <param name="obj"></param>
        void InitNavMessage(object obj);

        /// <summary>
        /// 初始化统计查询
        /// </summary>
        /// <param name="obj"></param>
        void InitNavSearch(object obj);
    }
}
