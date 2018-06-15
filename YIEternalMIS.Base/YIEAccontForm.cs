using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraTab;
using DevExpress.XtraTab.ViewInfo;
using YIEternalMIS.Common;
using YIEternalMIS.Interfaces;

namespace YIEternalMIS.Base
{
    public partial class YIEAccontForm : YIEternalMIS.Base.BaseForm
    {
        IOpenModuleForm _IOpenForm;
        public YIEAccontForm()
        {
            InitializeComponent();
        }


        public void OpenGroupControl(IOpenModuleForm IOpenModule )
        {
            _IOpenForm = IOpenModule;
            if (_IOpenForm == null)
            {
                Msg.ShowError("窗口打开错误！！未设置导航窗口!!请联系系统开发商。错误代码YIEAccontForm-32");
                return;
            }

            if (String.IsNullOrEmpty(_IOpenForm.FormAssembly) || String.IsNullOrEmpty(_IOpenForm.FormName))
            { Msg.ShowError("窗口打开错误！设置导航窗口！请联系系统开发商。错误代码：YIEAccontForm-37"); }

            if (xtabAccont.TabPages.Count > 0)
            {
                //判断是否打开，如果打开直接几选择
                foreach (DevExpress.XtraTab.XtraTabPage pages in xtabAccont.TabPages)
                {
                    if (pages.Name == _IOpenForm.FormName )
                    {
                        xtabAccont.SelectedTabPage = pages;
                        return;
                    }

                }
            }

            try
            {
                //xtabAccont.TabPages.Clear();
                
                System.Reflection.Assembly asm = System.Reflection.Assembly.Load( _IOpenForm.FormAssembly);//程序集名
                object Obj = asm.CreateInstance( _IOpenForm.FormAssembly + "." + _IOpenForm.FormName);//程序集+form的类名。
                //创建新的当行页面
                DevExpress.XtraEditors.XtraUserControl xControlPage;                              
                xControlPage = (DevExpress.XtraEditors.XtraUserControl)Obj;
                DevExpress.XtraTab.XtraTabPage AddPage = new DevExpress.XtraTab.XtraTabPage();

                //设置导航页面属性
                AddPage.Name = _IOpenForm.FormName;
                xControlPage.Dock = DockStyle.Fill;
                AddPage.Controls.Add(xControlPage);
                //不显示右上角的关闭X
                AddPage.ShowCloseButton = DevExpress.Utils.DefaultBoolean.False;
                xtabAccont.TabPages.Add(AddPage);
                xtabAccont.SelectedTabPage = AddPage;
                
                this.Activate();
            }
            catch (Exception e)
            {

                Msg.ShowException(e);
            }
        }

        private void xtabAccont_CloseButtonClick(object sender, EventArgs e)
        {
            LogNHelper.Info("关闭");
            ClosePageButtonEventArgs arg = e as ClosePageButtonEventArgs;

            XtraTabPage page=(arg.Page as XtraTabPage);
            if (page.Text == "系统导航")
            {
                Msg.ShowInformation("禁止关闭");
                return;
                
            }

            LogNHelper.Info(page.Text);
        }
    }
}
