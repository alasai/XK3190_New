using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
using YIEternalMIS.Common;
using YIEternalMIS.Model;
namespace YIEternalMIS.BLL {
	 	//YIEMYRoleBtnPer
		public partial class YIEMYRoleBtnPer
	{
   		     
		private readonly YIEternalMIS.DAL.YIEMYRoleBtnPer dal=new YIEternalMIS.DAL.YIEMYRoleBtnPer();
		public YIEMYRoleBtnPer()
		{}
		
		#region  Method
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string RoleID,string MenuNewID,string BtnName)
		{
			return dal.Exists(RoleID,MenuNewID,BtnName);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public void  Add(YIEternalMIS.Model.YIEMYRoleBtnPer model)
		{
						dal.Add(model);
						
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(YIEternalMIS.Model.YIEMYRoleBtnPer model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(string RoleID,string MenuNewID,string BtnName)
		{
			
			return dal.Delete(RoleID,MenuNewID,BtnName);
		}
		
		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public YIEternalMIS.Model.YIEMYRoleBtnPer GetModel(string RoleID,string MenuNewID,string BtnName)
		{
			
			return dal.GetModel(RoleID,MenuNewID,BtnName);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
		public YIEternalMIS.Model.YIEMYRoleBtnPer GetModelByCache(string RoleID,string MenuNewID,string BtnName)
		{
			
			string CacheKey = "YIEMYRoleBtnPerModel-" + RoleID+MenuNewID+BtnName;
			object objModel = YIEternalMIS.Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(RoleID,MenuNewID,BtnName);
					if (objModel != null)
					{
						int ModelCache = YIEternalMIS.Common.ConfigHelper.GetConfigInt("ModelCache");
						YIEternalMIS.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (YIEternalMIS.Model.YIEMYRoleBtnPer)objModel;
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
		public List<YIEternalMIS.Model.YIEMYRoleBtnPer> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<YIEternalMIS.Model.YIEMYRoleBtnPer> DataTableToList(DataTable dt)
		{
			List<YIEternalMIS.Model.YIEMYRoleBtnPer> modelList = new List<YIEternalMIS.Model.YIEMYRoleBtnPer>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				YIEternalMIS.Model.YIEMYRoleBtnPer model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new YIEternalMIS.Model.YIEMYRoleBtnPer();					
																	model.RoleID= dt.Rows[n]["RoleID"].ToString();
																																model.MenuNewID= dt.Rows[n]["MenuNewID"].ToString();
																																model.BtnName= dt.Rows[n]["BtnName"].ToString();
																																model.BtnPermission= dt.Rows[n]["BtnPermission"].ToString();
																						
				
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