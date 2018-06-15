using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
using YIEternalMIS.Common;
using YIEternalMIS.Model;
namespace YIEternalMIS.BLL {
	 	//YIESysDropData
		public partial class YIESysDropData
	{
   		     
		private readonly YIEternalMIS.DAL.YIESysDropData dal=new YIEternalMIS.DAL.YIESysDropData();
		public YIESysDropData()
		{}
		
		#region  Method
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(decimal DPXH)
		{
			return dal.Exists(DPXH);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public decimal  Add(YIEternalMIS.Model.YIESysDropData model)
		{
						return dal.Add(model);
						
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(YIEternalMIS.Model.YIESysDropData model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(decimal DPXH)
		{
			
			return dal.Delete(DPXH);
		}
				/// <summary>
		/// 批量删除一批数据
		/// </summary>
		public bool DeleteList(string DPXHlist )
		{
			return dal.DeleteList(DPXHlist );
		}
		
		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public YIEternalMIS.Model.YIESysDropData GetModel(decimal DPXH)
		{
			
			return dal.GetModel(DPXH);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
		public YIEternalMIS.Model.YIESysDropData GetModelByCache(decimal DPXH)
		{
			
			string CacheKey = "YIESysDropDataModel-" + DPXH;
			object objModel = YIEternalMIS.Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(DPXH);
					if (objModel != null)
					{
						int ModelCache = YIEternalMIS.Common.ConfigHelper.GetConfigInt("ModelCache");
						YIEternalMIS.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (YIEternalMIS.Model.YIESysDropData)objModel;
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
		public List<YIEternalMIS.Model.YIESysDropData> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<YIEternalMIS.Model.YIESysDropData> DataTableToList(DataTable dt)
		{
			List<YIEternalMIS.Model.YIESysDropData> modelList = new List<YIEternalMIS.Model.YIESysDropData>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				YIEternalMIS.Model.YIESysDropData model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new YIEternalMIS.Model.YIESysDropData();					
													if(dt.Rows[n]["DPXH"].ToString()!="")
				{
					model.DPXH=decimal.Parse(dt.Rows[n]["DPXH"].ToString());
				}
																																				model.DPName= dt.Rows[n]["DPName"].ToString();
																																model.ColName= dt.Rows[n]["ColName"].ToString();
																																model.ColText= dt.Rows[n]["ColText"].ToString();
																																model.ColValue= dt.Rows[n]["ColValue"].ToString();
																																model.ColDisplay= dt.Rows[n]["ColDisplay"].ToString();
																						
				
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