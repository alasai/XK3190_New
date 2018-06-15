using System; 
using System.Text;
using System.Data.SqlClient;
using System.Collections.Generic; 
using System.Data;
using YIEternalMIS.DBUtility;
namespace YIEternalMIS.DAL  
{
	 	//YIESysPriKey
		public partial class YIESysPriKey
	{
   		     
		public bool Exists()
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from YIESysPriKey");
			strSql.Append(" where ");
			                            			SqlParameter[] parameters = {
					new SqlParameter("@NameID", SqlDbType.Int,4)
			};
			parameters[0].Value = NameID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}
		
				
		
		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(YIEternalMIS.Model.YIESysPriKey model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into YIESysPriKey(");			
            strSql.Append("Name,Days,Head,CurrentNo,BHLen,Yearmoth,DESCRIPTION,TableName,keyfieldName,userbz");
			strSql.Append(") values (");
            strSql.Append("@Name,@Days,@Head,@CurrentNo,@BHLen,@Yearmoth,@DESCRIPTION,@TableName,@keyfieldName,@userbz");            
            strSql.Append(") ");            
            strSql.Append(";select @@IDENTITY");		
			SqlParameter[] parameters = {
			            new SqlParameter("@Name", SqlDbType.VarChar,20) ,            
                        new SqlParameter("@Days", SqlDbType.Int,4) ,            
                        new SqlParameter("@Head", SqlDbType.VarChar,50) ,            
                        new SqlParameter("@CurrentNo", SqlDbType.Int,4) ,            
                        new SqlParameter("@BHLen", SqlDbType.Int,4) ,            
                        new SqlParameter("@Yearmoth", SqlDbType.Int,4) ,            
                        new SqlParameter("@DESCRIPTION", SqlDbType.VarChar,50) ,            
                        new SqlParameter("@TableName", SqlDbType.VarChar,50) ,            
                        new SqlParameter("@keyfieldName", SqlDbType.VarChar,50) ,            
                        new SqlParameter("@userbz", SqlDbType.VarChar,50)             
              
            };
			            
            parameters[0].Value = model.Name;                        
            parameters[1].Value = model.Days;                        
            parameters[2].Value = model.Head;                        
            parameters[3].Value = model.CurrentNo;                        
            parameters[4].Value = model.BHLen;                        
            parameters[5].Value = model.Yearmoth;                        
            parameters[6].Value = model.DESCRIPTION;                        
            parameters[7].Value = model.TableName;                        
            parameters[8].Value = model.keyfieldName;                        
            parameters[9].Value = model.userbz;                        
			   
			object obj = DbHelperSQL.GetSingle(strSql.ToString(),parameters);			
			if (obj == null)
			{
				return 0;
			}
			else
			{
				                    
            	return Convert.ToInt32(obj);
                                                                  
			}			   
            			
		}
		
		
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(YIEternalMIS.Model.YIESysPriKey model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update YIESysPriKey set ");
			                                                
            strSql.Append(" Name = @Name , ");                                    
            strSql.Append(" Days = @Days , ");                                    
            strSql.Append(" Head = @Head , ");                                    
            strSql.Append(" CurrentNo = @CurrentNo , ");                                    
            strSql.Append(" BHLen = @BHLen , ");                                    
            strSql.Append(" Yearmoth = @Yearmoth , ");                                    
            strSql.Append(" DESCRIPTION = @DESCRIPTION , ");                                    
            strSql.Append(" TableName = @TableName , ");                                    
            strSql.Append(" keyfieldName = @keyfieldName , ");                                    
            strSql.Append(" userbz = @userbz  ");            			
			strSql.Append(" where NameID=@NameID ");
						
SqlParameter[] parameters = {
			            new SqlParameter("@NameID", SqlDbType.Int,4) ,            
                        new SqlParameter("@Name", SqlDbType.VarChar,20) ,            
                        new SqlParameter("@Days", SqlDbType.Int,4) ,            
                        new SqlParameter("@Head", SqlDbType.VarChar,50) ,            
                        new SqlParameter("@CurrentNo", SqlDbType.Int,4) ,            
                        new SqlParameter("@BHLen", SqlDbType.Int,4) ,            
                        new SqlParameter("@Yearmoth", SqlDbType.Int,4) ,            
                        new SqlParameter("@DESCRIPTION", SqlDbType.VarChar,50) ,            
                        new SqlParameter("@TableName", SqlDbType.VarChar,50) ,            
                        new SqlParameter("@keyfieldName", SqlDbType.VarChar,50) ,            
                        new SqlParameter("@userbz", SqlDbType.VarChar,50)             
              
            };
						            
            parameters[0].Value = model.NameID;                        
            parameters[1].Value = model.Name;                        
            parameters[2].Value = model.Days;                        
            parameters[3].Value = model.Head;                        
            parameters[4].Value = model.CurrentNo;                        
            parameters[5].Value = model.BHLen;                        
            parameters[6].Value = model.Yearmoth;                        
            parameters[7].Value = model.DESCRIPTION;                        
            parameters[8].Value = model.TableName;                        
            parameters[9].Value = model.keyfieldName;                        
            parameters[10].Value = model.userbz;                        
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
		public bool Delete(int NameID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from YIESysPriKey ");
			strSql.Append(" where NameID=@NameID");
						SqlParameter[] parameters = {
					new SqlParameter("@NameID", SqlDbType.Int,4)
			};
			parameters[0].Value = NameID;


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
		public bool DeleteList(string NameIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from YIESysPriKey ");
			strSql.Append(" where ID in ("+NameIDlist + ")  ");
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
		public YIEternalMIS.Model.YIESysPriKey GetModel(int NameID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select NameID, Name, Days, Head, CurrentNo, BHLen, Yearmoth, DESCRIPTION, TableName, keyfieldName, userbz  ");			
			strSql.Append("  from YIESysPriKey ");
			strSql.Append(" where NameID=@NameID");
						SqlParameter[] parameters = {
					new SqlParameter("@NameID", SqlDbType.Int,4)
			};
			parameters[0].Value = NameID;

			
			YIEternalMIS.Model.YIESysPriKey model=new YIEternalMIS.Model.YIESysPriKey();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			
			if(ds.Tables[0].Rows.Count>0)
			{
												if(ds.Tables[0].Rows[0]["NameID"].ToString()!="")
				{
					model.NameID=int.Parse(ds.Tables[0].Rows[0]["NameID"].ToString());
				}
																																				model.Name= ds.Tables[0].Rows[0]["Name"].ToString();
																												if(ds.Tables[0].Rows[0]["Days"].ToString()!="")
				{
					model.Days=int.Parse(ds.Tables[0].Rows[0]["Days"].ToString());
				}
																																				model.Head= ds.Tables[0].Rows[0]["Head"].ToString();
																												if(ds.Tables[0].Rows[0]["CurrentNo"].ToString()!="")
				{
					model.CurrentNo=int.Parse(ds.Tables[0].Rows[0]["CurrentNo"].ToString());
				}
																																if(ds.Tables[0].Rows[0]["BHLen"].ToString()!="")
				{
					model.BHLen=int.Parse(ds.Tables[0].Rows[0]["BHLen"].ToString());
				}
																																if(ds.Tables[0].Rows[0]["Yearmoth"].ToString()!="")
				{
					model.Yearmoth=int.Parse(ds.Tables[0].Rows[0]["Yearmoth"].ToString());
				}
																																				model.DESCRIPTION= ds.Tables[0].Rows[0]["DESCRIPTION"].ToString();
																																model.TableName= ds.Tables[0].Rows[0]["TableName"].ToString();
																																model.keyfieldName= ds.Tables[0].Rows[0]["keyfieldName"].ToString();
																																model.userbz= ds.Tables[0].Rows[0]["userbz"].ToString();
																										
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
			strSql.Append(" FROM YIESysPriKey ");
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
			strSql.Append(" FROM YIESysPriKey ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			strSql.Append(" order by " + filedOrder);
			return DbHelperSQL.Query(strSql.ToString());
		}

   
	}
}

