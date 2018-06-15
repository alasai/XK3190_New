using System; 
using System.Text;
using System.Data.SqlClient;
using System.Collections.Generic; 
using System.Data;
using YIEternalMIS.DBUtility;
namespace YIEternalMIS.DAL  
{
	 	//YIESysDropData
		public partial class YIESysDropData
	{
   		     
		public bool Exists(decimal DPXH)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from YIESysDropData");
			strSql.Append(" where ");
			                                       strSql.Append(" DPXH = @DPXH  ");
                            			SqlParameter[] parameters = {
					new SqlParameter("@DPXH", SqlDbType.Decimal)
			};
			parameters[0].Value = DPXH;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}
		
				
		
		/// <summary>
		/// 增加一条数据
		/// </summary>
		public decimal Add(YIEternalMIS.Model.YIESysDropData model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into YIESysDropData(");			
            strSql.Append("DPName,ColName,ColText,ColValue,ColDisplay");
			strSql.Append(") values (");
            strSql.Append("@DPName,@ColName,@ColText,@ColValue,@ColDisplay");            
            strSql.Append(") ");            
            strSql.Append(";select @@IDENTITY");		
			SqlParameter[] parameters = {
			            new SqlParameter("@DPName", SqlDbType.VarChar,50) ,            
                        new SqlParameter("@ColName", SqlDbType.VarChar,50) ,            
                        new SqlParameter("@ColText", SqlDbType.VarChar,50) ,            
                        new SqlParameter("@ColValue", SqlDbType.VarChar,50) ,            
                        new SqlParameter("@ColDisplay", SqlDbType.VarChar,50)             
              
            };
			            
            parameters[0].Value = model.DPName;                        
            parameters[1].Value = model.ColName;                        
            parameters[2].Value = model.ColText;                        
            parameters[3].Value = model.ColValue;                        
            parameters[4].Value = model.ColDisplay;                        
			   
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
		public bool Update(YIEternalMIS.Model.YIESysDropData model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update YIESysDropData set ");
			                                                
            strSql.Append(" DPName = @DPName , ");                                    
            strSql.Append(" ColName = @ColName , ");                                    
            strSql.Append(" ColText = @ColText , ");                                    
            strSql.Append(" ColValue = @ColValue , ");                                    
            strSql.Append(" ColDisplay = @ColDisplay  ");            			
			strSql.Append(" where DPXH=@DPXH ");
						
SqlParameter[] parameters = {
			            new SqlParameter("@DPXH", SqlDbType.Decimal,9) ,            
                        new SqlParameter("@DPName", SqlDbType.VarChar,50) ,            
                        new SqlParameter("@ColName", SqlDbType.VarChar,50) ,            
                        new SqlParameter("@ColText", SqlDbType.VarChar,50) ,            
                        new SqlParameter("@ColValue", SqlDbType.VarChar,50) ,            
                        new SqlParameter("@ColDisplay", SqlDbType.VarChar,50)             
              
            };
						            
            parameters[0].Value = model.DPXH;                        
            parameters[1].Value = model.DPName;                        
            parameters[2].Value = model.ColName;                        
            parameters[3].Value = model.ColText;                        
            parameters[4].Value = model.ColValue;                        
            parameters[5].Value = model.ColDisplay;                        
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
		public bool Delete(decimal DPXH)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from YIESysDropData ");
			strSql.Append(" where DPXH=@DPXH");
						SqlParameter[] parameters = {
					new SqlParameter("@DPXH", SqlDbType.Decimal)
			};
			parameters[0].Value = DPXH;


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
		public bool DeleteList(string DPXHlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from YIESysDropData ");
			strSql.Append(" where ID in ("+DPXHlist + ")  ");
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
		public YIEternalMIS.Model.YIESysDropData GetModel(decimal DPXH)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select DPXH, DPName, ColName, ColText, ColValue, ColDisplay  ");			
			strSql.Append("  from YIESysDropData ");
			strSql.Append(" where DPXH=@DPXH");
						SqlParameter[] parameters = {
					new SqlParameter("@DPXH", SqlDbType.Decimal)
			};
			parameters[0].Value = DPXH;

			
			YIEternalMIS.Model.YIESysDropData model=new YIEternalMIS.Model.YIESysDropData();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			
			if(ds.Tables[0].Rows.Count>0)
			{
												if(ds.Tables[0].Rows[0]["DPXH"].ToString()!="")
				{
					model.DPXH=decimal.Parse(ds.Tables[0].Rows[0]["DPXH"].ToString());
				}
																																				model.DPName= ds.Tables[0].Rows[0]["DPName"].ToString();
																																model.ColName= ds.Tables[0].Rows[0]["ColName"].ToString();
																																model.ColText= ds.Tables[0].Rows[0]["ColText"].ToString();
																																model.ColValue= ds.Tables[0].Rows[0]["ColValue"].ToString();
																																model.ColDisplay= ds.Tables[0].Rows[0]["ColDisplay"].ToString();
																										
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
			strSql.Append(" FROM YIESysDropData ");
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
			strSql.Append(" FROM YIESysDropData ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			strSql.Append(" order by " + filedOrder);
			return DbHelperSQL.Query(strSql.ToString());
		}

   
	}
}

