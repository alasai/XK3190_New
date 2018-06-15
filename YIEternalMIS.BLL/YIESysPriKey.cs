using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
using YIEternalMIS.Common;
using YIEternalMIS.Model;
namespace YIEternalMIS.BLL {
	 	//YIESysPriKey
		public partial class YIESysPriKey
	{
   		     
		private readonly YIEternalMIS.DAL.YIESysPriKey dal=new YIEternalMIS.DAL.YIESysPriKey();
		public YIESysPriKey()
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
		public int  Add(YIEternalMIS.Model.YIESysPriKey model)
		{
						return dal.Add(model);
						
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(YIEternalMIS.Model.YIESysPriKey model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int NameID)
		{
			
			return dal.Delete(NameID);
		}
				/// <summary>
		/// 批量删除一批数据
		/// </summary>
		public bool DeleteList(string NameIDlist )
		{
			return dal.DeleteList(NameIDlist );
		}
		
		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public YIEternalMIS.Model.YIESysPriKey GetModel(int NameID)
		{
			
			return dal.GetModel(NameID);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
		public YIEternalMIS.Model.YIESysPriKey GetModelByCache(int NameID)
		{
			
			string CacheKey = "YIESysPriKeyModel-" + NameID;
			object objModel = YIEternalMIS.Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(NameID);
					if (objModel != null)
					{
						int ModelCache = YIEternalMIS.Common.ConfigHelper.GetConfigInt("ModelCache");
						YIEternalMIS.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (YIEternalMIS.Model.YIESysPriKey)objModel;
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
		public List<YIEternalMIS.Model.YIESysPriKey> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<YIEternalMIS.Model.YIESysPriKey> DataTableToList(DataTable dt)
		{
			List<YIEternalMIS.Model.YIESysPriKey> modelList = new List<YIEternalMIS.Model.YIESysPriKey>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				YIEternalMIS.Model.YIESysPriKey model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new YIEternalMIS.Model.YIESysPriKey();					
													if(dt.Rows[n]["NameID"].ToString()!="")
				{
					model.NameID=int.Parse(dt.Rows[n]["NameID"].ToString());
				}
																																				model.Name= dt.Rows[n]["Name"].ToString();
																												if(dt.Rows[n]["Days"].ToString()!="")
				{
					model.Days=int.Parse(dt.Rows[n]["Days"].ToString());
				}
																																				model.Head= dt.Rows[n]["Head"].ToString();
																												if(dt.Rows[n]["CurrentNo"].ToString()!="")
				{
					model.CurrentNo=int.Parse(dt.Rows[n]["CurrentNo"].ToString());
				}
																																if(dt.Rows[n]["BHLen"].ToString()!="")
				{
					model.BHLen=int.Parse(dt.Rows[n]["BHLen"].ToString());
				}
																																if(dt.Rows[n]["Yearmoth"].ToString()!="")
				{
					model.Yearmoth=int.Parse(dt.Rows[n]["Yearmoth"].ToString());
				}
																																				model.DESCRIPTION= dt.Rows[n]["DESCRIPTION"].ToString();
																																model.TableName= dt.Rows[n]["TableName"].ToString();
																																model.keyfieldName= dt.Rows[n]["keyfieldName"].ToString();
																																model.userbz= dt.Rows[n]["userbz"].ToString();
																						
				
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