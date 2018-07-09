using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SqlSugar;

namespace Models
{
    [SugarTable("YIEMYUser")]
    public class YIEMYUserDb
    {
        public YIEMYUserDb()
        { }
        #region Model
        private string _loginid;
        private string _loginname;
        private string _password;
        private string _roleid;
        private string _deptid;
        private string _deptname;
        private string _loginstate;
        private string _xb;
        private string _zw;
        private DateTime? _csrq;
        private string _jtdz;
        private string _ydtel;
        private string _gdtel;
        private string _xl;
        private string _userstate;
        private string _bz;
        private string _zfbz;
        private DateTime? _lrsj;
        private string _lrruserid;
        private DateTime? _loginindate;
        private DateTime? _loginoutdate;
        /// <summary>
        /// 登录用户编号
        /// </summary>
        [SugarColumn(IsPrimaryKey = true)]
        public string Loginid
        {
            set { _loginid = value; }
            get { return _loginid; }
        }
        /// <summary>
        /// 登录用户名
        /// </summary>
        public string LoginName
        {
            set { _loginname = value; }
            get { return _loginname; }
        }
        /// <summary>
        /// 密码
        /// </summary>
        public string PassWord
        {
            set { _password = value; }
            get { return _password; }
        }
        /// <summary>
        /// 角色编号
        /// </summary>
        public string RoleID
        {
            set { _roleid = value; }
            get { return _roleid; }
        }
        /// <summary>
        /// 部门编号
        /// </summary>
        public string DeptID
        {
            set { _deptid = value; }
            get { return _deptid; }
        }
        /// <summary>
        /// 部门名称
        /// </summary>
        public string DeptName
        {
            set { _deptname = value; }
            get { return _deptname; }
        }
        /// <summary>
        /// 登录状态(1.当前登录，0当前未登录)
        /// </summary>
        public string LoginState
        {
            set { _loginstate = value; }
            get { return _loginstate; }
        }
        /// <summary>
        /// 性别
        /// </summary>
        public string Xb
        {
            set { _xb = value; }
            get { return _xb; }
        }
        /// <summary>
        /// 职务
        /// </summary>
        public string Zw
        {
            set { _zw = value; }
            get { return _zw; }
        }
        /// <summary>
        /// 出生日期
        /// </summary>
        public DateTime? Csrq
        {
            set { _csrq = value; }
            get { return _csrq; }
        }
        /// <summary>
        /// 家庭地址
        /// </summary>
        public string Jtdz
        {
            set { _jtdz = value; }
            get { return _jtdz; }
        }
        /// <summary>
        /// 手机
        /// </summary>
        public string YdTel
        {
            set { _ydtel = value; }
            get { return _ydtel; }
        }
        /// <summary>
        /// 固定电话
        /// </summary>
        public string GDTel
        {
            set { _gdtel = value; }
            get { return _gdtel; }
        }
        /// <summary>
        /// 学历
        /// </summary>
        public string Xl
        {
            set { _xl = value; }
            get { return _xl; }
        }
        /// <summary>
        /// 员工状态（1、正常 2、已离职 ）
        /// </summary>
        public string Userstate
        {
            set { _userstate = value; }
            get { return _userstate; }
        }
        /// <summary>
        /// 备注说明
        /// </summary>
        public string Bz
        {
            set { _bz = value; }
            get { return _bz; }
        }
        /// <summary>
        /// 作废状态（1、作废 0、正常）
        /// </summary>
        public string Zfbz
        {
            set { _zfbz = value; }
            get { return _zfbz; }
        }
        /// <summary>
        /// 账号登记时间
        /// </summary>
        public DateTime? Lrsj
        {
            set { _lrsj = value; }
            get { return _lrsj; }
        }
        /// <summary>
        /// 账号登记人
        /// </summary>
        public string LrrUserid
        {
            set { _lrruserid = value; }
            get { return _lrruserid; }
        }
        /// <summary>
        /// 最后登陆时间
        /// </summary>
        public DateTime? LoginInDate
        {
            set { _loginindate = value; }
            get { return _loginindate; }
        }
        /// <summary>
        /// 最后登出时间
        /// </summary>
        public DateTime? LoginOutDate
        {
            set { _loginoutdate = value; }
            get { return _loginoutdate; }
        }
        #endregion Model

    }
}
