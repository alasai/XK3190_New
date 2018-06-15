using System; 
using System.Text;
using System.Data.SqlClient;
using System.Collections.Generic; 
using System.Data;
using YIEternalMIS.DBUtility;
namespace YIEternalMIS.DAL  
{
	 	//YIESysMenuDefult
		public partial class YIESysMenuDefult
	{
   		     
		public bool Exists(string MenuNewID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from YIESysMenuDefult");
			strSql.Append(" where ");
			                                       strSql.Append(" MenuNewID = @MenuNewID  ");
                            			SqlParameter[] parameters = {
					new SqlParameter("@MenuNewID", SqlDbType.VarChar,100)			};
			parameters[0].Value = MenuNewID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}
		
				
		
		/// <summary>
		/// 增加一条数据
		/// </summary>
		public void Add(YIEternalMIS.Model.YIESysMenuDefult model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into YIESysMenuDefult(");			
            strSql.Append("MenuNewID,SysId,SysName,MenuID,ParentMenuID,MenuLevel,MenuIcon,MenuName,MenuText,TabText,MenuOrder,MenuIsButton,MenuVisible,MenuTips,OpenAssembly,OpenFormClassName,OpenType,zfbz");
			strSql.Append(") values (");
            strSql.Append("@MenuNewID,@SysId,@SysName,@MenuID,@ParentMenuID,@MenuLevel,@MenuIcon,@MenuName,@MenuText,@TabText,@MenuOrder,@MenuIsButton,@MenuVisible,@MenuTips,@OpenAssembly,@OpenFormClassName,@OpenType,@zfbz");            
            strSql.Append(") ");            
            		
			SqlParameter[] parameters = {
			            new SqlParameter("@MenuNewID", SqlDbType.VarChar,100) ,            
                        new SqlParameter("@SysId", SqlDbType.VarChar,20) ,            
                        new SqlParameter("@SysName", SqlDbType.VarChar,50) ,            
                        new SqlParameter("@MenuID", SqlDbType.VarChar,20) ,            
                        new SqlParameter("@ParentMenuID", SqlDbType.VarChar,20) ,            
                        new SqlParameter("@MenuLevel", SqlDbType.Int,4) ,            
                        new SqlParameter("@MenuIcon", SqlDbType.VarChar,50) ,            
                        new SqlParameter("@MenuName", SqlDbType.VarChar,40) ,            
                        new SqlParameter("@MenuText", SqlDbType.VarChar,50) ,            
                        new SqlParameter("@TabText", SqlDbType.VarChar,50) ,            
                        new SqlParameter("@MenuOrder", SqlDbType.Int,4) ,            
                        new SqlParameter("@MenuIsButton", SqlDbType.VarChar,10) ,            
                        new SqlParameter("@MenuVisible", SqlDbType.Int,4) ,            
                        new SqlParameter("@MenuTips", SqlDbType.VarChar,100) ,            
                        new SqlParameter("@OpenAssembly", SqlDbType.VarChar,50) ,            
                        new SqlParameter("@OpenFormClassName", SqlDbType.VarChar,100) ,            
                        new SqlParameter("@OpenType", SqlDbType.Int,4) ,            
                        new SqlParameter("@zfbz", SqlDbType.VarChar,10)             
              
            };
			            
            parameters[0].Value = model.MenuNewID;                        
            parameters[1].Value = model.SysId;                        
            parameters[2].Value = model.SysName;                        
            parameters[3].Value = model.MenuID;                        
            parameters[4].Value = model.ParentMenuID;                        
            parameters[5].Value = model.MenuLevel;                        
            parameters[6].Value = model.MenuIcon;                        
            parameters[7].Value = model.MenuName;                        
            parameters[8].Value = model.MenuText;                        
            parameters[9].Value = model.TabText;                        
            parameters[10].Value = model.MenuOrder;                        
            parameters[11].Value = model.MenuIsButton;                        
            parameters[12].Value = model.MenuVisible;                        
            parameters[13].Value = model.MenuTips;                        
            parameters[14].Value = model.OpenAssembly;                        
            parameters[15].Value = model.OpenFormClassName;                        
            parameters[16].Value = model.OpenType;                        
            parameters[17].Value = model.zfbz;                        
			            DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
            			
		}
		
		
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(YIEternalMIS.Model.YIESysMenuDefult model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update YIESysMenuDefult set ");
			                        
            strSql.Append(" MenuNewID = @MenuNewID , ");                                    
            strSql.Append(" SysId = @SysId , ");                                    
            strSql.Append(" SysName = @SysName , ");                                    
            strSql.Append(" MenuID = @MenuID , ");                                    
            strSql.Append(" ParentMenuID = @ParentMenuID , ");                                    
            strSql.Append(" MenuLevel = @MenuLevel , ");                                    
            strSql.Append(" MenuIcon = @MenuIcon , ");                                    
            strSql.Append(" MenuName = @MenuName , ");                                    
            strSql.Append(" MenuText = @MenuText , ");                                    
            strSql.Append(" TabText = @TabText , ");                                    
            strSql.Append(" MenuOrder = @MenuOrder , ");                                    
            strSql.Append(" MenuIsButton = @MenuIsButton , ");                                    
            strSql.Append(" MenuVisible = @MenuVisible , ");                                    
            strSql.Append(" MenuTips = @MenuTips , ");                                    
            strSql.Append(" OpenAssembly = @OpenAssembly , ");                                    
            strSql.Append(" OpenFormClassName = @OpenFormClassName , ");                                    
            strSql.Append(" OpenType = @OpenType , ");                                    
            strSql.Append(" zfbz = @zfbz  ");            			
			strSql.Append(" where MenuNewID=@MenuNewID  ");
						
SqlParameter[] parameters = {
			            new SqlParameter("@MenuNewID", SqlDbType.VarChar,100) ,            
                        new SqlParameter("@SysId", SqlDbType.VarChar,20) ,            
                        new SqlParameter("@SysName", SqlDbType.VarChar,50) ,            
                        new SqlParameter("@MenuID", SqlDbType.VarChar,20) ,            
                        new SqlParameter("@ParentMenuID", SqlDbType.VarChar,20) ,            
                        new SqlParameter("@MenuLevel", SqlDbType.Int,4) ,            
                        new SqlParameter("@MenuIcon", SqlDbType.VarChar,50) ,            
                        new SqlParameter("@MenuName", SqlDbType.VarChar,40) ,            
                        new SqlParameter("@MenuText", SqlDbType.VarChar,50) ,            
                        new SqlParameter("@TabText", SqlDbType.VarChar,50) ,            
                        new SqlParameter("@MenuOrder", SqlDbType.Int,4) ,            
                        new SqlParameter("@MenuIsButton", SqlDbType.VarChar,10) ,            
                        new SqlParameter("@MenuVisible", SqlDbType.Int,4) ,            
                        new SqlParameter("@MenuTips", SqlDbType.VarChar,100) ,            
                        new SqlParameter("@OpenAssembly", SqlDbType.VarChar,50) ,            
                        new SqlParameter("@OpenFormClassName", SqlDbType.VarChar,100) ,            
                        new SqlParameter("@OpenType", SqlDbType.Int,4) ,            
                        new SqlParameter("@zfbz", SqlDbType.VarChar,10)             
              
            };
						            
            parameters[0].Value = model.MenuNewID;                        
            parameters[1].Value = model.SysId;                        
            parameters[2].Value = model.SysName;                        
            parameters[3].Value = model.MenuID;                        
            parameters[4].Value = model.ParentMenuID;                        
            parameters[5].Value = model.MenuLevel;                        
            parameters[6].Value = model.MenuIcon;                        
            parameters[7].Value = model.MenuName;                        
            parameters[8].Value = model.MenuText;                        
            parameters[9].Value = model.TabText;                        
            parameters[10].Value = model.MenuOrder;                        
            parameters[11].Value = model.MenuIsButton;                        
            parameters[12].Value = model.MenuVisible;                        
            parameters[13].Value = model.MenuTips;                        
            parameters[14].Value = model.OpenAssembly;                        
            parameters[15].Value = model.OpenFormClassName;                        
            parameters[16].Value = model.OpenType;                        
            parameters[17].Value = model.zfbz;                        
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
		public bool Delete(string MenuNewID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from YIESysMenuDefult ");
			strSql.Append(" where MenuNewID=@MenuNewID ");
						SqlParameter[] parameters = {
					new SqlParameter("@MenuNewID", SqlDbType.VarChar,100)			};
			parameters[0].Value = MenuNewID;


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
		public YIEternalMIS.Model.YIESysMenuDefult GetModel(string MenuNewID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select MenuNewID, SysId, SysName, MenuID, ParentMenuID, MenuLevel, MenuIcon, MenuName, MenuText, TabText, MenuOrder, MenuIsButton, MenuVisible, MenuTips, OpenAssembly, OpenFormClassName, OpenType, zfbz  ");			
			strSql.Append("  from YIESysMenuDefult ");
			strSql.Append(" where MenuNewID=@MenuNewID ");
						SqlParameter[] parameters = {
					new SqlParameter("@MenuNewID", SqlDbType.VarChar,100)			};
			parameters[0].Value = MenuNewID;

			
			YIEternalMIS.Model.YIESysMenuDefult model=new YIEternalMIS.Model.YIESysMenuDefult();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			
			if(ds.Tables[0].Rows.Count>0)
			{
																model.MenuNewID= ds.Tables[0].Rows[0]["MenuNewID"].ToString();
																																model.SysId= ds.Tables[0].Rows[0]["SysId"].ToString();
																																model.SysName= ds.Tables[0].Rows[0]["SysName"].ToString();
																																model.MenuID= ds.Tables[0].Rows[0]["MenuID"].ToString();
																																model.ParentMenuID= ds.Tables[0].Rows[0]["ParentMenuID"].ToString();
																												if(ds.Tables[0].Rows[0]["MenuLevel"].ToString()!="")
				{
					model.MenuLevel=int.Parse(ds.Tables[0].Rows[0]["MenuLevel"].ToString());
				}
																																				model.MenuIcon= ds.Tables[0].Rows[0]["MenuIcon"].ToString();
																																model.MenuName= ds.Tables[0].Rows[0]["MenuName"].ToString();
																																model.MenuText= ds.Tables[0].Rows[0]["MenuText"].ToString();
																																model.TabText= ds.Tables[0].Rows[0]["TabText"].ToString();
																												if(ds.Tables[0].Rows[0]["MenuOrder"].ToString()!="")
				{
					model.MenuOrder=int.Parse(ds.Tables[0].Rows[0]["MenuOrder"].ToString());
				}
																																				model.MenuIsButton= ds.Tables[0].Rows[0]["MenuIsButton"].ToString();
																												if(ds.Tables[0].Rows[0]["MenuVisible"].ToString()!="")
				{
					model.MenuVisible=int.Parse(ds.Tables[0].Rows[0]["MenuVisible"].ToString());
				}
																																				model.MenuTips= ds.Tables[0].Rows[0]["MenuTips"].ToString();
																																model.OpenAssembly= ds.Tables[0].Rows[0]["OpenAssembly"].ToString();
																																model.OpenFormClassName= ds.Tables[0].Rows[0]["OpenFormClassName"].ToString();
																												if(ds.Tables[0].Rows[0]["OpenType"].ToString()!="")
				{
					model.OpenType=int.Parse(ds.Tables[0].Rows[0]["OpenType"].ToString());
				}
																																				model.zfbz= ds.Tables[0].Rows[0]["zfbz"].ToString();
																										
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
			strSql.Append(" FROM YIESysMenuDefult ");
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
			strSql.Append(" FROM YIESysMenuDefult ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			strSql.Append(" order by " + filedOrder);
			return DbHelperSQL.Query(strSql.ToString());
		}

   
	}
}

