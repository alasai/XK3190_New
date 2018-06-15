/*************************************************************************************
    * 类 名 称：       V_YIEBtnRolePER
    * 命名空间：       YIEternalMIS.Model
    * 文 件 名：       V_YIEBtnRolePER
    * 创建时间：       2017/6/8 10:15:35
    * 作    者：        王宏巍
    * 说   明：
    * 修改时间：
    * 修 改 人：
*************************************************************************************/
using System;
namespace YIEternalMIS.Model
{
    /// <summary>
    /// V_YIEBtnRolePER:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class V_YIEBtnRolePER
    {
        public V_YIEBtnRolePER()
        { }
        #region Model
        private string _roleid;
        private string _btnpermission;
        private string _menunewid;
        private string _btnname;
        private string _btntext;
        private string _btnimg;
        private string _btnauthority;
        private string _btnistoolbar;
        private string _btntips;
        private string _btngroupid;
        private string _btnvisible;
        private string _btnwlog;
        private int? _btnsort;
        private int? _btntoolbarsort;
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
        public string BtnPermission
        {
            set { _btnpermission = value; }
            get { return _btnpermission; }
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
        public string BtnName
        {
            set { _btnname = value; }
            get { return _btnname; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string BtnText
        {
            set { _btntext = value; }
            get { return _btntext; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string BtnImg
        {
            set { _btnimg = value; }
            get { return _btnimg; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string BtnAuthority
        {
            set { _btnauthority = value; }
            get { return _btnauthority; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string BtnIsToolBar
        {
            set { _btnistoolbar = value; }
            get { return _btnistoolbar; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string BtnTips
        {
            set { _btntips = value; }
            get { return _btntips; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string BtnGroupID
        {
            set { _btngroupid = value; }
            get { return _btngroupid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string BtnVisible
        {
            set { _btnvisible = value; }
            get { return _btnvisible; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string BtnWlog
        {
            set { _btnwlog = value; }
            get { return _btnwlog; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? BtnSort
        {
            set { _btnsort = value; }
            get { return _btnsort; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? BtnToolBarSort
        {
            set { _btntoolbarsort = value; }
            get { return _btntoolbarsort; }
        }
        #endregion Model

    }
}


