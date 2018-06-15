/*************************************************************************************
     * 类 名 称：       ILoginAuth
     * 命名空间：       YIEternalMIS.Interfaces
     * 文 件 名：       ILoginAuth
     * 创建时间：       2017/6/8 10:24:37
     * 作    者：        王宏巍
     * 说   明：
     * 修改时间：
     * 修 改 人：
 *************************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace YIEternalMIS.Interfaces
{
    public interface ILoginAuth
    {
        /// <summary>
        /// 获得数据列表
        /// </summary>
         DataSet GetAllList();


        /// <summary>
        /// 获得数据列表
        /// </summary>
         DataSet GetList(string strWhere);

        /// <summary>
        /// 获得前几行数据
        /// </summary>
         DataSet GetList(int Top, string strWhere, string filedOrder);

        /// <summary>
        /// 获取子系统
        /// </summary>
        /// <param name="strWhere"></param>
        /// <returns></returns>
         DataSet GetGroupDt(string strWhere);
    }

}
