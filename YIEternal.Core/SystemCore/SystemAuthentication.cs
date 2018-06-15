/*************************************************************************************
    * 类 名 称：       SystemAuthentication
    * 命名空间：       YIEternalMIS.Core
    * 文 件 名：       SystemAuthentication
    * 创建时间：       2017/6/2 15:36:45
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
using YIEternalMIS.Interfaces;
using YIEternalMIS.Common;
using YIEternalMIS.Core.SystemCore;

namespace YIEternalMIS.Core
{
    public class SystemAuthentication
    {
        /// <summary>
        /// 当前用户的权限数据
        /// </summary>
        private static DataTable _UserAuthorities = null;

        /// <summary>
        /// 子系统权限数据
        /// </summary>
        private static DataTable _SysAuthorities = null;


        /// <summary>
        /// 窗体按钮权限数据
        /// </summary>
        private static DataTable _FormBtnAuthorities = null;

        /// <summary>
        /// 当前用户的权限数据 窗体访问权限
        /// </summary>
        public static DataTable UserAuthorities
        {
            get { return _UserAuthorities; }
            set { _UserAuthorities = value; }
        }

        /// <summary>
        /// 用户子系统权限
        /// </summary>
        public static DataTable SysAuthorities
        {
            get { return _SysAuthorities; }
            set { _SysAuthorities = value; }
        }

        /// <summary>
        /// 用户窗体按钮权限表
        /// </summary>
        public static DataTable FormBtnAuthorities
        {
            set { _FormBtnAuthorities = value; }
            get { return _FormBtnAuthorities; }
        }
        /// <summary>
        /// 系统登录策略
        /// </summary>
        private static ILoginAuthorization _Current = null;

        /// <summary>
        /// 系统预设的授权模式
        /// </summary>
        public static ILoginAuthorization Current
        {
            get { return _Current; }
            set { _Current = value; }
        }

        /// <summary>
        /// 当前登录的用户
        /// </summary>
        public static Loginer User
        {
            get { return Loginer.CurrentUser; }
        }

       public static  List<MenuListDto> SystemMenuList { get; set; }
    }
}
