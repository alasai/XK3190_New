/*************************************************************************************
     * 类 名 称：       IDataGridControlPage
     * 命名空间：       YIEternalMIS.Interfaces
     * 文 件 名：       IDataGridControlPage
     * 创建时间：       2017/6/26 8:41:49
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
    public interface IDataGridControlPage
    {

        /// <summary>
        /// 获取记录条数
        /// </summary>
        /// <param name="strWhere">查询条件</param>
        /// <returns></returns>
        int GetRecordCount(string strWhere);
        /// <summary>
        /// 获取分页数据
        /// </summary>
        /// <param name="strWhere">查询条件</param>
        /// <param name="orderby">排序列名</param>
        /// <param name="startIndex">开始条数</param>
        /// <param name="endIndex">结束条数</param>
        /// <returns></returns>
        DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex);
    }
}
