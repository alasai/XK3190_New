/*************************************************************************************
     * 类 名 称：       ISummaryView
     * 命名空间：       YIEternalMIS.Interfaces
     * 文 件 名：       ISummaryView
     * 创建时间：       2017/6/2 13:49:25
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
    public interface ISummaryView
    {
        /// <summary>
        /// 记录数
        /// </summary>
        int RowCount { get; }

        /// <summary>
        /// 当前选中的资料行
        /// </summary>
        int FocusedRowHandle { get; set; }

        /// <summary>
        /// 数据源
        /// </summary>
        object DataSource { get; set; }

        /// <summary>
        /// 关联的视图对象(如DataGridView,GridView,TreeView)
        /// </summary>
        object View { get; }

        /// <summary>
        /// 获取指定资料行
        /// </summary>
        /// <param name="rowHandle">资料行索引</param>
        /// <returns></returns>
        DataRow GetDataRow(int rowHandle);

        /// <summary>
        /// 刷新数据源，重新显示数据
        /// </summary>
        void RefreshDataSource();

        /// <summary>
        /// 绑定双击事件
        /// </summary>
        /// <param name="eventHandler">事件</param>
        void BindingDoubleClick(EventHandler eventHandler);

        /// <summary>
        /// 设置焦点
        /// </summary>
        void SetFocus();

        /// <summary>
        /// 移动到第一条记录
        /// </summary>
        void MoveFirst();

        /// <summary>
        /// 移动到前一条记录
        /// </summary>
        void MovePrior();

        /// <summary>
        /// 移动到下一条记录
        /// </summary>
        void MoveNext();

        /// <summary>
        /// 移动到最后一条记录
        /// </summary>
        void MoveLast();

        /// <summary>
        /// 资料行索引是否有效
        /// </summary>
        /// <param name="rowHandle">资料行索引</param>
        /// <returns></returns>
        bool IsValidRowHandle(int rowHandle);

        /// <summary>
        /// 刷新资料行的数据
        /// </summary>
        /// <param name="rowHandle">资料行索引</param>
        void RefreshRow(int rowHandle);

    }
}
