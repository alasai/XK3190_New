/*************************************************************************************
    * 类 名 称：       YIESystemMSG
    * 命名空间：       YIEternalMIS.Model
    * 文 件 名：       YIESystemMSG
    * 创建时间：       2017/6/23 10:52:45
    * 作    者：        王宏巍
    * 说   明：
    * 修改时间：
    * 修 改 人：
*************************************************************************************/
using System;
namespace YIEternalMIS.Model
{
    /// <summary>
    /// YIESystemMSG:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class YIESystemMSG
    {
        public YIESystemMSG()
        { }
        #region Model
        private string _msgid = "newid";
        private string _msgtitle;
        private string _msgup;
        private string _msgtext;
        private string _loginid;
        private string _loginname;
        private DateTime? _msgrelease = DateTime.Now;
        private DateTime? _msgsdate;
        private DateTime? _msgedate;
        private int? _msgexpiry;
        private string _msgtype;
        /// <summary>
        /// 信息编号
        /// </summary>
        public string MsgID
        {
            set { _msgid = value; }
            get { return _msgid; }
        }
        /// <summary>
        /// 公告标题
        /// </summary>
        public string MsgTitle
        {
            set { _msgtitle = value; }
            get { return _msgtitle; }
        }
        /// <summary>
        /// 置顶标志
        /// </summary>
        public string MsgUp
        {
            set { _msgup = value; }
            get { return _msgup; }
        }
        /// <summary>
        /// 信息内容
        /// </summary>
        public string MsgText
        {
            set { _msgtext = value; }
            get { return _msgtext; }
        }
        /// <summary>
        /// 发布人编号
        /// </summary>
        public string Loginid
        {
            set { _loginid = value; }
            get { return _loginid; }
        }
        /// <summary>
        /// 发布人姓名
        /// </summary>
        public string LoginName
        {
            set { _loginname = value; }
            get { return _loginname; }
        }
        /// <summary>
        /// 发布日期
        /// </summary>
        public DateTime? MsgRelease
        {
            set { _msgrelease = value; }
            get { return _msgrelease; }
        }
        /// <summary>
        /// 公告开始时间
        /// </summary>
        public DateTime? MsgSdate
        {
            set { _msgsdate = value; }
            get { return _msgsdate; }
        }
        /// <summary>
        /// 公告结束日期
        /// </summary>
        public DateTime? MsgEdate
        {
            set { _msgedate = value; }
            get { return _msgedate; }
        }
        /// <summary>
        /// 公告有效期-1永久、以天为单位
        /// </summary>
        public int? MsgExpiry
        {
            set { _msgexpiry = value; }
            get { return _msgexpiry; }
        }
        /// <summary>
        /// 公告类型1、行政公告、2通知公告、3、处罚公告
        /// </summary>
        public string MsgType
        {
            set { _msgtype = value; }
            get { return _msgtype; }
        }
        #endregion Model

    }
}

