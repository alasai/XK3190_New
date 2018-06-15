using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
namespace YIEternalMIS.Model{
	 	//YIESysDropData
		public class YIESysDropData
	{
   		     
      	/// <summary>
		/// DPXH
        /// </summary>		
		private decimal _dpxh;
        public decimal DPXH
        {
            get{ return _dpxh; }
            set{ _dpxh = value; }
        }        
		/// <summary>
		/// DPName
        /// </summary>		
		private string _dpname;
        public string DPName
        {
            get{ return _dpname; }
            set{ _dpname = value; }
        }        
		/// <summary>
		/// ColName
        /// </summary>		
		private string _colname;
        public string ColName
        {
            get{ return _colname; }
            set{ _colname = value; }
        }        
		/// <summary>
		/// ColText
        /// </summary>		
		private string _coltext;
        public string ColText
        {
            get{ return _coltext; }
            set{ _coltext = value; }
        }        
		/// <summary>
		/// ColValue
        /// </summary>		
		private string _colvalue;
        public string ColValue
        {
            get{ return _colvalue; }
            set{ _colvalue = value; }
        }        
		/// <summary>
		/// ColDisplay
        /// </summary>		
		private string _coldisplay;
        public string ColDisplay
        {
            get{ return _coldisplay; }
            set{ _coldisplay = value; }
        }        
		   
	}
}

