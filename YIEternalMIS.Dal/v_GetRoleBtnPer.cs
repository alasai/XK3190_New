using System; 
using System.Text;
using System.Data.SqlClient;
using System.Collections.Generic; 
using System.Data;
using YIEternalMIS.DBUtility;
namespace YIEternalMIS.DAL  
{
	 	//v_GetRoleBtnPer
		public partial class v_GetRoleBtnPer
	{
   		     
		public bool Exists()
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from v_GetRoleBtnPer");
			strSql.Append(" where ");
						SqlParameter[] parameters = {
			};

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}
		
				
		
		/// <summary>
		/// 增加一条数据
		/// </summary>
		public void Add(YIEternalMIS.Model.v_GetRoleBtnPer model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into v_GetRoleBtnPer(");			
            strSql.Append("BtnPermission,RoleID,MenuNewID,BtnName,BtnText,BtnImg,BtnAuthority,BtnVisible,BtnEnabled,BtnTips,BtnIsToolBar,BtnGroupID,BtnSort,BtnToolBarSort");
			strSql.Append(") values (");
            strSql.Append("@BtnPermission,@RoleID,@MenuNewID,@BtnName,@BtnText,@BtnImg,@BtnAuthority,@BtnVisible,@BtnEnabled,@BtnTips,@BtnIsToolBar,@BtnGroupID,@BtnSort,@BtnToolBarSort");            
            strSql.Append(") ");            
            		
			SqlParameter[] parameters = {
			            new SqlParameter("@BtnPermission", SqlDbType.VarChar,10) ,            
                        new SqlParameter("@RoleID", SqlDbType.VarChar,100) ,            
                        new SqlParameter("@MenuNewID", SqlDbType.VarChar,100) ,            
                        new SqlParameter("@BtnName", SqlDbType.VarChar,50) ,            
                        new SqlParameter("@BtnText", SqlDbType.VarChar,50) ,            
                        new SqlParameter("@BtnImg", SqlDbType.VarChar,50) ,            
                        new SqlParameter("@BtnAuthority", SqlDbType.VarChar,10) ,            
                        new SqlParameter("@BtnVisible", SqlDbType.VarChar,10) ,            
                        new SqlParameter("@BtnEnabled", SqlDbType.VarChar,10) ,            
                        new SqlParameter("@BtnTips", SqlDbType.VarChar,200) ,            
                        new SqlParameter("@BtnIsToolBar", SqlDbType.VarChar,10) ,            
                        new SqlParameter("@BtnGroupID", SqlDbType.VarChar,10) ,            
                        new SqlParameter("@BtnSort", SqlDbType.Int,4) ,            
                        new SqlParameter("@BtnToolBarSort", SqlDbType.Int,4)             
              
            };
			            
            parameters[0].Value = model.BtnPermission;                        
            parameters[1].Value = model.RoleID;                        
            parameters[2].Value = model.MenuNewID;                        
            parameters[3].Value = model.BtnName;                        
            parameters[4].Value = model.BtnText;                        
            parameters[5].Value = model.BtnImg;                        
            parameters[6].Value = model.BtnAuthority;                        
            parameters[7].Value = model.BtnVisible;                        
            parameters[8].Value = model.BtnEnabled;                        
            parameters[9].Value = model.BtnTips;                        
            parameters[10].Value = model.BtnIsToolBar;                        
            parameters[11].Value = model.BtnGroupID;                        
            parameters[12].Value = model.BtnSort;                        
            parameters[13].Value = model.BtnToolBarSort;                        
			            DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
            			
		}
		
		
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(YIEternalMIS.Model.v_GetRoleBtnPer model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update v_GetRoleBtnPer set ");
			                        
            strSql.Append(" BtnPermission = @BtnPermission , ");                                    
            strSql.Append(" RoleID = @RoleID , ");                                    
            strSql.Append(" MenuNewID = @MenuNewID , ");                                    
            strSql.Append(" BtnName = @BtnName , ");                                    
            strSql.Append(" BtnText = @BtnText , ");                                    
            strSql.Append(" BtnImg = @BtnImg , ");                                    
            strSql.Append(" BtnAuthority = @BtnAuthority , ");                                    
            strSql.Append(" BtnVisible = @BtnVisible , ");                                    
            strSql.Append(" BtnEnabled = @BtnEnabled , ");                                    
            strSql.Append(" BtnTips = @BtnTips , ");                                    
            strSql.Append(" BtnIsToolBar = @BtnIsToolBar , ");                                    
            strSql.Append(" BtnGroupID = @BtnGroupID , ");                                    
            strSql.Append(" BtnSort = @BtnSort , ");                                    
            strSql.Append(" BtnToolBarSort = @BtnToolBarSort  ");            			
			strSql.Append(" where  ");
						
SqlParameter[] parameters = {
			            new SqlParameter("@BtnPermission", SqlDbType.VarChar,10) ,            
                        new SqlParameter("@RoleID", SqlDbType.VarChar,100) ,            
                        new SqlParameter("@MenuNewID", SqlDbType.VarChar,100) ,            
                        new SqlParameter("@BtnName", SqlDbType.VarChar,50) ,            
                        new SqlParameter("@BtnText", SqlDbType.VarChar,50) ,            
                        new SqlParameter("@BtnImg", SqlDbType.VarChar,50) ,            
                        new SqlParameter("@BtnAuthority", SqlDbType.VarChar,10) ,            
                        new SqlParameter("@BtnVisible", SqlDbType.VarChar,10) ,            
                        new SqlParameter("@BtnEnabled", SqlDbType.VarChar,10) ,            
                        new SqlParameter("@BtnTips", SqlDbType.VarChar,200) ,            
                        new SqlParameter("@BtnIsToolBar", SqlDbType.VarChar,10) ,            
                        new SqlParameter("@BtnGroupID", SqlDbType.VarChar,10) ,            
                        new SqlParameter("@BtnSort", SqlDbType.Int,4) ,            
                        new SqlParameter("@BtnToolBarSort", SqlDbType.Int,4)             
              
            };
						            
            parameters[0].Value = model.BtnPermission;                        
            parameters[1].Value = model.RoleID;                        
            parameters[2].Value = model.MenuNewID;                        
            parameters[3].Value = model.BtnName;                        
            parameters[4].Value = model.BtnText;                        
            parameters[5].Value = model.BtnImg;                        
            parameters[6].Value = model.BtnAuthority;                        
            parameters[7].Value = model.BtnVisible;                        
            parameters[8].Value = model.BtnEnabled;                        
            parameters[9].Value = model.BtnTips;                        
            parameters[10].Value = model.BtnIsToolBar;                        
            parameters[11].Value = model.BtnGroupID;                        
            parameters[12].Value = model.BtnSort;                        
            parameters[13].Value = model.BtnToolBarSort;                        
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
		public bool Delete()
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from v_GetRoleBtnPer ");
			strSql.Append(" where ");
						SqlParameter[] parameters = {
			};


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
		public YIEternalMIS.Model.v_GetRoleBtnPer GetModel()
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select BtnPermission, RoleID, MenuNewID, BtnName, BtnText, BtnImg, BtnAuthority, BtnVisible, BtnEnabled, BtnTips, BtnIsToolBar, BtnGroupID, BtnSort, BtnToolBarSort  ");			
			strSql.Append("  from v_GetRoleBtnPer ");
			strSql.Append(" where ");
						SqlParameter[] parameters = {
			};

			
			YIEternalMIS.Model.v_GetRoleBtnPer model=new YIEternalMIS.Model.v_GetRoleBtnPer();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			
			if(ds.Tables[0].Rows.Count>0)
			{
																model.BtnPermission= ds.Tables[0].Rows[0]["BtnPermission"].ToString();
																																model.RoleID= ds.Tables[0].Rows[0]["RoleID"].ToString();
																																model.MenuNewID= ds.Tables[0].Rows[0]["MenuNewID"].ToString();
																																model.BtnName= ds.Tables[0].Rows[0]["BtnName"].ToString();
																																model.BtnText= ds.Tables[0].Rows[0]["BtnText"].ToString();
																																model.BtnImg= ds.Tables[0].Rows[0]["BtnImg"].ToString();
																																model.BtnAuthority= ds.Tables[0].Rows[0]["BtnAuthority"].ToString();
																																model.BtnVisible= ds.Tables[0].Rows[0]["BtnVisible"].ToString();
																																model.BtnEnabled= ds.Tables[0].Rows[0]["BtnEnabled"].ToString();
																																model.BtnTips= ds.Tables[0].Rows[0]["BtnTips"].ToString();
																																model.BtnIsToolBar= ds.Tables[0].Rows[0]["BtnIsToolBar"].ToString();
																																model.BtnGroupID= ds.Tables[0].Rows[0]["BtnGroupID"].ToString();
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
			strSql.Append(" FROM v_GetRoleBtnPer ");
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
			strSql.Append(" FROM v_GetRoleBtnPer ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			strSql.Append(" order by " + filedOrder);
			return DbHelperSQL.Query(strSql.ToString());
		}

   
	}
}

