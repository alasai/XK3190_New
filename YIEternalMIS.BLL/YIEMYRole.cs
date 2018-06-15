using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
using YIEternalMIS.Common;
using YIEternalMIS.Model;
namespace YIEternalMIS.BLL {
	 	//YIEMYRole
		public partial class YIEMYRole
	{
   		     
		private readonly YIEternalMIS.DAL.YIEMYRole dal=new YIEternalMIS.DAL.YIEMYRole();
		public YIEMYRole()
		{}
		
		#region  Method
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string RoleID)
		{
			return dal.Exists(RoleID);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public void  Add(YIEternalMIS.Model.YIEMYRole model)
		{
						dal.Add(model);
						
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(YIEternalMIS.Model.YIEMYRole model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(string RoleID)
		{
			
			return dal.Delete(RoleID);
		}
		
		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public YIEternalMIS.Model.YIEMYRole GetModel(string RoleID)
		{
			
			return dal.GetModel(RoleID);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
		public YIEternalMIS.Model.YIEMYRole GetModelByCache(string RoleID)
		{
			
			string CacheKey = "YIEMYRoleModel-" + RoleID;
			object objModel = YIEternalMIS.Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(RoleID);
					if (objModel != null)
					{
						int ModelCache = YIEternalMIS.Common.ConfigHelper.GetConfigInt("ModelCache");
						YIEternalMIS.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (YIEternalMIS.Model.YIEMYRole)objModel;
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
		public List<YIEternalMIS.Model.YIEMYRole> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<YIEternalMIS.Model.YIEMYRole> DataTableToList(DataTable dt)
		{
			List<YIEternalMIS.Model.YIEMYRole> modelList = new List<YIEternalMIS.Model.YIEMYRole>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				YIEternalMIS.Model.YIEMYRole model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new YIEternalMIS.Model.YIEMYRole();					
																	model.RoleID= dt.Rows[n]["RoleID"].ToString();
																																model.RoleName= dt.Rows[n]["RoleName"].ToString();
																																model.RoleBZ= dt.Rows[n]["RoleBZ"].ToString();
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