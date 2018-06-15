using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
namespace YIEternalMIS.Model{
	 	//YIESysSubSystem
		public class YIESysSubSystem
	{
   		     
      	/// <summary>
		/// SysId
        /// </summary>		
		private string _sysid;
        public string SysId
        {
            get{ return _sysid; }
            set{ _sysid = value; }
        }        
		/// <summary>
		/// SysName
        /// </summary>		
		private string _sysname;
        public string SysName
        {
            get{ return _sysname; }
            set{ _sysname = value; }
        }        
		/// <summary>
		/// Licenses
        /// </summary>		
		private string _licenses;
        public string Licenses
        {
            get{ return _licenses; }
            set{ _licenses = value; }
        }        
		   
	}
}

