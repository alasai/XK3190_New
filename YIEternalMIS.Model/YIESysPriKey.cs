using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
namespace YIEternalMIS.Model{
	 	//YIESysPriKey
		public class YIESysPriKey
	{
   		     
      	/// <summary>
		/// 主键生成表编号 系统自动生成
        /// </summary>		
		private int _nameid;
        public int NameID
        {
            get{ return _nameid; }
            set{ _nameid = value; }
        }        
		/// <summary>
		/// 主键名称 产生那种编号
        /// </summary>		
		private string _name;
        public string Name
        {
            get{ return _name; }
            set{ _name = value; }
        }        
		/// <summary>
		/// 最后产生编号的day
        /// </summary>		
		private int _days;
        public int Days
        {
            get{ return _days; }
            set{ _days = value; }
        }        
		/// <summary>
		/// 产生编号的主键头 CS
        /// </summary>		
		private string _head;
        public string Head
        {
            get{ return _head; }
            set{ _head = value; }
        }        
		/// <summary>
		/// 当前产生最大主键排序号
        /// </summary>		
		private int _currentno;
        public int CurrentNo
        {
            get{ return _currentno; }
            set{ _currentno = value; }
        }        
		/// <summary>
		/// 流水位长度
        /// </summary>		
		private int _bhlen;
        public int BHLen
        {
            get{ return _bhlen; }
            set{ _bhlen = value; }
        }        
		/// <summary>
		/// 最后产生编号年月
        /// </summary>		
		private int _yearmoth;
        public int Yearmoth
        {
            get{ return _yearmoth; }
            set{ _yearmoth = value; }
        }        
		/// <summary>
		/// 功能描述
        /// </summary>		
		private string _description;
        public string DESCRIPTION
        {
            get{ return _description; }
            set{ _description = value; }
        }        
		/// <summary>
		/// 产生主键的表名
        /// </summary>		
		private string _tablename;
        public string TableName
        {
            get{ return _tablename; }
            set{ _tablename = value; }
        }        
		/// <summary>
		/// 表明对应的列名
        /// </summary>		
		private string _keyfieldname;
        public string keyfieldName
        {
            get{ return _keyfieldname; }
            set{ _keyfieldname = value; }
        }        
		/// <summary>
		/// 用户修改标志
        /// </summary>		
		private string _userbz;
        public string userbz
        {
            get{ return _userbz; }
            set{ _userbz = value; }
        }        
		   
	}
}

