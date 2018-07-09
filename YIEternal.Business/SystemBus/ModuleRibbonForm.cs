/*************************************************************************************
    * 类 名 称：       ModuleRibbonForm
    * 命名空间：       YIEternalMIS.Business
    * 文 件 名：       ModuleRibbonForm
    * 创建时间：       2017/6/20 9:55:07
    * 作    者：        王宏巍
    * 说   明：
    * 修改时间：
    * 修 改 人：
*************************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;
using YIEternalMIS.Common;
using YIEternalMIS.Core;
using YIEternalMIS.Interfaces;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraBars;
using YIEternalMIS.Core.SystemCore;

namespace YIEternalMIS.Business
{
    public class ModuleRibbonForm : IFormModule
    {

        /// <summary>
        /// 主窗口是Ribbon模式添加主窗口菜单
        /// </summary>
        /// <param name="MainCon"></param>
        public void MainModule(object MainCon)
        {
            RibbonControl MainControl = new RibbonControl();
            if (MainControl.GetType() == MainCon.GetType())
            {
                MainControl = (RibbonControl)MainCon;
                // AddRibbonPage(MainControl);
                AddRibbonPageNew(MainControl);
            }
        }



        /// <summary>
        /// 添加Ribbon的Page页面
        /// </summary>
        /// <param name="MainControl"></param>
        void AddRibbonPage(RibbonControl MainControl )
        {
            MainControl.SuspendLayout();
            //获得当前登录用户权限表
            DataView _PageView = new DataView(SystemAuthentication.UserAuthorities);
            //按照菜单排序进行重新排序
            _PageView.Sort = "MenuOrder DESC";
            //获取Page菜单
            _PageView.RowFilter = "MenuLevel = 1";
            foreach (DataRowView drv in _PageView)
            {
                RibbonPage addgp = new RibbonPage();
                //菜单显示名称
                addgp.Text = drv.Row["MenuText"].ToString();
                addgp.Tag = drv.Row["MenuNewID"].ToString();
                addgp.Name = drv.Row["MenuName"].ToString();
                addgp.Image = Globals.LoadImage(drv.Row["MenuIcon"].ToString(), 16);
                addgp.MergeOrder = Convertto.ToInt(drv.Row["MenuOrder"]);
                //添加分组
                AddRibbonGroup(addgp, drv.Row["MenuID"].ToString());
                //page添加在第一个后面进行倒叙插入
                MainControl.Pages.Insert(1, addgp);

                LogNHelper.Info(addgp.Text);
                LogNHelper.Info(drv.Row["MenuNewID"].ToString());
                LogNHelper.Info(addgp.Name);
                LogNHelper.Info(drv.Row["MenuIcon"].ToString());
               // LogNHelper.Info(drv.Row["MenuTips"].ToString());
                LogNHelper.Info(drv.Row["MenuID"].ToString());
                LogNHelper.Info("-------");
            }


            MainControl.ResumeLayout();
        }

        /// <summary>
        /// 添加Page页面的Group分组
        /// </summary>
        /// <param name="rbpage"></param>
        /// <param name="sParentNode"></param>
        void AddRibbonGroup( RibbonPage rbpage , string sParentNode )
        {
            string _sNode;
             //获得当前登录用户权限表
            DataView _GroupView = new DataView(SystemAuthentication.UserAuthorities);
            //用于判断Group是否存在子项
            DataView _NodeView = new DataView(SystemAuthentication.UserAuthorities);
            //按照菜单排序进行重新排序
            _GroupView.Sort = "MenuOrder ASC";
            //获取Group菜单
            _GroupView.RowFilter = "MenuLevel = 2 AND  ParentMenuID='" + sParentNode + "'";

            foreach (DataRowView drv in _GroupView)
            {
                _sNode = drv.Row["MenuID"].ToString();
                _NodeView.RowFilter = "MenuLevel = 3 AND ParentMenuID ='" + _sNode + "'";
                //如果存在子项，则添加Group 不存在不添加
                if (_NodeView.Count > 0)
                {
                    RibbonPageGroup addgp = new RibbonPageGroup();
                    //菜单显示名称
                    addgp.Text = drv.Row["MenuText"].ToString();
                    addgp.Tag = drv.Row["MenuNewID"].ToString();
                    addgp.Name = drv.Row["MenuName"].ToString();
                    addgp.MergeOrder = Convertto.ToInt(drv.Row["MenuOrder"]);
                    addgp.ShowCaptionButton = false;
                    AddRibbonItem(addgp, drv.Row["MenuID"].ToString());
                    rbpage.Groups.Add(addgp);

                }
            }
                //AddNavItem(addgp, drv.Row["MenuID"].ToString());
        }

        /// <summary>
        /// 添加分组的ButtonItem按钮
        /// </summary>
        /// <param name="rbGroup"></param>
        /// <param name="sParentNode"></param>
        void AddRibbonItem( RibbonPageGroup rbGroup , string sParentNode )
        {
            //获得当前登录用户权限表
            DataView _GroupView = new DataView(SystemAuthentication.UserAuthorities);

            //按照菜单排序进行重新排序
            _GroupView.Sort = "MenuOrder ASC";
            //获取Group菜单
            _GroupView.RowFilter = "MenuLevel = 3 AND  ParentMenuID='" + sParentNode + "'";

            //操作提示注册
            DevExpress.Utils.SuperToolTip PageToolTip = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem TitleToolTip = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem ItemToolTip = new DevExpress.Utils.ToolTipItem();
            TitleToolTip.Text = "操作提示";
            foreach (DataRowView drv in _GroupView)
            {

                BarButtonItem AddBtnItem = new BarButtonItem();
                //菜单显示名称
                AddBtnItem.Caption = drv.Row["MenuText"].ToString();
                AddBtnItem.Tag = drv.Row["MenuNewID"].ToString();
                AddBtnItem.Name = drv.Row["MenuName"].ToString();
                AddBtnItem.MergeOrder = Convertto.ToInt(drv.Row["MenuOrder"]);
                AddBtnItem.LargeGlyph = Globals.LoadImage(drv.Row["MenuIcon"].ToString(), 32);
                ItemToolTip.Text = drv.Row["MenuTips"].ToString();
                PageToolTip.Items.Clear();
                PageToolTip.Items.Add(TitleToolTip);
                PageToolTip.Items.Add(ItemToolTip);
                AddBtnItem.SuperTip = PageToolTip;
                rbGroup.ItemLinks.Add(AddBtnItem);
                AddBtnItem.ItemClick += new ItemClickEventHandler(AddBtnItem_ItemClick);

            }
        }


        #region 新添加导航

        void AddRibbonPageNew(RibbonControl MainControl)
        {
            MainControl.SuspendLayout();
            var menus = SystemAuthentication.SystemMenuList;

            var topMenu = menus.Where(s => s.MenuPid == "0").OrderBy(s => s.MenuSort).ToList();
            foreach (var menu in topMenu)
            {
                RibbonPage addgp = new RibbonPage();
                //菜单显示名称
                addgp.Text = menu.MenuText;
                addgp.Tag = menu.MenuText;
                addgp.Name = menu.MenuText;
                addgp.Image = Globals.LoadImage(menu.Icon, 16);
                addgp.MergeOrder = menu.MenuSort;
                //添加分组
                var childMenu = menus.Where(s => s.MenuPid == menu.MenuId).OrderBy(s => s.MenuSort).ToList();
                AddRibbonGroupNew(addgp, childMenu);
                //page添加在第一个后面进行倒叙插入
                MainControl.Pages.Insert(1, addgp);
            }
        }

        void AddRibbonGroupNew(RibbonPage rbpage, List<MenuListDto> menus)
        {
            if (menus.Any())
            {
                foreach (var menu in menus)
                {
                    RibbonPageGroup addgp = new RibbonPageGroup();
                    //菜单显示名称
                    addgp.Text = menu.MenuText;
                    addgp.Tag = menu.MenuText;
                    addgp.Name = menu.MenuText;
                    addgp.MergeOrder = menu.MenuSort;
                    addgp.ShowCaptionButton = false;
                    var childMenu = SystemAuthentication.SystemMenuList.Where(s => s.MenuPid == menu.MenuId).OrderBy(s => s.MenuSort).ToList();
                    AddRibbonItemNew(addgp, childMenu);
                    rbpage.Groups.Add(addgp);
                }
            }
            //AddNavItem(addgp, drv.Row["MenuID"].ToString());
        }


        void AddRibbonItemNew(RibbonPageGroup rbGroup, List<MenuListDto> menus)
        {
            if (menus.Any())
            {
                //操作提示注册
                DevExpress.Utils.SuperToolTip PageToolTip = new DevExpress.Utils.SuperToolTip();
                DevExpress.Utils.ToolTipTitleItem TitleToolTip = new DevExpress.Utils.ToolTipTitleItem();
                DevExpress.Utils.ToolTipItem ItemToolTip = new DevExpress.Utils.ToolTipItem();
                TitleToolTip.Text = "操作提示";
                foreach (var menu in menus)
                {
                    BarButtonItem AddBtnItem = new BarButtonItem();
                    //菜单显示名称
                    AddBtnItem.Caption = menu.MenuText;
                    AddBtnItem.Tag = menu.MenuId;
                    AddBtnItem.Name = menu.MenuText;
                    AddBtnItem.MergeOrder = menu.MenuSort;
                    AddBtnItem.LargeGlyph = Globals.LoadImage(menu.Icon, 32);
                    ItemToolTip.Text = menu.MenuText;
                    PageToolTip.Items.Clear();
                    PageToolTip.Items.Add(TitleToolTip);
                    PageToolTip.Items.Add(ItemToolTip);
                    AddBtnItem.SuperTip = PageToolTip;
                    rbGroup.ItemLinks.Add(AddBtnItem);
                    AddBtnItem.ItemClick += new ItemClickEventHandler(AddBtnItem_ItemClick);
                }
            }
        }
        #endregion
        void AddBtnItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            IOpenForm OpenRibbon = new YIESysOpenForm();
            OpenRibbon.OpenForm(e.Item.Tag.ToString());
        }

    }
}
