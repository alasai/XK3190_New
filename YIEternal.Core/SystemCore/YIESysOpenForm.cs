/*************************************************************************************
    * 类 名 称：       YIESysOpenForm
    * 命名空间：       YIEternalMIS.Core
    * 文 件 名：       YIESysOpenForm
    * 创建时间：       2017/6/20 11:53:49
    * 作    者：        王宏巍
    * 说   明：
    * 修改时间：
    * 修 改 人：
*************************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraBars;
using YIEternalMIS.Interfaces;
using YIEternalMIS.Common;

namespace YIEternalMIS.Core
{
    public class YIESysOpenForm : IOpenForm
    {
          private  FormOpenType FormOpen = FormOpenType.MdiOpen;
        //主窗口类型
          private YIEternalMIS.Common.FromNavOrRibbonType FormType = FromNavOrRibbonType.Ribbon; 
          private IOpenModel OpenModule = new OpenModuleForm();


        public void OpenForm( string sMenuNewID )
        {
            DevExpress.XtraSplashScreen.SplashScreenManager.ShowDefaultWaitForm("正在打开窗口,请稍后...");
            //OpenForm( OpenModule.GetOpenFormPro(sMenuNewID));
            OpenForm(OpenModule.GetOpenFormProNew(sMenuNewID));
            DevExpress.XtraSplashScreen.SplashScreenManager.CloseDefaultWaitForm();
        }
        /// <summary>
        /// 窗口打开方法
        /// </summary>
        /// <param name="FormModule"></param>
        public void OpenForm(IOpenModuleForm FormModule)
        {
            if (FormModule == null) return;
            //窗口是否已经打开
            //if (FormIsOpen(FormModule)) return;
            if (FormIsOpenNew(FormModule)) return;
            //窗口打开类型
            //FormOpen = FormModule.FormOpenType;

            //打开窗口
            OpenForm(FormModule, MainFormMDI.RegOldBar);

        }

        /// <summary>
        /// Nav样式的主窗口展开Group切换主界面流程图
        /// </summary>
        /// <param name="sMenuNewID"></param>
        public void NavGroupExpanded(string sMenuNewID)
        {
            NavGroupExpanded(OpenModule.GetOpenFormPro(sMenuNewID));
        }

        public void NavGroupExpanded(IOpenModuleForm GroupModule)
        {
            OpenGroupControl(GroupModule);
        }

        /// <summary>
        /// 窗口是否已经打开
        /// </summary>
        /// <param name="FormModule"></param>
        /// <returns></returns>
        public bool FormIsOpen( IOpenModuleForm FormModule)
        {
            return FormIsOpen(FormModule.FormName);
            
        }

        public bool FormIsOpen( string sFormName )
        {
            // 是否已经打开了？（用循环来判断）
            foreach (Form childrenForm in MainFormMDI.MainMDIForm.MdiChildren)
            {
                //检测是不是当前子窗体名称
                if (childrenForm.Name == sFormName )
                {
                    //是的话就是把他显示
                    childrenForm.Visible = true;
                    //并激活该窗体
                    childrenForm.Activate();
                    return true;
                }
            }
            return false;
        }
        public bool FormIsOpenNew(IOpenModuleForm FormModule)
        {
            // 是否已经打开了？（用循环来判断）
            foreach (Form childrenForm in MainFormMDI.MainMDIForm.MdiChildren)
            {
                if (childrenForm.Tag != null)
                {
                    if (childrenForm.Tag.ToString() == FormModule.FormTag)
                    {
                        //是的话就是把他显示
                        childrenForm.Visible = true;
                        //并激活该窗体
                        childrenForm.Activate();
                        return true;
                    }
                }
               // childrenForm.Tag.ToString();
                //检测是不是当前子窗体名称
                
            }
            return false;
        }
        /// <summary>
        /// 窗口打开方法，
        /// </summary>
        /// <param name="IOpenForm"></param>
        void OpenForm(IOpenModuleForm IOpenForm, bool ib)
        {
            if (IOpenForm == null)
            {
                Msg.ShowError("窗口打开错误！！您打开的窗口不存在!!请联系系统开发商。错误代码:YIESysOpenForm76");
                return;
            }

            if (String.IsNullOrEmpty(IOpenForm.FormAssembly) || String.IsNullOrEmpty(IOpenForm.FormName))
            {
                Msg.ShowError("窗口打开错误！未设置要打开的窗口！请联系系统开发商。错误代码：YIESysOpenForm82");
                return;
            
            }
            try
            {
                System.Reflection.Assembly asm = System.Reflection.Assembly.Load(IOpenForm.FormAssembly);//程序集名
                object frmObj = asm.CreateInstance(IOpenForm.FormAssembly + "." + IOpenForm.FormName);//程序集+form的类名。
                Form childForm = (Form)frmObj;
                childForm.Tag = IOpenForm.FormTag;  //tag属性要重新写一次，否则在第二次的时候取不到。原因还不清楚。有知道的望告知。
                childForm.MdiParent = MainFormMDI.MainMDIForm;
                childForm.Show();
                MainFormMDI.MainTabManager.Pages[childForm].Image = IOpenForm.FormImage16;
                MainFormMDI.MainTabManager.Pages[childForm].ShowCloseButton = DevExpress.Utils.DefaultBoolean.True;
                //if (ib) RegeditMenu(IOpenForm);
            }
            catch (Exception e)
            {

                Msg.ShowException(e);
            }

        }

        /// <summary>
        /// 注册近期访问窗口--在窗口打开事件中调用
        /// </summary>
        /// <param name="as_Caption">窗口显示的文本</param>
        /// <param name="as_Tag">打开的Form名</param>
        /// <param name="as_ImageIndex">Ribbon上显示的图标名称</param>
        void RegeditMenu(IOpenModuleForm IOpenForm)
        {
            DevExpress.XtraBars.BarSubItem barOld = MainFormMDI.OldBarSubItem;

            //最近访问的菜单只存储4条，多的将以前的删除掉加入新的
            if (barOld.ItemLinks.Count > 3)
            {
                int mod = barOld.ItemLinks.Count % 4;
                barOld.ItemLinks.Remove(barOld.ItemLinks[mod]);
            }

            //添加新的菜单
            BarButtonItem btnitem = new BarButtonItem();
            btnitem.Name = IOpenForm.FormName;
            btnitem.Caption = IOpenForm.FormText;
            btnitem.Tag = IOpenForm.FormTag;
            btnitem.LargeGlyph = IOpenForm.FormImage32;
            barOld.AddItem(btnitem);
            btnitem.ItemClick += new ItemClickEventHandler(btnitem_ItemClick);
        }

        //注册最近访问菜单的窗口打开事件
        void btnitem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OpenForm( e.Item.Tag.ToString());
        }


        void OpenGroupControl(IOpenModuleForm IOpenForm )
        {
            if (IOpenForm == null)
            {
                Msg.ShowError("窗口打开错误！！未设置导航窗口!!请联系系统开发商。错误代码YIEAccontForm-32");
                return;
            }

            if (String.IsNullOrEmpty(IOpenForm.FormAssembly) || String.IsNullOrEmpty(IOpenForm.FormName))
            { Msg.ShowError("窗口打开错误！设置导航窗口！请联系系统开发商。错误代码：YIEAccontForm-37"); }



            if (MainFormMDI.AccontTabControl.TabPages.Count > 0)
            {
                //判断是否打开，如果打开直接几选择
                foreach (DevExpress.XtraTab.XtraTabPage pages in MainFormMDI.AccontTabControl.TabPages)
                {
                    if (pages.Name == IOpenForm.FormName)
                    {
                        MainFormMDI.AccontTabControl.SelectedTabPage = pages;
                        MainFormMDI.MainTabManager.Pages[MainFormMDI.AccontForm].Image = IOpenForm.FormImage16;
                        return;
                    }

                }
            }

            try
            {
                //xtabAccont.TabPages.Clear();

                System.Reflection.Assembly asm = System.Reflection.Assembly.Load(IOpenForm.FormAssembly);//程序集名
                object Obj = asm.CreateInstance(IOpenForm.FormAssembly + "." + IOpenForm.FormName);//程序集+form的类名。
                //创建新的当行页面
                DevExpress.XtraEditors.XtraUserControl xControlPage;
                xControlPage = (DevExpress.XtraEditors.XtraUserControl)Obj;
                DevExpress.XtraTab.XtraTabPage AddPage = new DevExpress.XtraTab.XtraTabPage();

                //设置导航页面属性
                AddPage.Name = IOpenForm.FormName;
                xControlPage.Dock = DockStyle.Fill;
                AddPage.Controls.Add(xControlPage);
                //不显示右上角的关闭X
                AddPage.ShowCloseButton = DevExpress.Utils.DefaultBoolean.False;
                MainFormMDI.AccontTabControl.TabPages.Add(AddPage);
                MainFormMDI.AccontTabControl.SelectedTabPage = AddPage;
                MainFormMDI.AccontForm.Activate();

                if (FormIsOpen( MainFormMDI.AccontForm.Name))
                {
                    MainFormMDI.MainTabManager.Pages[MainFormMDI.AccontForm].Image = IOpenForm.FormImage16;

                    return;
                }
                MainFormMDI.AccontForm.MdiParent = MainFormMDI.MainMDIForm;
                MainFormMDI.AccontForm.Show();
                MainFormMDI.MainTabManager.Pages[MainFormMDI.AccontForm].Image = IOpenForm.FormImage16;
                MainFormMDI.MainTabManager.Pages[MainFormMDI.AccontForm].ShowCloseButton = DevExpress.Utils.DefaultBoolean.True;
                //xtab_manager.Pages[xtab_manager.ActiveFloatForm].Image = IOpenModuleForm.FormImage16;
            }
            catch (Exception e)
            {

                Msg.ShowException(e);
            }
        }

    }
}
