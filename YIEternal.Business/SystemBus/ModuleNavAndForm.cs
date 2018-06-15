/*************************************************************************************
    * 类 名 称：       ModuleNavAndForm
    * 命名空间：       YIEternalMIS.Business
    * 文 件 名：       ModuleNavAndForm
    * 创建时间：       2017/6/9 13:32:33
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
using DevExpress.XtraNavBar;
using System.Data;
using YIEternalMIS.Common;
using YIEternalMIS.Core;
using System.Windows.Forms;



namespace YIEternalMIS.Business
{
    public class ModuleNavAndForm : IFormModule
    {

        
        /// <summary>
        /// 主窗口的Navbar添加
        /// </summary>
        /// <param name="MainCon"></param>
        public void MainModule(object MainCon)
        {
            NavBarControl MainControl = new NavBarControl();
            if (MainControl.GetType() == MainCon.GetType())
            {
                MainControl = (NavBarControl)MainCon;
                AddNavGroup(MainControl);
            }
            

        }

        public void AddNavGroup(NavBarControl NavMain)
        {
            NavMain.SuspendLayout();
            //获得当前登录用户权限表
            DataView _GroupView = new DataView( SystemAuthentication.UserAuthorities );
            //按照菜单排序进行重新排序
            _GroupView.Sort = "MenuOrder ASC";
            //获取Group菜单
            _GroupView.RowFilter = "MenuLevel = 1";

            //操作提示注册
            DevExpress.Utils.SuperToolTip GroupToolTip = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem TitleToolTip = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem ItemToolTip = new DevExpress.Utils.ToolTipItem();
            TitleToolTip.Text = "操作提示";
            foreach (DataRowView drv in _GroupView)
            {
                NavBarGroup addgp = new NavBarGroup();
                //菜单显示名称
                addgp.Caption = drv.Row["MenuText"].ToString();
                addgp.Tag = drv.Row["MenuNewID"].ToString();
                addgp.Name = drv.Row["MenuName"].ToString();
                addgp.SmallImage = Globals.LoadImage(drv.Row["MenuIcon"].ToString(), 32);
                //添加操作鼠标提示
                ItemToolTip.Text = drv.Row["MenuTips"].ToString();
                GroupToolTip.Items.Clear();
                GroupToolTip.Items.Add(TitleToolTip);
                GroupToolTip.Items.Add(ItemToolTip);
                AddNavItem(addgp, drv.Row["MenuID"].ToString());
                NavMain.Groups.Add(addgp);
            }
            

            NavMain.ResumeLayout();
            NavMain.GroupExpanded += new NavBarGroupEventHandler(NavMain_GroupExpanded);
            //NavMain.Groups.AddRange(AddGROUP);
        }

        /// <summary>
        /// Group 展开事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void NavMain_GroupExpanded(object sender, NavBarGroupEventArgs e)
        {
            IOpenForm OpenGroupExpaned = new YIESysOpenForm();
            OpenGroupExpaned.NavGroupExpanded(e.Group.Tag.ToString());
        }
           

        public void AddNavItem(NavBarGroup NavGroup, string sParentMenuID)
        {
            DataView _ItemView = new DataView ( SystemAuthentication.UserAuthorities);
            _ItemView.Sort = "MenuOrder ASC";
            _ItemView.RowFilter = "MenuLevel = 2 and ParentMenuID='" + sParentMenuID + "'";
            DevExpress.Utils.SuperToolTip IToolTip = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem ITitleToolTip = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem IItemToolTip = new DevExpress.Utils.ToolTipItem();
            ITitleToolTip.Text = "操作提示";

            foreach (DataRowView drv in _ItemView)
            {
                NavBarItem additems = new NavBarItem();
                additems.Caption = drv.Row["MenuText"].ToString();
                additems.Tag = drv.Row["MenuNewID"].ToString();
                additems.Name = drv.Row["MenuName"].ToString();
                additems.SmallImage = Globals.LoadImage(drv.Row["MenuIcon"].ToString(), 32);
                IItemToolTip.Text = drv.Row["MenuTips"].ToString();
                IToolTip.Items.Clear();
                IToolTip.Items.Add(ITitleToolTip);
                IToolTip.Items.Add(IItemToolTip);
                additems.LinkClicked +=new NavBarLinkEventHandler(ADDItem_LinkClicked);
                NavGroup.ItemLinks.Add(additems);
            }

        }

        public void ADDItem_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            IOpenForm OpenFormClicked = new YIESysOpenForm();
            OpenFormClicked.OpenForm(e.Link.Item.Tag.ToString());

            
        }


       

    }
}
