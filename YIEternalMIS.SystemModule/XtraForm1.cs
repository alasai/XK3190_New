using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using YIEternalMIS.Interfaces;

namespace YIEternalMIS.SystemModule
{
    public partial class XtraForm1 : DevExpress.XtraEditors.XtraForm
    {
        public XtraForm1()
        {
            InitializeComponent();
            yieDateSearchMenu1.ADD_Clicked += new EventHandler(yieDateSearchMenu1_ADD_Clicked);
            yieDateSearchMenu1.Edit_Clicked += new EventHandler(yieDateSearchMenu1_Edit_Clicked);
            yieDateSearchMenu1.Delete_Clicked += new EventHandler(yieDateSearchMenu1_Delete_Clicked);


        }

        void yieDateSearchMenu1_Delete_Clicked(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        void yieDateSearchMenu1_Edit_Clicked(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        void yieDateSearchMenu1_ADD_Clicked(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        //void yieOnPage1_ExportALL(object sender, EventArgs e)
        //{
        //    string ls = Common.MyFileDialogHelper.Save("导出当前页", "电子表格(*.xls)|*.xls", "ExportPage.xls", "");
        //    DevExpress.XtraGrid.GridControl drall = new DevExpress.XtraGrid.GridControl();
        //    drall.DataSource = new BLL.V_YIEBtnRolePER().GetAllList().Tables[0];
        //    drall.ExportToXls(ls);
        //}

        //void yieOnPage1_ExportPage(object sender, EventArgs e)
        //{
        //    string ls = Common.MyFileDialogHelper.Save("导出当前页","电子表格(*.xls)|*.xls","ExportPage.xls","");
        //    gridControl1.ExportToXls(ls, true);
        //}

        //void yieOnPage1_OnPageChanged(object sender, EventArgs e)
        //{
        //    LoadData();
        //}


        //void LoadData()
        //{
        //    int icount;
        //    icount = new BLL.V_YIEBtnRolePER().GetRecordCount("");
        //    yieOnPage1.DoDrawControl(icount);
        //    int sPageIndex, ePageIndex;
        //    sPageIndex = (yieOnPage1.PageIndex - 1) * yieOnPage1.PageSize + 1 ;
        //    ePageIndex = (yieOnPage1.PageIndex * yieOnPage1.PageSize);
        //    gridControl1.DataSource = new BLL.V_YIEBtnRolePER().GetListByPage("", "", sPageIndex, ePageIndex ).Tables[0];
        //}

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            //IDataGridControlPage iDATA = new BLL.V_YIEBtnRolePER();
            //string swhere, sorder;
            //swhere = "";
            //sorder = "";
            //yieOnPage1.SearchData(gridControl1, iDATA, swhere, sorder);
            
        }
    }
}