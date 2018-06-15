using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
namespace YIEternalMIS.Model{
	 	//YIEMYRoleMenuPer
		public class YIEMYRoleMenuPer
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
		/// MenuNewID
        /// </summary>		
		private string _menunewid;
        public string MenuNewID
        {
            get{ return _menunewid; }
            set{ _menunewid = value; }
        }        
		/// <summary>
		/// Permission
        /// </summary>		
		private string _permission;
        public string Permission
        {
            get{ return _permission; }
            set{ _permission = value; }
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

