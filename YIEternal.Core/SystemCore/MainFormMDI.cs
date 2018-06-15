/*************************************************************************************
    * 类 名 称：       MainFormMDI
    * 命名空间：       YIEternalMIS.Core
    * 文 件 名：       MainFormMDI
    * 创建时间：       2017/6/19 17:35:44
    * 作    者：        王宏巍
    * 说   明：        主窗口类存储主窗口中的控件
    * 修改时间：
    * 修 改 人：
*************************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraTabbedMdi;
using DevExpress.XtraBars;
using DevExpress.XtraNavBar;

namespace YIEternalMIS.Core
{
    public static class MainFormMDI
    {
        static XtraTabbedMdiManager _MainTabManager;
        static RibbonForm _MainMDIForm;
        static BarSubItem _oldBarSubItem;
        static NavBarControl _MainNavBar =null;
        static bool _RegOldBar = false;
        static DevExpress.XtraEditors.XtraForm _AccontForm = null;
        static DevExpress.XtraTab.XtraTabControl _AccontTabControl = null;


        /// <summary>
        /// Tab管理器
        /// </summary>
        public static XtraTabbedMdiManager MainTabManager
        { set { _MainTabManager = value; } get { return _MainTabManager; } }

        /// <summary>
        /// Ribbon管理器
        /// </summary>
        public static RibbonForm MainMDIForm { set { _MainMDIForm = value; } get { return _MainMDIForm; } }

        /// <summary>
        /// 近期访问菜单管理器
        /// </summary>
        public static BarSubItem OldBarSubItem { set { _oldBarSubItem = value; } get { return _oldBarSubItem; } }

        /// <summary>
        /// Navbar管理器
        /// </summary>
        public static NavBarControl MainNavBar { set { _MainNavBar = value; } get { return _MainNavBar; } }

        /// <summary>
        /// 是否注册近期访问窗口
        /// </summary>
        public static bool RegOldBar { set { _RegOldBar = value; } get {return _RegOldBar; } }

        /// <summary>
        /// 导航界面所在的窗口
        /// </summary>
        public static DevExpress.XtraEditors.XtraForm AccontForm { set { _AccontForm = value; } get { return _AccontForm; } }


        /// <summary>
        /// 导航界面所在TabControl
        /// </summary>
        public static DevExpress.XtraTab.XtraTabControl AccontTabControl { set { _AccontTabControl = value; } get { return _AccontTabControl; } }

    }
}
