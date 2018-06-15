using System; 
using System.Text;
using System.Data.SqlClient;
using System.Collections.Generic; 
using System.Data;
using YIEternalMIS.DBUtility;
namespace YIEternalMIS.DAL  
{
	 	//YIESysParameter
		public partial class YIESysParameter
	{
   		     
		public bool Exists(decimal Sysxh)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from YIESysParameter");
			strSql.Append(" where ");
			                                       strSql.Append(" Sysxh = @Sysxh  ");
                            			SqlParameter[] parameters = {
					new SqlParameter("@Sysxh", SqlDbType.Decimal)
			};
			parameters[0].Value = Sysxh;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}
		
				
		
		/// <summary>
		/// 增加一条数据
		/// </summary>
		public decimal Add(YIEternalMIS.Model.YIESysParameter model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into YIESysParameter(");			
            strSql.Append("SysText,SysValue,SysSdate,SysEdate,UserEdit,zfbz");
			strSql.Append(") values (");
            strSql.Append("@SysText,@SysValue,@SysSdate,@SysEdate,@UserEdit,@zfbz");            
            strSql.Append(") ");            
            strSql.Append(";select @@IDENTITY");		
			SqlParameter[] parameters = {
			            new SqlParameter("@SysText", SqlDbType.VarChar,200) ,            
                        new SqlParameter("@SysValue", SqlDbType.VarChar,50) ,            
                        new SqlParameter("@SysSdate", SqlDbType.DateTime) ,            
                        new SqlParameter("@SysEdate", SqlDbType.DateTime) ,            
                        new SqlParameter("@UserEdit", SqlDbType.VarChar,10) ,            
                        new SqlParameter("@zfbz", SqlDbType.VarChar,10)             
              
            };
			            
            parameters[0].Value = model.SysText;                        
            parameters[1].Value = model.SysValue;                        
            parameters[2].Value = model.SysSdate;                        
            parameters[3].Value = model.SysEdate;                        
            parameters[4].Value = model.UserEdit;                        
            parameters[5].Value = model.zfbz;                        
			   
			object obj = DbHelperSQL.GetSingle(strSql.ToString(),parameters);			
			if (obj == null)
			{
				return 0;
			}
			else
			{
				                                                    
            	return Convert.ToDecimal(obj);
                                  
			}			   
            			
		}
		
		
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(YIEternalMIS.Model.YIESysParameter model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update YIESysParameter set ");
			                                                
            strSql.Append(" SysText = @SysText , ");                                    
            strSql.Append(" SysValue = @SysValue , ");                                    
            strSql.Append(" SysSdate = @SysSdate , ");                                    
            strSql.Append(" SysEdate = @SysEdate , ");                                    
            strSql.Append(" UserEdit = @UserEdit , ");                                    
            strSql.Append(" zfbz = @zfbz  ");            			
			strSql.Append(" where Sysxh=@Sysxh ");
						
SqlParameter[] parameters = {
			            new SqlParameter("@Sysxh", SqlDbType.Decimal,9) ,            
                        new SqlParameter("@SysText", SqlDbType.VarChar,200) ,            
                        new SqlParameter("@SysValue", SqlDbType.VarChar,50) ,            
                        new SqlParameter("@SysSdate", SqlDbType.DateTime) ,            
                        new SqlParameter("@SysEdate", SqlDbType.DateTime) ,            
                        new SqlParameter("@UserEdit", SqlDbType.VarChar,10) ,            
                        new SqlParameter("@zfbz", SqlDbType.VarChar,10)             
              
            };
						            
            parameters[0].Value = model.Sysxh;                        
            parameters[1].Value = model.SysText;                        
            parameters[2].Value = model.SysValue;                        
            parameters[3].Value = model.SysSdate;                        
            parameters[4].Value = model.SysEdate;                        
            parameters[5].Value = model.UserEdit;                        
            parameters[6].Value = model.zfbz;                        
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
		public bool Delete(decimal Sysxh)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from YIESysParameter ");
			strSql.Append(" where Sysxh=@Sysxh");
						SqlParameter[] parameters = {
					new SqlParameter("@Sysxh", SqlDbType.Decimal)
			};
			parameters[0].Value = Sysxh;


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
		/// 批量删除一批数据
		/// </summary>
		public bool DeleteList(string Sysxhlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from YIESysParameter ");
			strSql.Append(" where ID in ("+Sysxhlist + ")  ");
			int rows=DbHelperSQL.ExecuteSql(strSql.ToString());
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
		public YIEternalMIS.Model.YIESysParameter GetModel(decimal Sysxh)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select Sysxh, SysText, SysValue, SysSdate, SysEdate, UserEdit, zfbz  ");			
			strSql.Append("  from YIESysParameter ");
			strSql.Append(" where Sysxh=@Sysxh");
						SqlParameter[] parameters = {
					new SqlParameter("@Sysxh", SqlDbType.Decimal)
			};
			parameters[0].Value = Sysxh;

			
			YIEternalMIS.Model.YIESysParameter model=new YIEternalMIS.Model.YIESysParameter();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			
			if(ds.Tables[0].Rows.Count>0)
			{
												if(ds.Tables[0].Rows[0]["Sysxh"].ToString()!="")
				{
					model.Sysxh=decimal.Parse(ds.Tables[0].Rows[0]["Sysxh"].ToString());
				}
																																				model.SysText= ds.Tables[0].Rows[0]["SysText"].ToString();
																																model.SysValue= ds.Tables[0].Rows[0]["SysValue"].ToString();
																												if(ds.Tables[0].Rows[0]["SysSdate"].ToString()!="")
				{
					model.SysSdate=DateTime.Parse(ds.Tables[0].Rows[0]["SysSdate"].ToString());
				}
																																if(ds.Tables[0].Rows[0]["SysEdate"].ToString()!="")
				{
					model.SysEdate=DateTime.Parse(ds.Tables[0].Rows[0]["SysEdate"].ToString());
				}
																																				model.UserEdit= ds.Tables[0].Rows[0]["UserEdit"].ToString();
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
			strSql.Append(" FROM YIESysParameter ");
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
			strSql.Append(" FROM YIESysParameter ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			strSql.Append(" order by " + filedOrder);
			return DbHelperSQL.Query(strSql.ToString());
		}

   
	}
}

