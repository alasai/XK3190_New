using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
using YIEternalMIS.Common;
using YIEternalMIS.Model;
namespace YIEternalMIS.BLL {
	 	//YIESysBTNDefault
		public partial class YIESysBTNDefault
	{
   		     
		private readonly YIEternalMIS.DAL.YIESysBTNDefault dal=new YIEternalMIS.DAL.YIESysBTNDefault();
		public YIESysBTNDefault()
		{}
		
		#region  Method
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string BtnName)
		{
			return dal.Exists(BtnName);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public void  Add(YIEternalMIS.Model.YIESysBTNDefault model)
		{
						dal.Add(model);
						
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(YIEternalMIS.Model.YIESysBTNDefault model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(string BtnName)
		{
			
			return dal.Delete(BtnName);
		}
		
		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public YIEternalMIS.Model.YIESysBTNDefault GetModel(string BtnName)
		{
			
			return dal.GetModel(BtnName);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
		public YIEternalMIS.Model.YIESysBTNDefault GetModelByCache(string BtnName)
		{
			
			string CacheKey = "YIESysBTNDefaultModel-" + BtnName;
			object objModel = YIEternalMIS.Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(BtnName);
					if (objModel != null)
					{
						int ModelCache = YIEternalMIS.Common.ConfigHelper.GetConfigInt("ModelCache");
						YIEternalMIS.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (YIEternalMIS.Model.YIESysBTNDefault)objModel;
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
		public List<YIEternalMIS.Model.YIESysBTNDefault> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<YIEternalMIS.Model.YIESysBTNDefault> DataTableToList(DataTable dt)
		{
			List<YIEternalMIS.Model.YIESysBTNDefault> modelList = new List<YIEternalMIS.Model.YIESysBTNDefault>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				YIEternalMIS.Model.YIESysBTNDefault model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new YIEternalMIS.Model.YIESysBTNDefault();					
																	model.BtnName= dt.Rows[n]["BtnName"].ToString();
																																model.BtnText= dt.Rows[n]["BtnText"].ToString();
																																model.BtnIMG= dt.Rows[n]["BtnIMG"].ToString();
																																model.BtnAuthority= dt.Rows[n]["BtnAuthority"].ToString();
																																model.BtnIsToolBar= dt.Rows[n]["BtnIsToolBar"].ToString();
																																model.BtnTips= dt.Rows[n]["BtnTips"].ToString();
																																model.BtnGroupID= dt.Rows[n]["BtnGroupID"].ToString();
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