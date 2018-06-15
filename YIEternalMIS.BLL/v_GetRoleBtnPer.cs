using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
using YIEternalMIS.Common;
using YIEternalMIS.Model;
namespace YIEternalMIS.BLL {
	 	//v_GetRoleBtnPer
		public partial class v_GetRoleBtnPer
	{
   		     
		private readonly YIEternalMIS.DAL.v_GetRoleBtnPer dal=new YIEternalMIS.DAL.v_GetRoleBtnPer();
		public v_GetRoleBtnPer()
		{}
		
		#region  Method
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists()
		{
			return dal.Exists();
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public void  Add(YIEternalMIS.Model.v_GetRoleBtnPer model)
		{
						dal.Add(model);
						
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(YIEternalMIS.Model.v_GetRoleBtnPer model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete()
		{
			
			return dal.Delete();
		}
		
		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public YIEternalMIS.Model.v_GetRoleBtnPer GetModel()
		{
			
			return dal.GetModel();
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
		public YIEternalMIS.Model.v_GetRoleBtnPer GetModelByCache()
		{
			
			string CacheKey = "v_GetRoleBtnPerModel-" + ;
			object objModel = YIEternalMIS.Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel();
					if (objModel != null)
					{
						int ModelCache = YIEternalMIS.Common.ConfigHelper.GetConfigInt("ModelCache");
						YIEternalMIS.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (YIEternalMIS.Model.v_GetRoleBtnPer)objModel;
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
		public List<YIEternalMIS.Model.v_GetRoleBtnPer> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<YIEternalMIS.Model.v_GetRoleBtnPer> DataTableToList(DataTable dt)
		{
			List<YIEternalMIS.Model.v_GetRoleBtnPer> modelList = new List<YIEternalMIS.Model.v_GetRoleBtnPer>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				YIEternalMIS.Model.v_GetRoleBtnPer model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new YIEternalMIS.Model.v_GetRoleBtnPer();					
																	model.BtnPermission= dt.Rows[n]["BtnPermission"].ToString();
																																model.RoleID= dt.Rows[n]["RoleID"].ToString();
																																model.MenuNewID= dt.Rows[n]["MenuNewID"].ToString();
																																model.BtnName= dt.Rows[n]["BtnName"].ToString();
																																model.BtnText= dt.Rows[n]["BtnText"].ToString();
																																model.BtnImg= dt.Rows[n]["BtnImg"].ToString();
																																model.BtnAuthority= dt.Rows[n]["BtnAuthority"].ToString();
																																model.BtnVisible= dt.Rows[n]["BtnVisible"].ToString();
																																model.BtnEnabled= dt.Rows[n]["BtnEnabled"].ToString();
																																model.BtnTips= dt.Rows[n]["BtnTips"].ToString();
																																model.BtnIsToolBar= dt.Rows[n]["BtnIsToolBar"].ToString();
																																model.BtnGroupID= dt.Rows[n]["BtnGroupID"].ToString();
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