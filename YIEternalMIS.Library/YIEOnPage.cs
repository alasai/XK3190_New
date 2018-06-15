using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using YIEternalMIS.Interfaces;
using YIEternalMIS.Common;

namespace YIEternalMIS.Library
{
    public partial class YIEOnPage : DevExpress.XtraEditors.XtraUserControl
    {

        
        public YIEOnPage()
        {
            InitializeComponent();
            OnPageCount.SelectedItem = 0;
            PageSize = 20;
        }
        /// <summary>
        /// 页面变化
        /// </summary>
        public event EventHandler OnPageChanged;

        /// <summary>
        /// 外部不调用，如果为TRUE 数据源在内部
        /// </summary>
        public static bool UserData = false;
        /// <summary>
        /// 导出当前页
        /// </summary>
        public event EventHandler ExportPage;


        /// <summary>
        /// 导出所有页
        /// </summary>
        public event EventHandler ExportALL;

        #region 分页字段和属性

        private int pageIndex = 1;
        /// <summary>
        /// 当前页面
        /// </summary>
        public virtual int PageIndex
        {
            get { return pageIndex; }
            set { pageIndex = value; }
        }

        private int pageSize = 100;
        /// <summary>
        /// 每页记录数
        /// </summary>
        public virtual int PageSize
        {
            get { return pageSize; }
            set { pageSize = value; }
        }

        private int recordCount = 0;
        /// <summary>
        /// 总记录数
        /// </summary>
        public virtual int RecordCount
        {
            get { return recordCount; }
            set { recordCount = value; }
        }

        private int pageCount = 0;
        /// <summary>
        /// 总页数
        /// </summary>
        public int PageCount
        {
            get
            {
                if (pageSize != 0)
                {
                    pageCount = GetPageCount();
                }
                return pageCount;
            }
        }


        DevExpress.XtraGrid.GridControl _xGridControl;
        /// <summary>
        /// 控件数据源，初始化查询时候赋值
        /// </summary>
        private DevExpress.XtraGrid.GridControl xGridControl
        {
            get { return _xGridControl; }
            set { _xGridControl = value; }
        }

        private IDataGridControlPage _IDataPage;

        /// <summary>
        /// 数据源接口
        /// </summary>
        private IDataGridControlPage IDataPage
        {
            get { return _IDataPage; }
            set { _IDataPage = value; }
        }

        string _strWhere;
        /// <summary>
        /// 查询条件
        /// </summary>
        private string strWhere 
        {
            get { return _strWhere; }
            set { _strWhere = value; }
        }

        string _strOrder;
        /// <summary>
        /// 排序条件
        /// </summary>
        private string strOrder
        {
            get { return _strOrder; }
            set { _strOrder = value; }
        }
        #endregion

        /// <summary>
        /// 获取页数
        /// </summary>
        /// <returns>总页数</returns>
        private int GetPageCount()
        {
            if (PageSize == 0)
            {
                return 0;
            }
            int pageCount = RecordCount / PageSize;
            if (RecordCount % PageSize == 0)
            {
                pageCount = RecordCount / PageSize;
            }
            else
            {
                pageCount = RecordCount / PageSize + 1;
            }
            return pageCount;
        }


        /// <summary>
        /// 外部调用
        /// </summary>
        /// <param name="iCounts">记录总数</param>
        public void DoDrawControl( int iCounts)
        {
            RecordCount = iCounts;
            DoDrawControl(false);
        }

        /// <summary>
        /// 页面变化
        /// </summary>
        /// <param name="callEvent"></param>
        private void DoDrawControl( bool callEvent)
        {
            tPages.Text = PageIndex.ToString();
            tPageCount.Text = PageCount.ToString();
            tCounts.Text = RecordCount.ToString();
            if(UserData && callEvent)
            {
                LoadData();
                SetButtonEnabled();
                return;
            }
            if (callEvent && OnPageChanged != null)
            {
                OnPageChanged(this, null);//当前分页数字改变时，触发委托事件
            }
            
            SetButtonEnabled();
        }


        /// <summary>
        /// 设置按钮状态
        /// </summary>
        void SetButtonEnabled()
        {
            toPages.Text = pageIndex.ToString();
            //只有一页
            if(PageCount <= 1 )
            {
                btnFirstPage.Enabled = false;
                btnUpPage.Enabled = false;
                btnNextPage.Enabled = false;
                btnLastPage.Enabled = false;
                btnToPage.Enabled = false;
            }
            else if(PageIndex == 1 )
            {
                btnFirstPage.Enabled = false;
                btnUpPage.Enabled = false;
                btnNextPage.Enabled = true;
                btnLastPage.Enabled = true;
                btnToPage.Enabled = true;

            }
            else if( PageIndex == PageCount)
            {
                btnFirstPage.Enabled = true;
                btnUpPage.Enabled = true;
                btnNextPage.Enabled = false;
                btnLastPage.Enabled = false;
                btnToPage.Enabled = true;
            }
            else
            {
                btnFirstPage.Enabled = true;
                btnUpPage.Enabled = true;
                btnNextPage.Enabled = true;
                btnLastPage.Enabled = true;
                btnToPage.Enabled = true;
            }
        }

