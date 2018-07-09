using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppService;
using DevExpress.XtraGrid.Columns;
using Utils;
using WeightManage.AppService;
using WeightManage.Models.Db;
using WeightManage.Module.Views.Product;
using YIEternalMIS.Base;
using YIEternalMIS.Common;

namespace WeightManage.Module.Views
{
    public partial class ProductForm : BaseForm
    {
        public ProductForm()
        {
            InitializeComponent();
            SetFilter(gridView1);
        }
        BindingList<Products> _productGridList = new BindingList<Products>();
        private ProductAppService _productApp=new ProductAppService();
        private void ProductForm_Load(object sender, EventArgs e)
        {
            InitGrid();
        }


        public void InitGrid()
        {
            var data = _productApp.GetProductList(1, 100);
            _productGridList = new BindingList<Products>(data);
            gridControl1.DataSource = _productGridList;
        }
        /// <summary>  
        /// 设置girid为每一列都模糊搜索  
        /// </summary>  
        /// <param name="gdv"></param>  
        public static void SetFilter(DevExpress.XtraGrid.Views.Grid.GridView gdv)
        {
           // gdv.OptionsView.ShowAutoFilterRow = true;
            //gdv.OptionsFilter.AllowMultiSelectInCheckedFilterPopup = true;  
            foreach (DevExpress.XtraGrid.Columns.GridColumn item in gdv.Columns)
            {
                item.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;   //筛选条件设置为包含    
                item.OptionsFilter.FilterPopupMode = FilterPopupMode.CheckedList;//设置为过滤是可以多选  
            }
        }
        private void btnQuery_Click(object sender, EventArgs e)
        {
            var pname = txtProductName.Text.Trim();
            var pno = txtProductNo.Text.Trim();
            Msg.ShowInformation("直接在列表中查询");
           // _productGridList = _productGridList.Where(s => s.productName.Contains(pname));
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
           var ret= ProductEditForm.ShowForm(new Products());
            if (ret)
            {
               
                Msg.ShowInformation("添加成功");
                InitGrid();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            var rows = this.gridView1.GetSelectedRows();
            if (rows.Length == 1)
            {
                var model = (Products)gridView1.GetFocusedRow();
                //Msg.ShowInformation(model.productName);
                var ret = ProductEditForm.ShowForm(model);
                if (ret)
                {
                    Msg.ShowInformation("修改成功");
                    InitGrid();
                }
            }
            else
            {
                Msg.Warning("请选择一条需要修改的数据行");
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            var rows = this.gridView1.GetSelectedRows();
            if (rows.Length ==0)
            {
                Msg.Warning("请选择需要删除的数据行");
      
            }
            else
            {
                // var model = (Products)gridView1.GetFocusedRow();
                if (Msg.AskQuestion("确定删除？"))
                {
                    int selRow = gridView1.FocusedRowHandle;
                    string Id = gridView1.GetRowCellValue(selRow, "productId").ToString();
                    var ret = _productApp.DelById(Id.ToInt());
                    if (ret)
                    {
                        Msg.ShowInformation("删除成功");
                        //GridView view = sender as GridView;
                        //view.DeleteRow(view.FocusedRowHandle);

                        gridView1.DeleteRow(selRow);
                    }
                    else
                    {
                        Msg.ShowError("删除失败");
                    }
                }
                
                
            }
        }


        /// <summary>
        /// 双击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gridView1_MouseDown(object sender, MouseEventArgs e)
        {
            DevExpress.XtraGrid.Views.Grid.ViewInfo.GridHitInfo hInfo = gridView1.CalcHitInfo(new Point(e.X, e.Y));
            if (e.Button == MouseButtons.Left && e.Clicks == 2)
            {
                //判断光标是否在行范围内  
                if (hInfo.InRow)
                {
                    //取得选定行信息  
                    // string nodeName = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "nodeName").ToString();

                    var model =(Products)gridView1.GetFocusedRow();
                    var ret = ProductEditForm.ShowForm(model);
                    if (ret)
                    {
                        Msg.ShowInformation("修改成功");
                    }
                   
                }
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            InitGrid();
        }
    }
}
