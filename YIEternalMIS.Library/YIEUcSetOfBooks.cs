using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;


namespace YIEternalMIS.Library
{
    public partial class YIEUcSetOfBooks : DevExpress.XtraEditors.XtraUserControl
    {


        /// <summary>
        /// 选择项发生变化的事件处理
        /// </summary>
        public event EventHandler SelectedValueChanged;


        public YIEUcSetOfBooks()
        {
            InitializeComponent();
        }


        public void InitUserControl()
        {

            txtOperator.Properties.ValueMember = "DataSetID";
            txtOperator.Properties.DisplayMember = "DataSetName";
            txtOperator.Properties.NullText = "请选择登陆账套";
            //DataTable DTSource = new tb_DataSet().GetAllList().Tables[0];
            //txtOperator.Properties.DataSource = DTSource;
            //if (Common.DataIsNULL.Isnull(Common.UserINIAndXML.sDataSetID, "") == "")
            //{
            //    txtOperator.EditValue = null;
            //}
            //else txtOperator.EditValue = Common.UserINIAndXML.sDataSetID;

        }

        /// <summary>
        /// 修改窗口Text属性来存储账套值
        /// </summary>
        public override string Text
        {
            get
            {
                string result = "";
                if (this.txtOperator.EditValue != null)
                {
                    result = this.txtOperator.EditValue.ToString();
                }
                return result;
            }
            set
            {
                this.txtOperator.EditValue = value;
            }
        }

       public bool GetValue( out string sEditValue , out string sText )
       {
           sText = txtOperator.Text;
           sEditValue = "";
           if(sText == txtOperator.Properties.NullText) 
           {
               Common.Msg.ShowInformation("请选择要登录的账套服务器!!!");
               txtOperator.Focus();
               return false;
           }
           sEditValue = txtOperator.EditValue.ToString();
           return true;
           
       }

        /// <summary>
        /// 定义EditValueChange 账套选择触发
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtOperator_EditValueChanged(object sender, EventArgs e)
        {
            if (SelectedValueChanged != null)
            {
                SelectedValueChanged(sender, e);
            }
        }
    }
}
