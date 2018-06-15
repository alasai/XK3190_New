using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
namespace YIEternalMIS.Model{
	 	//YIESysParameter
		public class YIESysParameter
	{
   		     
      	/// <summary>
		/// Sysxh
        /// </summary>		
		private decimal _sysxh;
        public decimal Sysxh
        {
            get{ return _sysxh; }
            set{ _sysxh = value; }
        }        
		/// <summary>
		/// SysText
        /// </summary>		
		private string _systext;
        public string SysText
        {
            get{ return _systext; }
            set{ _systext = value; }
        }        
		/// <summary>
		/// SysValue
        /// </summary>		
		private string _sysvalue;
        public string SysValue
        {
            get{ return _sysvalue; }
            set{ _sysvalue = value; }
        }        
		/// <summary>
		/// SysSdate
        /// </summary>		
		private DateTime _syssdate;
        public DateTime SysSdate
        {
            get{ return _syssdate; }
            set{ _syssdate = value; }
        }        
		/// <summary>
		/// SysEdate
        /// </summary>		
		private DateTime _sysedate;
        public DateTime SysEdate
        {
            get{ return _sysedate; }
            set{ _sysedate = value; }
        }        
		/// <summary>
		/// UserEdit
        /// </summary>		
		private string _useredit;
        public string UserEdit
        {
            get{ return _useredit; }
            set{ _useredit = value; }
        }        
		/// <summary>
		/// zfbz
        /// </summary>		
		private string _zfbz;
        public string zfbz
        {
            get{ return _zfbz; }
            set{ _zfbz = value; }
        }        
		   
	}
}

