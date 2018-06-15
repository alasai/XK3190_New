/*************************************************************************************
    * 类 名 称：       V_YIEFormRolePER
    * 命名空间：       YIEternalMIS.Model
    * 文 件 名：       V_YIEFormRolePER
    * 创建时间：       2017/6/8 10:20:20
    * 作    者：        王宏巍
    * 说   明：
    * 修改时间：
    * 修 改 人：
*************************************************************************************/
using System;
namespace YIEternalMIS.Model
{
    /// <summary>
        /// V_YIEFormRolePER:实体类(属性说明自动提取数据库字段的描述信息)
        /// </summary>
        [Serializable]
        public partial class V_YIEFormRolePER
        {
            public V_YIEFormRolePER()
            { }
            #region Model
            private string _roleid;
            private string _permission;
            private string _sysid;
            private string _sysname;
            private string _menuid;
            private string _parentmenuid;
            private int? _menulevel;
            private string _menuicon;
            private string _menuname;
            private string _menutext;
            private string _tabtext;
            private int? _menuorder;
            private string _menuisbutton;
            private int? _menuvisible;
            private string _menutips;
            private string _openassembly;
            private string _openformclassname;
            private int? _opentype;
            private string _menunewid;
            private string _countbz;
            /// <summary>
            /// 
            /// </summary>
            public string RoleID
            {
                set { _roleid = value; }
                get { return _roleid; }
            }
            /// <summary>
            /// 
            /// </summary>
            public string Permission
            {
                set { _permission = value; }
                get { return _permission; }
            }
            /// <summary>
            /// 
            /// </summary>
            public string SysId
            {
                set { _sysid = value; }
                get { return _sysid; }
            }
            /// <summary>
            /// 
            /// </summary>
            public string SysName
            {
                set { _sysname = value; }
                get { return _sysname; }
            }
            /// <summary>
            /// 
            /// </summary>
            public string MenuID
            {
                set { _menuid = value; }
                get { return _menuid; }
            }
            /// <summary>
            /// 
            /// </summary>
            public string ParentMenuID
            {
                set { _parentmenuid = value; }
                get { return _parentmenuid; }
            }
            /// <summary>
            /// 
            /// </summary>
            public int? MenuLevel
            {
                set { _menulevel = value; }
                get { return _menulevel; }
            }
            /// <summary>
            /// 
            /// </summary>
            public string MenuIcon
            {
                set { _menuicon = value; }
                get { return _menuicon; }
            }
            /// <summary>
            /// 
            /// </summary>
            public string MenuName
            {
                set { _menuname = value; }
                get { return _menuname; }
            }
            /// <summary>
            /// 
            /// </summary>
            public string MenuText
            {
                set { _menutext = value; }
                get { return _menutext; }
            }
            /// <summary>
            /// 
            /// </summary>
            public string TabText
            {
                set { _tabtext = value; }
                get { return _tabtext; }
            }
            /// <summary>
            /// 
            /// </summary>
            public int? MenuOrder
            {
                set { _menuorder = value; }
                get { return _menuorder; }
            }
            /// <summary>
            /// 
            /// </summary>
            public string MenuIsButton
            {
                set { _menuisbutton = value; }
                get { return _menuisbutton; }
            }
            /// <summary>
            /// 
            /// </summary>
            public int? MenuVisible
            {
                set { _menuvisible = value; }
                get { return _menuvisible; }
            }
            /// <summary>
            /// 
            /// </summary>
            public string MenuTips
            {
                set { _menutips = value; }
                get { return _menutips; }
            }
            /// <summary>
            /// 
            /// </summary>
            public string OpenAssembly
            {
                set { _openassembly = value; }
                get { return _openassembly; }
            }
            /// <summary>
            /// 
            /// </summary>
            public string OpenFormClassName
            {
                set { _openformclassname = value; }
                get { return _openformclassname; }
            }
            /// <summary>
            /// 
            /// </summary>
            public int? OpenType
            {
                set { _opentype = value; }
                get { return _opentype; }
            }
            /// <summary>
            /// 
            /// </summary>
            public string MenuNewID
            {
                set { _menunewid = value; }
                get { return _menunewid; }
            }
            /// <summary>
            /// 
            /// </summary>
            public string CountBZ
            {
                set { _countbz = value; }
                get { return _countbz; }
            }
            #endregion Model

        }
    }



