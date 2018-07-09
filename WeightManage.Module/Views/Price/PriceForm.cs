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
using WeightManage.Module.Views.Price;
using YIEternalMIS.Base;
using YIEternalMIS.Common;

namespace WeightManage.Module.Views
{
    public partial class PriceForm : BaseForm
    {
        public PriceForm()
        {
            InitializeComponent();
            SetFilter(gridView1);
        }


        private PriceAppService _priceApp=new PriceAppService();
        BindingList<AnimalTypes>_dataGridList = new BindingList<AnimalTypes>();
        private void PriceForm_Load(object sender, EventArgs e)
        {
            InitGrid();
        }

        private void InitGrid()
        {
            var data = _priceApp.GetPriceList();
            _dataGridList = new BindingList<AnimalTypes>(data);
            gridControl1.DataSource = _dataGridList;
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
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            InitGrid();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (PriceEditForm.ShowForm(new AnimalTypes()))
            {
                InitGrid();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            var rows = this.gridView1.GetSelectedRows();
            if (rows.Length == 1)
            {
                var model = (AnimalTypes)gridView1.GetFocusedRow();
                //Msg.ShowInformation(model.productName);
                var ret = PriceEditForm.ShowForm(model);
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
            if (rows.Length == 0)
            {
                Msg.Warning("请选择需要删除的数据行");

            }
            else
            {
                // var model = (Products)gridView1.GetFocusedRow();
                if (Msg.AskQuestion("确定删除？"))
                {
                    int selRow = gridView1.FocusedRowHandle;
                    string Id = gridView1.GetRowCellValue(selRow, "animalTypeId").ToString();
                    var ret = _priceApp.DelById(Id.ToInt());
                    if (ret)
                    {
                        Msg.ShowInformation("删除成功");
                        gridView1.DeleteRow(selRow);
                    }
                    else
                    {
                        Msg.ShowError("删除失败");
                    }
                }


            }
        }
    }
}
