using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
using YIEternalMIS.Common;
using YIEternalMIS.Model;
namespace YIEternalMIS.BLL {
	 	//YIESysMenuBTNAuth
		public partial class YIESysMenuBTNAuth
	{
   		     
		private readonly YIEternalMIS.DAL.YIESysMenuBTNAuth dal=new YIEternalMIS.DAL.YIESysMenuBTNAuth();
		public YIESysMenuBTNAuth()
		{}
		
		#region  Method
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string MenuNewID,string BtnName)
		{
			return dal.Exists(MenuNewID,BtnName);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public void  Add(YIEternalMIS.Model.YIESysMenuBTNAuth model)
		{
						dal.Add(model);
						
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(YIEternalMIS.Model.YIESysMenuBTNAuth model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(string MenuNewID,string BtnName)
		{
			
			return dal.Delete(MenuNewID,BtnName);
		}
		
		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public YIEternalMIS.Model.YIESysMenuBTNAuth GetModel(string MenuNewID,string BtnName)
		{
			
			return dal.GetModel(MenuNewID,BtnName);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
		public YIEternalMIS.Model.YIESysMenuBTNAuth GetModelByCache(string MenuNewID,string BtnName)
		{
			
			string CacheKey = "YIESysMenuBTNAuthModel-" + MenuNewID+BtnName;
			object objModel = YIEternalMIS.Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(MenuNewID,BtnName);
					if (objModel != null)
					{
						int ModelCache = YIEternalMIS.Common.ConfigHelper.GetConfigInt("ModelCache");
						YIEternalMIS.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (YIEternalMIS.Model.YIESysMenuBTNAuth)objModel;
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
		public List<YIEternalMIS.Model.YIESysMenuBTNAuth> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<YIEternalMIS.Model.YIESysMenuBTNAuth> DataTableToList(DataTable dt)
		{
			List<YIEternalMIS.Model.YIESysMenuBTNAuth> modelList = new List<YIEternalMIS.Model.YIESysMenuBTNAuth>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				YIEternalMIS.Model.YIESysMenuBTNAuth model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new YIEternalMIS.Model.YIESysMenuBTNAuth();					
																	model.MenuNewID= dt.Rows[n]["MenuNewID"].ToString();
																																model.BtnName= dt.Rows[n]["BtnName"].ToString();
																																model.BtnText= dt.Rows[n]["BtnText"].ToString();
																																model.BtnImg= dt.Rows[n]["BtnImg"].ToString();
																																model.BtnAuthority= dt.Rows[n]["BtnAuthority"].ToString();
																																model.BtnIsToolBar= dt.Rows[n]["BtnIsToolBar"].ToString();
																																model.BtnTips= dt.Rows[n]["BtnTips"].ToString();
																																model.BtnGroupID= dt.Rows[n]["BtnGroupID"].ToString();
																																model.BtnVisible= dt.Rows[n]["BtnVisible"].ToString();
																																model.BtnEnabled= dt.Rows[n]["BtnEnabled"].ToString();
																												if(dt.Rows[n]["BtnSort"].ToString()!="")
				{
					model.BtnSort=int.Parse(dt.Rows[n]["BtnSort"].ToString());
				}
																																if(dt.Rows[n]["BtnToolBarSort"].ToString()!="")
				{
					model.BtnToolBarSort=int.Parse(dt.Rows[n]["BtnToolBarSort"].ToString());
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