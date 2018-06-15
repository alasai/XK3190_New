using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
using YIEternalMIS.Common;
using YIEternalMIS.Model;
namespace YIEternalMIS.BLL {
	 	//YIESysRegister
		public partial class YIESysRegister
	{
   		     
		private readonly YIEternalMIS.DAL.YIESysRegister dal=new YIEternalMIS.DAL.YIESysRegister();
		public YIESysRegister()
		{}
		
		#region  Method
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int YIEID)
		{
			return dal.Exists(YIEID);
		}
        /// <summary>
        /// 返回系统时间
        /// </summary>
        /// <returns></returns>
        public DateTime GetServerDateTime()
        {
            return  dal.GetServerDateTime();
        }
		/// <summary>
		/// 增加一条数据
		/// </summary>
		public void  Add(YIEternalMIS.Model.YIESysRegister model)
		{
						dal.Add(model);
						
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(YIEternalMIS.Model.YIESysRegister model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int YIEID)
		{
			
			return dal.Delete(YIEID);
		}
		
		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public YIEternalMIS.Model.YIESysRegister GetModel(int YIEID)
		{
			
			return dal.GetModel(YIEID);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
		public YIEternalMIS.Model.YIESysRegister GetModelByCache(int YIEID)
		{
			
			string CacheKey = "YIESysRegisterModel-" + YIEID;
			object objModel = YIEternalMIS.Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(YIEID);
					if (objModel != null)
					{
						int ModelCache = YIEternalMIS.Common.ConfigHelper.GetConfigInt("ModelCache");
						YIEternalMIS.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (YIEternalMIS.Model.YIESysRegister)objModel;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			return dal.GetList(strWhere);
		}
		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			return dal.GetList(Top,strWhere,filedOrder);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<YIEternalMIS.Model.YIESysRegister> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<YIEternalMIS.Model.YIESysRegister> DataTableToList(DataTable dt)
		{
			List<YIEternalMIS.Model.YIESysRegister> modelList = new List<YIEternalMIS.Model.YIESysRegister>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				YIEternalMIS.Model.YIESysRegister model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new YIEternalMIS.Model.YIESysRegister();					
													if(dt.Rows[n]["YIEID"].ToString()!="")
				{
					model.YIEID=int.Parse(dt.Rows[n]["YIEID"].ToString());
				}
																																				model.YIEApplication= dt.Rows[n]["YIEApplication"].ToString();
																																model.YIEMSGTitle= dt.Rows[n]["YIEMSGTitle"].ToString();
																																model.YIEAuthorizeUser= dt.Rows[n]["YIEAuthorizeUser"].ToString();
																																model.YIELicenses= dt.Rows[n]["YIELicenses"].ToString();
																												if(dt.Rows[n]["Sdate"].ToString()!="")
				{
					model.Sdate=DateTime.Parse(dt.Rows[n]["Sdate"].ToString());
				}
																																if(dt.Rows[n]["Edate"].ToString()!="")
				{
					model.Edate=DateTime.Parse(dt.Rows[n]["Edate"].ToString());
				}
																																if(dt.Rows[n]["SysType"].ToString()!="")
				{
					model.SysType=int.Parse(dt.Rows[n]["SysType"].ToString());
				}
																										
				
					modelList.Add(model);
				}
			}
			return modelList;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetAllList()
		{
			return GetList("");
		}
#endregion
   
	}
}