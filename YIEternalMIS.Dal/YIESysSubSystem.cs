using System; 
using System.Text;
using System.Data.SqlClient;
using System.Collections.Generic; 
using System.Data;
using YIEternalMIS.DBUtility;
namespace YIEternalMIS.DAL  
{
	 	//YIESysSubSystem
		public partial class YIESysSubSystem
	{
   		     
		public bool Exists(string SysId)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from YIESysSubSystem");
			strSql.Append(" where ");
			                                       strSql.Append(" SysId = @SysId  ");
                            			SqlParameter[] parameters = {
					new SqlParameter("@SysId", SqlDbType.VarChar,20)			};
			parameters[0].Value = SysId;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}
		
				
		
		/// <summary>
		/// 增加一条数据
		/// </summary>
		public void Add(YIEternalMIS.Model.YIESysSubSystem model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into YIESysSubSystem(");			
            strSql.Append("SysId,SysName,Licenses");
			strSql.Append(") values (");
            strSql.Append("@SysId,@SysName,@Licenses");            
            strSql.Append(") ");            
            		
			SqlParameter[] parameters = {
			            new SqlParameter("@SysId", SqlDbType.VarChar,20) ,            
                        new SqlParameter("@SysName", SqlDbType.VarChar,50) ,            
                        new SqlParameter("@Licenses", SqlDbType.VarChar,200)             
              
            };
			            
            parameters[0].Value = model.SysId;                        
            parameters[1].Value = model.SysName;                        
            parameters[2].Value = model.Licenses;                        
			            DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
            			
		}
		
		
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(YIEternalMIS.Model.YIESysSubSystem model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update YIESysSubSystem set ");
			                        
            strSql.Append(" SysId = @SysId , ");                                    
            strSql.Append(" SysName = @SysName , ");                                    
            strSql.Append(" Licenses = @Licenses  ");            			
			strSql.Append(" where SysId=@SysId  ");
						
SqlParameter[] parameters = {
			            new SqlParameter("@SysId", SqlDbType.VarChar,20) ,            
                        new SqlParameter("@SysName", SqlDbType.VarChar,50) ,            
                        new SqlParameter("@Licenses", SqlDbType.VarChar,200)             
              
            };
						            
            parameters[0].Value = model.SysId;                        
            parameters[1].Value = model.SysName;                        
            parameters[2].Value = model.Licenses;                        
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
		public bool Delete(string SysId)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from YIESysSubSystem ");
			strSql.Append(" where SysId=@SysId ");
						SqlParameter[] parameters = {
					new SqlParameter("@SysId", SqlDbType.VarChar,20)			};
			parameters[0].Value = SysId;


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
		public YIEternalMIS.Model.YIESysSubSystem GetModel(string SysId)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select SysId, SysName, Licenses  ");			
			strSql.Append("  from YIESysSubSystem ");
			strSql.Append(" where SysId=@SysId ");
						SqlParameter[] parameters = {
					new SqlParameter("@SysId", SqlDbType.VarChar,20)			};
			parameters[0].Value = SysId;

			
			YIEternalMIS.Model.YIESysSubSystem model=new YIEternalMIS.Model.YIESysSubSystem();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			
			if(ds.Tables[0].Rows.Count>0)
			{
																model.SysId= ds.Tables[0].Rows[0]["SysId"].ToString();
																																model.SysName= ds.Tables[0].Rows[0]["SysName"].ToString();
																																model.Licenses= ds.Tables[0].Rows[0]["Licenses"].ToString();
																										
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
			strSql.Append(" FROM YIESysSubSystem ");
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
			strSql.Append(" FROM YIESysSubSystem ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			strSql.Append(" order by " + filedOrder);
			return DbHelperSQL.Query(strSql.ToString());
		}

   
	}
}

