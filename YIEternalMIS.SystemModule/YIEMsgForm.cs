using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using YIEternalMIS.Common;
using YIEternalMIS.Interfaces;
using YIEternalMIS.Library;

namespace YIEternalMIS.SystemModule
{
    public partial class YIEMsgForm : YIEternalMIS.Base.BaseForm
    {
        private ISummaryView SummaryView;
        public YIEMsgForm()
        {
            InitializeComponent();
            FormInitial();
            
        }

        void FormInitial()
        {
            //注册窗口空间和事件
            SummaryView = new DevSummary(gridView1);
            DataSearch.UserInit();
            DataSearch.SearchDate += new EventHandler(DataSearch_SearchDate);
            DataSearch.ADD_Clicked += new EventHandler(DataSearch_ADD_Clicked);
            DataSearch.Edit_Clicked += new EventHandler(DataSearch_Edit_Clicked);
            DataSearch.Delete_Clicked += new EventHandler(DataSearch_Delete_Clicked);
            //设置样式
            DevStyle.SetDetailGridViewLayout(gridView1);
            DevStyle.SetGridControlLayout(gridControl1, false);
            DevStyle.DrawRowIndicator(gridView1, 40);
            frmGridCustomize.RegisterGrid(gridView1);
        }

        /// <summary>
        /// 删除按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void DataSearch_Delete_Clicked(object sender, EventArgs e)
        {
            Msg.ShowInformation("添加");
        }

        /// <summary>
        /// 修改按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void DataSearch_Edit_Clicked(object sender, EventArgs e)
        {
            Msg.ShowInformation("修改");
        }

        /// <summary>
        /// 新增按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void DataSearch_ADD_Clicked(object sender, EventArgs e)
        {
            Msg.ShowInformation("删除");
        }

        void DataSearch_SearchDate(object sender, EventArgs e)
        {
            DateTime ldts, ldte;
            ldts = DataSearch.Sdate;
            ldte = DataSearch.Edate;
            SearchData(ldts, ldte);
        }
        /// <summary>
        /// 查询数据
        /// </summary>
        /// <param name="sdate"></param>
        /// <param name="Edate"></param>
        void SearchData(DateTime sdate, DateTime Edate)
        {
            IDataGridControlPage IDataPage = new BLL.YIESystemMSG();
            string sWhere ;
            sWhere = "MsgRelease >= '" + sdate.ToString() + "' AND MsgRelease <= '" + Edate.ToString() + "'";


            OnPages.SearchData(gridControl1, IDataPage, sWhere, "");

        }

        void  DateSearch_CloseParent(object sender, EventArgs e)
        {
            FormClose();
        }
        /// <summary>
        /// 关闭窗口
        /// </summary>
        void FormClose()
        {
            this.Close();
        }

        private void DataSearch_Load(object sender, EventArgs e)
        {
           

        }
        private void OnPages_Load(object sender, EventArgs e)
        {

        }
    }
}
