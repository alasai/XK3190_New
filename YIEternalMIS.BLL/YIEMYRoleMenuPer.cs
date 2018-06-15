using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
using YIEternalMIS.Common;
using YIEternalMIS.Model;
namespace YIEternalMIS.BLL {
	 	//YIEMYRoleMenuPer
		public partial class YIEMYRoleMenuPer
	{
   		     
		private readonly YIEternalMIS.DAL.YIEMYRoleMenuPer dal=new YIEternalMIS.DAL.YIEMYRoleMenuPer();
		public YIEMYRoleMenuPer()
		{}
		
		#region  Method
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string RoleID,string MenuNewID)
		{
			return dal.Exists(RoleID,MenuNewID);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public void  Add(YIEternalMIS.Model.YIEMYRoleMenuPer model)
		{
						dal.Add(model);
						
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(YIEternalMIS.Model.YIEMYRoleMenuPer model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(string RoleID,string MenuNewID)
		{
			
			return dal.Delete(RoleID,MenuNewID);
		}
		
		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public YIEternalMIS.Model.YIEMYRoleMenuPer GetModel(string RoleID,string MenuNewID)
		{
			
			return dal.GetModel(RoleID,MenuNewID);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
		public YIEternalMIS.Model.YIEMYRoleMenuPer GetModelByCache(string RoleID,string MenuNewID)
		{
			
			string CacheKey = "YIEMYRoleMenuPerModel-" + RoleID+MenuNewID;
			object objModel = YIEternalMIS.Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(RoleID,MenuNewID);
					if (objModel != null)
					{
						int ModelCache = YIEternalMIS.Common.ConfigHelper.GetConfigInt("ModelCache");
						YIEternalMIS.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (YIEternalMIS.Model.YIEMYRoleMenuPer)objModel;
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
		public List<YIEternalMIS.Model.YIEMYRoleMenuPer> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<YIEternalMIS.Model.YIEMYRoleMenuPer> DataTableToList(DataTable dt)
		{
			List<YIEternalMIS.Model.YIEMYRoleMenuPer> modelList = new List<YIEternalMIS.Model.YIEMYRoleMenuPer>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				YIEternalMIS.Model.YIEMYRoleMenuPer model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new YIEternalMIS.Model.YIEMYRoleMenuPer();					
																	model.RoleID= dt.Rows[n]["RoleID"].ToString();
																																model.MenuNewID= dt.Rows[n]["MenuNewID"].ToString();
																																model.Permission= dt.Rows[n]["Permission"].ToString();
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