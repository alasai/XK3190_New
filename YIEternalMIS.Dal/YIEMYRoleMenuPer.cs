using System; 
using System.Text;
using System.Data.SqlClient;
using System.Collections.Generic; 
using System.Data;
using YIEternalMIS.DBUtility;
namespace YIEternalMIS.DAL  
{
	 	//YIEMYRoleMenuPer
		public partial class YIEMYRoleMenuPer
	{
   		     
		public bool Exists(string RoleID,string MenuNewID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from YIEMYRoleMenuPer");
			strSql.Append(" where ");
			                                       strSql.Append(" RoleID = @RoleID and  ");
                                                                   strSql.Append(" MenuNewID = @MenuNewID  ");
                            			SqlParameter[] parameters = {
					new SqlParameter("@RoleID", SqlDbType.VarChar,100),
					new SqlParameter("@MenuNewID", SqlDbType.VarChar,100)			};
			parameters[0].Value = RoleID;
			parameters[1].Value = MenuNewID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}
		
				
		
		/// <summary>
		/// 增加一条数据
		/// </summary>
		public void Add(YIEternalMIS.Model.YIEMYRoleMenuPer model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into YIEMYRoleMenuPer(");			
            strSql.Append("RoleID,MenuNewID,Permission,zfbz");
			strSql.Append(") values (");
            strSql.Append("@RoleID,@MenuNewID,@Permission,@zfbz");            
            strSql.Append(") ");            
            		
			SqlParameter[] parameters = {
			            new SqlParameter("@RoleID", SqlDbType.VarChar,100) ,            
                        new SqlParameter("@MenuNewID", SqlDbType.VarChar,100) ,            
                        new SqlParameter("@Permission", SqlDbType.VarChar,20) ,            
                        new SqlParameter("@zfbz", SqlDbType.VarChar,10)             
              
            };
			            
            parameters[0].Value = model.RoleID;                        
            parameters[1].Value = model.MenuNewID;                        
            parameters[2].Value = model.Permission;                        
            parameters[3].Value = model.zfbz;                        
			            DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
            			
		}
		
		
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(YIEternalMIS.Model.YIEMYRoleMenuPer model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update YIEMYRoleMenuPer set ");
			                        
            strSql.Append(" RoleID = @RoleID , ");                                    
            strSql.Append(" MenuNewID = @MenuNewID , ");                                    
            strSql.Append(" Permission = @Permission , ");                                    
            strSql.Append(" zfbz = @zfbz  ");            			
			strSql.Append(" where RoleID=@RoleID and MenuNewID=@MenuNewID  ");
						
SqlParameter[] parameters = {
			            new SqlParameter("@RoleID", SqlDbType.VarChar,100) ,            
                        new SqlParameter("@MenuNewID", SqlDbType.VarChar,100) ,            
                        new SqlParameter("@Permission", SqlDbType.VarChar,20) ,            
                        new SqlParameter("@zfbz", SqlDbType.VarChar,10)             
              
            };
						            
            parameters[0].Value = model.RoleID;                        
            parameters[1].Value = model.MenuNewID;                        
            parameters[2].Value = model.Permission;                        
            parameters[3].Value = model.zfbz;                        
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
		public bool Delete(string RoleID,string MenuNewID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from YIEMYRoleMenuPer ");
			strSql.Append(" where RoleID=@RoleID and MenuNewID=@MenuNewID ");
						SqlParameter[] parameters = {
					new SqlParameter("@RoleID", SqlDbType.VarChar,100),
					new SqlParameter("@MenuNewID", SqlDbType.VarChar,100)			};
			parameters[0].Value = RoleID;
			parameters[1].Value = MenuNewID;


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
		public YIEternalMIS.Model.YIEMYRoleMenuPer GetModel(string RoleID,string MenuNewID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select RoleID, MenuNewID, Permission, zfbz  ");			
			strSql.Append("  from YIEMYRoleMenuPer ");
			strSql.Append(" where RoleID=@RoleID and MenuNewID=@MenuNewID ");
						SqlParameter[] parameters = {
					new SqlParameter("@RoleID", SqlDbType.VarChar,100),
					new SqlParameter("@MenuNewID", SqlDbType.VarChar,100)			};
			parameters[0].Value = RoleID;
			parameters[1].Value = MenuNewID;

			
			YIEternalMIS.Model.YIEMYRoleMenuPer model=new YIEternalMIS.Model.YIEMYRoleMenuPer();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			
			if(ds.Tables[0].Rows.Count>0)
			{
																model.RoleID= ds.Tables[0].Rows[0]["RoleID"].ToString();
																																model.MenuNewID= ds.Tables[0].Rows[0]["MenuNewID"].ToString();
																																model.Permission= ds.Tables[0].Rows[0]["Permission"].ToString();
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
			strSql.Append(" FROM YIEMYRoleMenuPer ");
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
			strSql.Append(" FROM YIEMYRoleMenuPer ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			strSql.Append(" order by " + filedOrder);
			return DbHelperSQL.Query(strSql.ToString());
		}

   
	}
}