        /// <summary>
        /// 第一页
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFirstPage_Click(object sender, EventArgs e)
        {
            PageIndex = 1;
            DoDrawControl(true);
        }
        /// <summary>
        /// 上一页
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpPage_Click(object sender, EventArgs e)
        {
            PageIndex = Math.Max(1, PageIndex - 1);
            DoDrawControl(true);
        }
        /// <summary>
        /// 下一页
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNextPage_Click(object sender, EventArgs e)
        {
            PageIndex = Math.Min(PageCount, PageIndex + 1);
            DoDrawControl(true);
        }
        /// <summary>
        /// 最后一页
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLastPage_Click(object sender, EventArgs e)
        {
            PageIndex = PageCount;
            DoDrawControl(true);
        }
        /// <summary>
        /// 跳转
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnToPage_Click(object sender, EventArgs e)
        {
            int num = 0;
            if (int.TryParse(toPages.Text.Trim(), out num) && num > 0)
            {
                PageIndex = num;
                DoDrawControl(true);
            }
        }
        /// <summary>
        /// 导出当前页
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExportPage_Click(object sender, EventArgs e)
        {
            if(UserData)
            {
                ExportToXls(false);
                return;
            }
            if(ExportPage != null)
                 ExportPage(this, null);
        }
        /// <summary>
        /// 导出所有页
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExportAll_Click(object sender, EventArgs e)
        {
            if (!Msg.AskQuestion("导出全部页数据量较大，需要时间较长!，是否继续导出？")) return;
            if (UserData)
            {
                ExportToXls(true);
                return;
            }
            if (ExportALL != null)
            {
                ExportALL(this, null);
            }
        }

        /// <summary>
        /// 添加跳转页数
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toPages_TextChanged(object sender, EventArgs e)
        {
            int num = 0;
            if (int.TryParse(toPages.Text.Trim(), out num) && num > 0)
            {
                if (num > PageCount)
                {
                    toPages.Text = PageCount.ToString();
                }
            }
        }


        private void OnPageCount_EditValueChanged(object sender, EventArgs e)
        {
            
        }

        private void OnPageCount_Enter(object sender, EventArgs e)
        {
            
        }

        /// <summary>
        /// 修改每页显示离开焦点触发
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnPageCount_Leave(object sender, EventArgs e)
        {
            int num = 0;
            num = Convertto.ToInt(OnPageCount.Text);
            if (num == PageSize) return;
            pageSize = num;
            btnFirstPage_Click(sender, e);
        }

        /// <summary>
        /// 数据源在内部，采用接口方式，外部的GRIDCONTROL通过内部赋值
        /// </summary>
        /// <param name="xtrGridControl">显示的GridControl</param>
        /// <param name="IDataPage">数据源接口</param>
        /// <param name="sWhere">查询条件</param>
        /// <param name="sOrder">排序列名</param>
        public void SearchData(DevExpress.XtraGrid.GridControl xtrGridControl, IDataGridControlPage IDataPages, string sWhere, string sOrder)
        {
            int isPage, iePage, ipageCount;
            UserData = true;
            strOrder = sOrder;
            xGridControl = xtrGridControl;
            IDataPage = IDataPages;
            strWhere = sWhere;

            isPage = (PageIndex - 1) * PageSize + 1;
            iePage = PageIndex * PageSize;
            if(IDataPage ==null) 
            {
                Msg.ShowError("没有给赋数据源！！");
                return;
            }
            ipageCount = IDataPage.GetRecordCount(sWhere);
            DoDrawControl(ipageCount);
            if (ipageCount <= 0)
            {
                
                Msg.ShowInformation("没有数据!!!");

                return;
            }

            xtrGridControl.DataSource = IDataPage.GetListByPage(sWhere, sOrder, isPage, iePage).Tables[0];

           
        }
        private void LoadData()
        {
            int isPage, iePage, ipageCount;
            isPage = (PageIndex - 1) * PageSize + 1;
            iePage = PageIndex * PageSize;
            if (IDataPage == null)
            {
                Msg.ShowError("没有给赋数据源！！");
                return;
            }
            ipageCount = IDataPage.GetRecordCount(strWhere);
            DoDrawControl(ipageCount);
            if (ipageCount <= 0)
            {

                Msg.ShowInformation("没有数据!!!");

                return;
            }

            xGridControl.DataSource = IDataPage.GetListByPage(strWhere, strOrder, isPage, iePage).Tables[0];
        }

        private void OnPageCount_SelectedIndexChanged(object sender, EventArgs e)
        {
            toPages.Focus();
        }

        private void ExportToXls( bool bAll )
        {
            if (!UserData) return;
            if(bAll)
            {
                xGridControl.DataSource = IDataPage.GetListByPage(strWhere, strOrder, 1, IDataPage.GetRecordCount(strWhere)).Tables[0];
                
            }
            string sPach;
            sPach = SaveAS();
            if (Common.StringISNULL.Isnull(sPach, "") == "") return;
            xGridControl.ExportToXls(sPach);
        }


        string SaveAS()
        {
            return Common.MyFileDialogHelper.Save("导出当前页", "电子表格(*.xls)|*.xls", "ExportPage.xls", "");
        }
    }
}
