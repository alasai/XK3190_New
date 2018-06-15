using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
namespace YIEternalMIS.Model{
	 	//YIEMYRoleBtnPer
		public class YIEMYRoleBtnPer
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
		/// BtnName
        /// </summary>		
		private string _btnname;
        public string BtnName
        {
            get{ return _btnname; }
            set{ _btnname = value; }
        }        
		/// <summary>
		/// BtnPermission
        /// </summary>		
		private string _btnpermission;
        public string BtnPermission
        {
            get{ return _btnpermission; }
            set{ _btnpermission = value; }
        }        
		   
	}
}

