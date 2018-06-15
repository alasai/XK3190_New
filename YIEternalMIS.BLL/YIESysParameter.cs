using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
using YIEternalMIS.Common;
using YIEternalMIS.Model;
namespace YIEternalMIS.BLL {
	 	//YIESysParameter
		public partial class YIESysParameter
	{
   		     
		private readonly YIEternalMIS.DAL.YIESysParameter dal=new YIEternalMIS.DAL.YIESysParameter();
		public YIESysParameter()
		{}
		
		#region  Method
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(decimal Sysxh)
		{
			return dal.Exists(Sysxh);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public decimal  Add(YIEternalMIS.Model.YIESysParameter model)
		{
						return dal.Add(model);
						
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(YIEternalMIS.Model.YIESysParameter model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(decimal Sysxh)
		{
			
			return dal.Delete(Sysxh);
		}
				/// <summary>
		/// 批量删除一批数据
		/// </summary>
		public bool DeleteList(string Sysxhlist )
		{
			return dal.DeleteList(Sysxhlist );
		}
		
		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public YIEternalMIS.Model.YIESysParameter GetModel(decimal Sysxh)
		{
			
			return dal.GetModel(Sysxh);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
		public YIEternalMIS.Model.YIESysParameter GetModelByCache(decimal Sysxh)
		{
			
			string CacheKey = "YIESysParameterModel-" + Sysxh;
			object objModel = YIEternalMIS.Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(Sysxh);
					if (objModel != null)
					{
						int ModelCache = YIEternalMIS.Common.ConfigHelper.GetConfigInt("ModelCache");
						YIEternalMIS.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (YIEternalMIS.Model.YIESysParameter)objModel;
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
		public List<YIEternalMIS.Model.YIESysParameter> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<YIEternalMIS.Model.YIESysParameter> DataTableToList(DataTable dt)
		{
			List<YIEternalMIS.Model.YIESysParameter> modelList = new List<YIEternalMIS.Model.YIESysParameter>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				YIEternalMIS.Model.YIESysParameter model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new YIEternalMIS.Model.YIESysParameter();					
													if(dt.Rows[n]["Sysxh"].ToString()!="")
				{
					model.Sysxh=decimal.Parse(dt.Rows[n]["Sysxh"].ToString());
				}
																																				model.SysText= dt.Rows[n]["SysText"].ToString();
																																model.SysValue= dt.Rows[n]["SysValue"].ToString();
																												if(dt.Rows[n]["SysSdate"].ToString()!="")
				{
					model.SysSdate=DateTime.Parse(dt.Rows[n]["SysSdate"].ToString());
				}
																																if(dt.Rows[n]["SysEdate"].ToString()!="")
				{
					model.SysEdate=DateTime.Parse(dt.Rows[n]["SysEdate"].ToString());
				}
																																				model.UserEdit= dt.Rows[n]["UserEdit"].ToString();
																																model.zfbz= dt.Rows[n]["zfbz"].ToString();
																						
				
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