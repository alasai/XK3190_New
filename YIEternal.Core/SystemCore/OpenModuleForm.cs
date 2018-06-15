/*************************************************************************************
    * 类 名 称：       OpenModuleForm
    * 命名空间：       YIEternalMIS.Core
    * 文 件 名：       OpenModuleForm
    * 创建时间：       2017/6/12 9:12:04
    * 作    者：        王宏巍
    * 说   明：
    * 修改时间：
    * 修 改 人：
*************************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using YIEternalMIS.Interfaces;
using YIEternalMIS.Common;
using YIEternalMIS.BLL;
using System.Data;
using System.Windows.Forms;
using DevExpress.XtraBars;

namespace YIEternalMIS.Core
{
    
    public class OpenModuleForm : IOpenModuleForm,IOpenModel
    {
        string _FormName, _FormText, _FormTag, _FormAssembly; 
        System.Drawing.Image _FormImage32, _FormImage16;
        FormOpenType _FormOpenType = FormOpenType.MdiOpen;
        FromNavOrRibbonType _FormType = FromNavOrRibbonType.NavBar;

        /// <summary>
        /// 窗口名ClassName
        /// </summary>
        public string FormName { get { return _FormName; } set { _FormName = value; } }
        /// <summary>
        /// 窗口显示名称
        /// </summary>
        public string FormText { get { return _FormText; } set { _FormText = value; } }
        /// <summary>
        /// 窗口Tag
        /// </summary>
        public string FormTag { get { return _FormTag; } set { _FormTag = value; } }
        /// <summary>
        /// 32大小的图标
        /// </summary>
        public System.Drawing.Image FormImage32 { get { return _FormImage32; } set { _FormImage32 = value; } }
        /// <summary>
        /// 16大小的图标
        /// </summary>
        public System.Drawing.Image FormImage16 { get { return _FormImage16; } set { _FormImage16 = value; } }
        /// <summary>
        /// 窗口打开类型
        /// </summary>
        public FormOpenType FormOpenType { get { return _FormOpenType; } set { _FormOpenType = value; } }
        /// <summary>
        /// 所在程序集
        /// </summary>
        public string FormAssembly { get { return _FormAssembly; } set { _FormAssembly = value; } }

        /// <summary>
        /// 主窗口类型
        /// </summary>
        public FromNavOrRibbonType FormType { get { return _FormType; } set { _FormType = value; } }


        public IOpenModuleForm GetOpenFormPro(string MenuNewID )
        {
            
            string sOpenType = "1";
            string sVisible;
            DataView dv =  SystemAuthentication.UserAuthorities.DefaultView;
            dv.Sort="MenuNewID";
            DataRowView[] drv = dv.FindRows( MenuNewID );
            if( drv.Length > 0 )
            {
                sVisible = drv[0].Row["MenuVisible"].ToString();
                if (!(sVisible == "1")) return null;


                FormName = drv[0].Row["OpenFormClassName"].ToString();
                FormText = drv[0].Row["MenuText"].ToString();
                FormAssembly = drv[0].Row["OpenAssembly"].ToString();
                FormImage16 = Globals.LoadImage(drv[0].Row["MenuIcon"].ToString(), 16);
                FormImage32 = Globals.LoadImage(drv[0].Row["MenuIcon"].ToString(), 32);
                sOpenType = drv[0].Row["OpenType"].ToString();
                if (sOpenType == "1") FormOpenType = Common.FormOpenType.MdiOpen;
                else if (sOpenType == "2") FormOpenType = Common.FormOpenType.DiaLogOpen;
                else if (sOpenType == "3") FormOpenType = Common.FormOpenType.DefaultOpen;
                FormTag = MenuNewID;
            }


            return this;
        }

        public IOpenModuleForm GetOpenFormProNew(string MenuNewID)
        {

            string sOpenType = "1";
            //string sVisible;
            //DataView dv = SystemAuthentication.UserAuthorities.DefaultView;
            //dv.Sort = "MenuNewID";
            //DataRowView[] drv = dv.FindRows(MenuNewID);
            //if (drv.Length > 0)
            //{
            //    sVisible = drv[0].Row["MenuVisible"].ToString();
            //    if (!(sVisible == "1")) return null;


            //    FormName = drv[0].Row["OpenFormClassName"].ToString();
            //    FormText = drv[0].Row["MenuText"].ToString();
            //    FormAssembly = drv[0].Row["OpenAssembly"].ToString();
            //    FormImage16 = Globals.LoadImage(drv[0].Row["MenuIcon"].ToString(), 16);
            //    FormImage32 = Globals.LoadImage(drv[0].Row["MenuIcon"].ToString(), 32);
            //    sOpenType = drv[0].Row["OpenType"].ToString();
            //    if (sOpenType == "1") FormOpenType = Common.FormOpenType.MdiOpen;
            //    else if (sOpenType == "2") FormOpenType = Common.FormOpenType.DiaLogOpen;
            //    else if (sOpenType == "3") FormOpenType = Common.FormOpenType.DefaultOpen;
            //    FormTag = MenuNewID;
            //}

            var menu = SystemAuthentication.SystemMenuList.Where(s => s.MenuId == MenuNewID).FirstOrDefault();
            if (menu == null) return null;
            FormName = menu.OpenFormClassName;
            FormText = menu.MenuText;
            FormAssembly =menu.OpenAssembly;
            FormImage16 = Globals.LoadImage(menu.Icon, 16);
            FormImage32 = Globals.LoadImage(menu.Icon, 32);
            sOpenType ="1";
            if (sOpenType == "1") FormOpenType = Common.FormOpenType.MdiOpen;
            else if (sOpenType == "2") FormOpenType = Common.FormOpenType.DiaLogOpen;
            else if (sOpenType == "3") FormOpenType = Common.FormOpenType.DefaultOpen;
            FormTag = MenuNewID;


            return this;
        }

    }


}
