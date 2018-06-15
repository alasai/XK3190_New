using System; 
using System.Text;
using System.Data.SqlClient;
using System.Collections.Generic; 
using System.Data;
using YIEternalMIS.DBUtility;
namespace YIEternalMIS.DAL  
{
	 	//YIEMYRole
		public partial class YIEMYRole
	{
   		     
		public bool Exists(string RoleID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from YIEMYRole");
			strSql.Append(" where ");
			                                       strSql.Append(" RoleID = @RoleID  ");
                            			SqlParameter[] parameters = {
					new SqlParameter("@RoleID", SqlDbType.VarChar,100)			};
			parameters[0].Value = RoleID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}
		
				
		
		/// <summary>
		/// 增加一条数据
		/// </summary>
		public void Add(YIEternalMIS.Model.YIEMYRole model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into YIEMYRole(");			
            strSql.Append("RoleID,RoleName,RoleBZ,zfbz");
			strSql.Append(") values (");
            strSql.Append("@RoleID,@RoleName,@RoleBZ,@zfbz");            
            strSql.Append(") ");            
            		
			SqlParameter[] parameters = {
			            new SqlParameter("@RoleID", SqlDbType.VarChar,100) ,            
                        new SqlParameter("@RoleName", SqlDbType.VarChar,50) ,            
                        new SqlParameter("@RoleBZ", SqlDbType.VarChar,50) ,            
                        new SqlParameter("@zfbz", SqlDbType.VarChar,10)             
              
            };
			            
            parameters[0].Value = model.RoleID;                        
            parameters[1].Value = model.RoleName;                        
            parameters[2].Value = model.RoleBZ;                        
            parameters[3].Value = model.zfbz;                        
			            DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
            			
		}
		
		
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(YIEternalMIS.Model.YIEMYRole model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update YIEMYRole set ");
			                        
            strSql.Append(" RoleID = @RoleID , ");                                    
            strSql.Append(" RoleName = @RoleName , ");                                    
            strSql.Append(" RoleBZ = @RoleBZ , ");                                    
            strSql.Append(" zfbz = @zfbz  ");            			
			strSql.Append(" where RoleID=@RoleID  ");
						
SqlParameter[] parameters = {
			            new SqlParameter("@RoleID", SqlDbType.VarChar,100) ,            
                        new SqlParameter("@RoleName", SqlDbType.VarChar,50) ,            
                        new SqlParameter("@RoleBZ", SqlDbType.VarChar,50) ,            
                        new SqlParameter("@zfbz", SqlDbType.VarChar,10)             
              
            };
						            
            parameters[0].Value = model.RoleID;                        
            parameters[1].Value = model.RoleName;                        
            parameters[2].Value = model.RoleBZ;                        
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
		public bool Delete(string RoleID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from YIEMYRole ");
			strSql.Append(" where RoleID=@RoleID ");
						SqlParameter[] parameters = {
					new SqlParameter("@RoleID", SqlDbType.VarChar,100)			};
			parameters[0].Value = RoleID;


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
		public YIEternalMIS.Model.YIEMYRole GetModel(string RoleID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select RoleID, RoleName, RoleBZ, zfbz  ");			
			strSql.Append("  from YIEMYRole ");
			strSql.Append(" where RoleID=@RoleID ");
						SqlParameter[] parameters = {
					new SqlParameter("@RoleID", SqlDbType.VarChar,100)			};
			parameters[0].Value = RoleID;

			
			YIEternalMIS.Model.YIEMYRole model=new YIEternalMIS.Model.YIEMYRole();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			
			if(ds.Tables[0].Rows.Count>0)
			{
																model.RoleID= ds.Tables[0].Rows[0]["RoleID"].ToString();
																																model.RoleName= ds.Tables[0].Rows[0]["RoleName"].ToString();
																																model.RoleBZ= ds.Tables[0].Rows[0]["RoleBZ"].ToString();
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
			strSql.Append(" FROM YIEMYRole ");
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
			strSql.Append(" FROM YIEMYRole ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			strSql.Append(" order by " + filedOrder);
			return DbHelperSQL.Query(strSql.ToString());
		}

   
	}
}

