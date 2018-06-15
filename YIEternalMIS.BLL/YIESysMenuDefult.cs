using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
using YIEternalMIS.Common;
using YIEternalMIS.Model;
namespace YIEternalMIS.BLL {
	 	//YIESysMenuDefult
		public partial class YIESysMenuDefult
	{
   		     
		private readonly YIEternalMIS.DAL.YIESysMenuDefult dal=new YIEternalMIS.DAL.YIESysMenuDefult();
		public YIESysMenuDefult()
		{}
		
		#region  Method
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string MenuNewID)
		{
			return dal.Exists(MenuNewID);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public void  Add(YIEternalMIS.Model.YIESysMenuDefult model)
		{
						dal.Add(model);
						
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(YIEternalMIS.Model.YIESysMenuDefult model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(string MenuNewID)
		{
			
			return dal.Delete(MenuNewID);
		}
		
		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public YIEternalMIS.Model.YIESysMenuDefult GetModel(string MenuNewID)
		{
			
			return dal.GetModel(MenuNewID);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
		public YIEternalMIS.Model.YIESysMenuDefult GetModelByCache(string MenuNewID)
		{
			
			string CacheKey = "YIESysMenuDefultModel-" + MenuNewID;
			object objModel = YIEternalMIS.Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(MenuNewID);
					if (objModel != null)
					{
						int ModelCache = YIEternalMIS.Common.ConfigHelper.GetConfigInt("ModelCache");
						YIEternalMIS.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (YIEternalMIS.Model.YIESysMenuDefult)objModel;
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
		public List<YIEternalMIS.Model.YIESysMenuDefult> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<YIEternalMIS.Model.YIESysMenuDefult> DataTableToList(DataTable dt)
		{
			List<YIEternalMIS.Model.YIESysMenuDefult> modelList = new List<YIEternalMIS.Model.YIESysMenuDefult>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				YIEternalMIS.Model.YIESysMenuDefult model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new YIEternalMIS.Model.YIESysMenuDefult();					
																	model.MenuNewID= dt.Rows[n]["MenuNewID"].ToString();
																																model.SysId= dt.Rows[n]["SysId"].ToString();
																																model.SysName= dt.Rows[n]["SysName"].ToString();
																																model.MenuID= dt.Rows[n]["MenuID"].ToString();
																																model.ParentMenuID= dt.Rows[n]["ParentMenuID"].ToString();
																												if(dt.Rows[n]["MenuLevel"].ToString()!="")
				{
					model.MenuLevel=int.Parse(dt.Rows[n]["MenuLevel"].ToString());
				}
																																				model.MenuIcon= dt.Rows[n]["MenuIcon"].ToString();
																																model.MenuName= dt.Rows[n]["MenuName"].ToString();
																																model.MenuText= dt.Rows[n]["MenuText"].ToString();
																																model.TabText= dt.Rows[n]["TabText"].ToString();
																												if(dt.Rows[n]["MenuOrder"].ToString()!="")
				{
					model.MenuOrder=int.Parse(dt.Rows[n]["MenuOrder"].ToString());
				}
																																				model.MenuIsButton= dt.Rows[n]["MenuIsButton"].ToString();
																												if(dt.Rows[n]["MenuVisible"].ToString()!="")
				{
					model.MenuVisible=int.Parse(dt.Rows[n]["MenuVisible"].ToString());
				}
																																				model.MenuTips= dt.Rows[n]["MenuTips"].ToString();
																																model.OpenAssembly= dt.Rows[n]["OpenAssembly"].ToString();
																																model.OpenFormClassName= dt.Rows[n]["OpenFormClassName"].ToString();
																												if(dt.Rows[n]["OpenType"].ToString()!="")
				{
					model.OpenType=int.Parse(dt.Rows[n]["OpenType"].ToString());
				}
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