using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using YIEternalMIS.BLL;
using YIEternalMIS.Common;

namespace YIEternalMIS.Library
{
    public partial class YIEDateSearch : DevExpress.XtraEditors.XtraUserControl
    {

        //定义关闭事件
        public event EventHandler CloseParent;
        //定义查询事件
        public event EventHandler SearchDate;
        //定义查询参数 
        private DateTime _Sdate, _Edate;

        /// <summary>
        /// 开始时间
        /// </summary>
        public DateTime Sdate { get { return _Sdate; } set { _Sdate = value; } }

        /// <summary>
        /// 结束时间
        /// </summary>
        public DateTime Edate { get { return _Edate; } set { _Edate = value; } }

        public YIEDateSearch()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 初始化查询窗口
        /// </summary>
        public  void UserInit()
        {
            sdate.DateTime = Convertto.ToNotNULLDateTime(MyDateTimeHelper.GetFirstDayOfMonth(0, YIEDoFun.DoGetServerDateTime()));
            edate.DateTime = Convertto.ToNotNULLDateTime( MyDateTimeHelper.GetLastDayOfMonth(1, YIEDoFun.DoGetServerDateTime()));

            btnClose.Click += new EventHandler(btnClose_Click);
        }

        public virtual void btnClose_Click(object sender, EventArgs e)
        {
            if (CloseParent != null)
            {
                CloseParent(sender, e);
            }
        }



        
        public virtual void btnSearch_Click(object sender, EventArgs e)
        {
            if (SearchDate == null) return;
            Sdate = sdate.DateTime;
            Edate = edate.DateTime;

            if (Sdate > Edate)
            {
                Msg.ShowInformation("结束时间不能小于开始时间!!");
                return;
            }
            SearchDate(sender, e);
                
        }
    }
}
