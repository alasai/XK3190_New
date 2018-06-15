using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
namespace YIEternalMIS.Model{
	 	//YIESysRegister
		public class YIESysRegister
	{
   		     
      	/// <summary>
		/// YIEID
        /// </summary>		
		private int _yieid;
        public int YIEID
        {
            get{ return _yieid; }
            set{ _yieid = value; }
        }        
		/// <summary>
		/// YIEApplication
        /// </summary>		
		private string _yieapplication;
        public string YIEApplication
        {
            get{ return _yieapplication; }
            set{ _yieapplication = value; }
        }        
		/// <summary>
		/// YIEMSGTitle
        /// </summary>		
		private string _yiemsgtitle;
        public string YIEMSGTitle
        {
            get{ return _yiemsgtitle; }
            set{ _yiemsgtitle = value; }
        }        
		/// <summary>
		/// YIEAuthorizeUser
        /// </summary>		
		private string _yieauthorizeuser;
        public string YIEAuthorizeUser
        {
            get{ return _yieauthorizeuser; }
            set{ _yieauthorizeuser = value; }
        }        
		/// <summary>
		/// YIELicenses
        /// </summary>		
		private string _yielicenses;
        public string YIELicenses
        {
            get{ return _yielicenses; }
            set{ _yielicenses = value; }
        }        
		/// <summary>
		/// Sdate
        /// </summary>		
		private DateTime _sdate;
        public DateTime Sdate
        {
            get{ return _sdate; }
            set{ _sdate = value; }
        }        
		/// <summary>
		/// Edate
        /// </summary>		
		private DateTime _edate;
        public DateTime Edate
        {
            get{ return _edate; }
            set{ _edate = value; }
        }        
		/// <summary>
		/// SysType
        /// </summary>		
		private int _systype;
        public int SysType
        {
            get{ return _systype; }
            set{ _systype = value; }
        }        
		   
	}
}

