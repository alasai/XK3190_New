/*************************************************************************************
    * 类 名 称：       tb_DataSet
    * 命名空间：       YIEternalMIS.Model
    * 文 件 名：       tb_DataSet
    * 创建时间：       2017/6/5 14:35:42
    * 作    者：        王宏巍
    * 说   明：
    * 修改时间：
    * 修 改 人：
*************************************************************************************/
using System;
namespace YIEternalMIS.Model
{
    /// <summary>
    /// tb_DataSet:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class tb_DataSet
    {
        public tb_DataSet()
        { }
        #region Model
        private int _isid;
        private string _datasetid;
        private string _datasetname;
        private string _serverip;
        private string _dbname;
        private string _dbusername;
        private string _dbuserpassword;
        private string _remark;
        /// <summary>
        /// 
        /// </summary>
        public int isid
        {
            set { _isid = value; }
            get { return _isid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string DataSetID
        {
            set { _datasetid = value; }
            get { return _datasetid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string DataSetName
        {
            set { _datasetname = value; }
            get { return _datasetname; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ServerIP
        {
            set { _serverip = value; }
            get { return _serverip; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string DBName
        {
            set { _dbname = value; }
            get { return _dbname; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string DBUserName
        {
            set { _dbusername = value; }
            get { return _dbusername; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string DBUserPassword
        {
            set { _dbuserpassword = value; }
            get { return _dbuserpassword; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Remark
        {
            set { _remark = value; }
            get { return _remark; }
        }
        #endregion Model

    }
}


