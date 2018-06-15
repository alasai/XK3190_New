/*************************************************************************************
     * 类 名 称：       IModuleNavAndForm
     * 命名空间：       YIEternalMIS.Interfaces
     * 文 件 名：       IModuleNavAndForm
     * 创建时间：       2017/6/9 13:19:04
     * 作    者：        王宏巍
     * 说   明：
     * 修改时间：
     * 修 改 人：
 *************************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.XtraNavBar;

namespace YIEternalMIS.Interfaces
{
    public interface IModuleNavAndForm
    {
        void MainModule(NavBarControl MainCon);

        void AddNavGroup(NavBarControl NavMain);

        void AddNavItem(NavBarGroup NavGroup, string sParentMenuID);

        void ADDItem_LinkClicked(object sender, NavBarLinkEventArgs e);
    }
}
