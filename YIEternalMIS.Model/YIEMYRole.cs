using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
namespace YIEternalMIS.Model{
	 	//YIEMYRole
		public class YIEMYRole
	{
   		     
      	/// <summary>
		/// RoleID
        /// </summary>		
		private string _roleid;
        public string RoleID
        {
            get{ return _roleid; }
            set{ _roleid = value; }
        }        
		/// <summary>
		/// RoleName
        /// </summary>		
		private string _rolename;
        public string RoleName
        {
            get{ return _rolename; }
            set{ _rolename = value; }
        }        
		/// <summary>
		/// RoleBZ
        /// </summary>		
		private string _rolebz;
        public string RoleBZ
        {
            get{ return _rolebz; }
            set{ _rolebz = value; }
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

