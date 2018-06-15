/*************************************************************************************
    * 类 名 称：       DevSummary
    * 命名空间：       YIEternalMIS.Library
    * 文 件 名：       DevSummary
    * 创建时间：       2017/6/27 13:22:29
    * 作    者：        王宏巍
    * 说   明：
    * 修改时间：
    * 修 改 人：
*************************************************************************************/
using System;
using System.Collections.Generic;
using System.Text;
using DevExpress.XtraGrid.Views.Grid;
using YIEternalMIS.Common;
using YIEternalMIS.Interfaces;


namespace YIEternalMIS.Library
{
    public class DevSummary : ISummaryView
    {
        
        private GridView _view;

        /// <summary>
        /// 构造器
        /// </summary>
        /// <param name="view">GridView控件</param>
        public DevSummary(GridView view)
        {
            _view = view;
        }

        #region ISummaryView Members

        /// <summary>
        /// GridView控件
        /// </summary>
        public object View { get { return _view; } }


        /// <summary>
        /// 记录数
        /// </summary>
        public int RowCount
        {
            get { return _view.RowCount; }
        }

        /// <summary>
        /// 当前选中的资料行
        /// </summary>
        public int FocusedRowHandle
        {
            get
            {
                return _view.FocusedRowHandle;
            }
            set
            {
                _view.FocusedRowHandle = value;
            }
        }

        /// <summary>
        /// 数据源
        /// </summary>
        public object DataSource
        {
            get
            {
                return _view.GridControl.DataSource;
            }
            set
            {
                _view.GridControl.DataSource = null;
                _view.GridControl.DataSource = value;
            }
        }

        /// <summary>
        /// 获取指定资料行
        /// </summary>
        /// <param name="rowHandle">资料行索引</param>
        /// <returns></returns>
        public System.Data.DataRow GetDataRow(int rowHandle)
        {
            return _view.GetDataRow(rowHandle);
        }

        /// <summary>
        /// 刷新数据源，重新显示数据
        /// </summary>
        public void RefreshDataSource()
        {
            _view.GridControl.RefreshDataSource();
        }

        public void MoveFirst()
        {
            _view.MoveFirst();
        }

        public void MovePrior()
        {
            _view.MovePrev();
        }

        public void MoveNext()
        {
            _view.MoveNext();
        }

        public void MoveLast()
        {
            _view.MoveLast();
        }

        public void SetFocus()
        {
            if (_view.GridControl.CanFocus)
                _view.GridControl.Focus();
        }

        public void BindingDoubleClick(EventHandler eventHandler)
        {
            _view.DoubleClick += new EventHandler(eventHandler);
        }

        /// <summary>
        /// 资料行索引是否有效
        /// </summary>
        /// <param name="rowHandle">资料行索引</param>
        /// <returns></returns>
        public bool IsValidRowHandle(int rowHandle)
        {
            return _view.IsValidRowHandle(rowHandle);
        }

        /// <summary>
        /// 刷新资料行的数据
        /// </summary>
        /// <param name="rowHandle">资料行索引</param>
        public void RefreshRow(int rowHandle)
        {
            _view.RefreshRow(rowHandle);
        }
        #endregion
    }
}
