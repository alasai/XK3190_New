using System; 
using System.Text;
using System.Data.SqlClient;
using System.Collections.Generic; 
using System.Data;
using YIEternalMIS.DBUtility;
namespace YIEternalMIS.DAL  
{
	 	//YIESysMenuBTNAuth
		public partial class YIESysMenuBTNAuth
	{
   		     
		public bool Exists(string MenuNewID,string BtnName)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from YIESysMenuBTNAuth");
			strSql.Append(" where ");
			                                       strSql.Append(" MenuNewID = @MenuNewID and  ");
                                                                   strSql.Append(" BtnName = @BtnName  ");
                            			SqlParameter[] parameters = {
					new SqlParameter("@MenuNewID", SqlDbType.VarChar,100),
					new SqlParameter("@BtnName", SqlDbType.VarChar,50)			};
			parameters[0].Value = MenuNewID;
			parameters[1].Value = BtnName;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}
		
				
		
		/// <summary>
		/// 增加一条数据
		/// </summary>
		public void Add(YIEternalMIS.Model.YIESysMenuBTNAuth model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into YIESysMenuBTNAuth(");			
            strSql.Append("MenuNewID,BtnName,BtnText,BtnImg,BtnAuthority,BtnIsToolBar,BtnTips,BtnGroupID,BtnVisible,BtnEnabled,BtnSort,BtnToolBarSort");
			strSql.Append(") values (");
            strSql.Append("@MenuNewID,@BtnName,@BtnText,@BtnImg,@BtnAuthority,@BtnIsToolBar,@BtnTips,@BtnGroupID,@BtnVisible,@BtnEnabled,@BtnSort,@BtnToolBarSort");            
            strSql.Append(") ");            
            		
			SqlParameter[] parameters = {
			            new SqlParameter("@MenuNewID", SqlDbType.VarChar,100) ,            
                        new SqlParameter("@BtnName", SqlDbType.VarChar,50) ,            
                        new SqlParameter("@BtnText", SqlDbType.VarChar,50) ,            
                        new SqlParameter("@BtnImg", SqlDbType.VarChar,50) ,            
                        new SqlParameter("@BtnAuthority", SqlDbType.VarChar,10) ,            
                        new SqlParameter("@BtnIsToolBar", SqlDbType.VarChar,10) ,            
                        new SqlParameter("@BtnTips", SqlDbType.VarChar,200) ,            
                        new SqlParameter("@BtnGroupID", SqlDbType.VarChar,10) ,            
                        new SqlParameter("@BtnVisible", SqlDbType.VarChar,10) ,            
                        new SqlParameter("@BtnEnabled", SqlDbType.VarChar,10) ,            
                        new SqlParameter("@BtnSort", SqlDbType.Int,4) ,            
                        new SqlParameter("@BtnToolBarSort", SqlDbType.Int,4)             
              
            };
			            
            parameters[0].Value = model.MenuNewID;                        
            parameters[1].Value = model.BtnName;                        
            parameters[2].Value = model.BtnText;                        
            parameters[3].Value = model.BtnImg;                        
            parameters[4].Value = model.BtnAuthority;                        
            parameters[5].Value = model.BtnIsToolBar;                        
            parameters[6].Value = model.BtnTips;                        
            parameters[7].Value = model.BtnGroupID;                        
            parameters[8].Value = model.BtnVisible;                        
            parameters[9].Value = model.BtnEnabled;                        
            parameters[10].Value = model.BtnSort;                        
            parameters[11].Value = model.BtnToolBarSort;                        
			            DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
            			
		}
		
		
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(YIEternalMIS.Model.YIESysMenuBTNAuth model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update YIESysMenuBTNAuth set ");
			                        
            strSql.Append(" MenuNewID = @MenuNewID , ");                                    
            strSql.Append(" BtnName = @BtnName , ");                                    
            strSql.Append(" BtnText = @BtnText , ");                                    
            strSql.Append(" BtnImg = @BtnImg , ");                                    
            strSql.Append(" BtnAuthority = @BtnAuthority , ");                                    
            strSql.Append(" BtnIsToolBar = @BtnIsToolBar , ");                                    
            strSql.Append(" BtnTips = @BtnTips , ");                                    
            strSql.Append(" BtnGroupID = @BtnGroupID , ");                                    
            strSql.Append(" BtnVisible = @BtnVisible , ");                                    
            strSql.Append(" BtnEnabled = @BtnEnabled , ");                                    
            strSql.Append(" BtnSort = @BtnSort , ");                                    
            strSql.Append(" BtnToolBarSort = @BtnToolBarSort  ");            			
			strSql.Append(" where MenuNewID=@MenuNewID and BtnName=@BtnName  ");
						
SqlParameter[] parameters = {
			            new SqlParameter("@MenuNewID", SqlDbType.VarChar,100) ,            
                        new SqlParameter("@BtnName", SqlDbType.VarChar,50) ,            
                        new SqlParameter("@BtnText", SqlDbType.VarChar,50) ,            
                        new SqlParameter("@BtnImg", SqlDbType.VarChar,50) ,            
                        new SqlParameter("@BtnAuthority", SqlDbType.VarChar,10) ,            
                        new SqlParameter("@BtnIsToolBar", SqlDbType.VarChar,10) ,            
                        new SqlParameter("@BtnTips", SqlDbType.VarChar,200) ,            
                        new SqlParameter("@BtnGroupID", SqlDbType.VarChar,10) ,            
                        new SqlParameter("@BtnVisible", SqlDbType.VarChar,10) ,            
                        new SqlParameter("@BtnEnabled", SqlDbType.VarChar,10) ,            
                        new SqlParameter("@BtnSort", SqlDbType.Int,4) ,            
                        new SqlParameter("@BtnToolBarSort", SqlDbType.Int,4)             
              
            };
						            
            parameters[0].Value = model.MenuNewID;                        
            parameters[1].Value = model.BtnName;                        
            parameters[2].Value = model.BtnText;                        
            parameters[3].Value = model.BtnImg;                        
            parameters[4].Value = model.BtnAuthority;                        
            parameters[5].Value = model.BtnIsToolBar;                        
            parameters[6].Value = model.BtnTips;                        
            parameters[7].Value = model.BtnGroupID;                        
            parameters[8].Value = model.BtnVisible;                        
            parameters[9].Value = model.BtnEnabled;                        
            parameters[10].Value = model.BtnSort;                        
            parameters[11].Value = model.BtnToolBarSort;                        
            int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		
		
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(string MenuNewID,string BtnName)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from YIESysMenuBTNAuth ");
			strSql.Append(" where MenuNewID=@MenuNewID and BtnName=@BtnName ");
						SqlParameter[] parameters = {
					new SqlParameter("@MenuNewID", SqlDbType.VarChar,100),
					new SqlParameter("@BtnName", SqlDbType.VarChar,50)			};
			parameters[0].Value = MenuNewID;
			parameters[1].Value = BtnName;


			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		
				
		
		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public YIEternalMIS.Model.YIESysMenuBTNAuth GetModel(string MenuNewID,string BtnName)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select MenuNewID, BtnName, BtnText, BtnImg, BtnAuthority, BtnIsToolBar, BtnTips, BtnGroupID, BtnVisible, BtnEnabled, BtnSort, BtnToolBarSort  ");			
			strSql.Append("  from YIESysMenuBTNAuth ");
			strSql.Append(" where MenuNewID=@MenuNewID and BtnName=@BtnName ");
						SqlParameter[] parameters = {
					new SqlParameter("@MenuNewID", SqlDbType.VarChar,100),
					new SqlParameter("@BtnName", SqlDbType.VarChar,50)			};
			parameters[0].Value = MenuNewID;
			parameters[1].Value = BtnName;

			
			YIEternalMIS.Model.YIESysMenuBTNAuth model=new YIEternalMIS.Model.YIESysMenuBTNAuth();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			
			if(ds.Tables[0].Rows.Count>0)
			{
																model.MenuNewID= ds.Tables[0].Rows[0]["MenuNewID"].ToString();
																																model.BtnName= ds.Tables[0].Rows[0]["BtnName"].ToString();
																																model.BtnText= ds.Tables[0].Rows[0]["BtnText"].ToString();
																																model.BtnImg= ds.Tables[0].Rows[0]["BtnImg"].ToString();
																																model.BtnAuthority= ds.Tables[0].Rows[0]["BtnAuthority"].ToString();
																																model.BtnIsToolBar= ds.Tables[0].Rows[0]["BtnIsToolBar"].ToString();
																																model.BtnTips= ds.Tables[0].Rows[0]["BtnTips"].ToString();
																																model.BtnGroupID= ds.Tables[0].Rows[0]["BtnGroupID"].ToString();
																																model.BtnVisible= ds.Tables[0].Rows[0]["BtnVisible"].ToString();
																																model.BtnEnabled= ds.Tables[0].Rows[0]["BtnEnabled"].ToString();
																												if(ds.Tables[0].Rows[0]["BtnSort"].ToString()!="")
				{
					model.BtnSort=int.Parse(ds.Tables[0].Rows[0]["BtnSort"].ToString());
				}
																																if(ds.Tables[0].Rows[0]["BtnToolBarSort"].ToString()!="")
				{
					model.BtnToolBarSort=int.Parse(ds.Tables[0].Rows[0]["BtnToolBarSort"].ToString());
				}
																														
				return model;
			}
			else
			{
				return null;
			}
		}
		
		
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select * ");
			strSql.Append(" FROM YIESysMenuBTNAuth ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQL.Query(strSql.ToString());
		}
		
		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ");
			if(Top>0)
			{
				strSql.Append(" top "+Top.ToString());
			}
			strSql.Append(" * ");
			strSql.Append(" FROM YIESysMenuBTNAuth ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			strSql.Append(" order by " + filedOrder);
			return DbHelperSQL.Query(strSql.ToString());
		}

   
	}
}

