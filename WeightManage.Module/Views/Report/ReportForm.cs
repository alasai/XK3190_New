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
using gregn6Lib;
using Models;
using WeightManage.AppService;
using WeightManage.Models;
using WeightManage.Models.Dto;
using YIEternalMIS.Base;
using YIEternalMIS.Common;

namespace WeightManage.Module.Views
{
    public partial class ReportForm : BaseForm
    {
        public ReportForm()
        {
            InitializeComponent();
            //batchId.OptionsColumn.AllowEdit = false;
        }
        private ReportAppService _reportApp=new ReportAppService();
        BindingList<WeightBatchDto> _weightGrid = new BindingList<WeightBatchDto>();
        private List<WeightGridDto> _reportList = new List<WeightGridDto>();

        private void ReportForm_Load(object sender, EventArgs e)
        {
            date.DateTime= DateTime.Now;

            var reportfile = Application.StartupPath + @"\report\report.grf";
            Report.LoadFromFile(reportfile);
            Report.FetchRecord += new _IGridppReportEvents_FetchRecordEventHandler(report_FetchRecord);

            field1 = Report.FieldByName("Sort");
            field2 = Report.FieldByName("Name");
            field3 = Report.FieldByName("ProductName");
            field4 = Report.FieldByName("Weights");
            field5 = Report.FieldByName("hookWeights");
            field6 = Report.FieldByName("JWeight");
            field7 = Report.FieldByName("ProductNum");
            field8 = Report.FieldByName("ProductPrice");
            field9 = Report.FieldByName("TotalPrice");
            field10 = Report.FieldByName("weighingTime");
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            var nowtime = DateTime.Now;
            DateTime stime = nowtime;
            if (!string.IsNullOrEmpty(date.Text))
            {
                stime = DateTime.Parse(date.Text);
            }
            else
            {
                stime = new DateTime(nowtime.Year, nowtime.Month, nowtime.Day);
            }
            var etime = stime.AddDays(1);

            var name = txtName.Text.Trim();
            var idNumber = txtIdNumber.Text.Trim();

            var data = _reportApp.GetWeightBatch(stime, name, idNumber);
            _weightGrid = new BindingList<WeightBatchDto>(data);
            gridWeight.DataSource = _weightGrid;
        }

        /// <summary>
        /// 打印
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void repositoryItemButtonEdit1_Click(object sender, EventArgs e)
        {
            var model = (WeightBatchDto)gridView1.GetFocusedRow();
            // Msg.ShowInformation(model.batchId);

            _reportList = _reportApp.GetWeightReport(model);
            if (_reportList.Any())
            {
                Report.PrintPreview(true);
            }
            else
            {
                Msg.Warning("没有数据可以打印");
            }
        }

        #region grid++ report
        private GridppReport Report = new GridppReport();
        IGRField field1;
        IGRField field2;
        IGRField field3;
        IGRField field4;
        IGRField field5;
        IGRField field6;
        IGRField field7;
        IGRField field8;
        IGRField field9;
        IGRField field10;
        private void report_FetchRecord()
        {

            try
            {
                var title = Report.ControlByName("SubTitleBox");
                title.AsStaticBox.Text = "统计时间:" + DateTime.Now;
                int tempsort = 1;

                int count = _reportList.Count;
                for (int i = 0; i < count; i++)
                {
                    var model = _reportList[i];
                    Report.DetailGrid.Recordset.Append();
                    field1.Value = tempsort;
                    field2.Value = model.IdNumber;
                    field3.Value = model.ProductName;
                    field4.Value = model.MaoWeight;
                    field5.Value = model.PiWeight;
                    field6.Value = model.NetWeight;
                    field7.Value = model.Num;
                    field8.Value = model.Price;
                    field9.Value = model.TotalPrice;
                    field10.Value = model.WeightTime;
                    Report.DetailGrid.Recordset.Post();
                    tempsort++;
                }
            }
            catch (Exception ex)
            {
                LogNHelper.Exception(ex);
            }
            finally
            {
                _reportList = new List<WeightGridDto>();
            }

        }
        #endregion
    }
}
