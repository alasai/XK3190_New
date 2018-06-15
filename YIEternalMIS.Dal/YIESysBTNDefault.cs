using System; 
using System.Text;
using System.Data.SqlClient;
using System.Collections.Generic; 
using System.Data;
using YIEternalMIS.DBUtility;
namespace YIEternalMIS.DAL  
{
	 	//YIESysBTNDefault
		public partial class YIESysBTNDefault
	{
   		     
		public bool Exists(string BtnName)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from YIESysBTNDefault");
			strSql.Append(" where ");
			                                       strSql.Append(" BtnName = @BtnName  ");
                            			SqlParameter[] parameters = {
					new SqlParameter("@BtnName", SqlDbType.VarChar,50)			};
			parameters[0].Value = BtnName;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}
		
				
		
		/// <summary>
		/// 增加一条数据
		/// </summary>
		public void Add(YIEternalMIS.Model.YIESysBTNDefault model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into YIESysBTNDefault(");			
            strSql.Append("BtnName,BtnText,BtnIMG,BtnAuthority,BtnIsToolBar,BtnTips,BtnGroupID,zfbz");
			strSql.Append(") values (");
            strSql.Append("@BtnName,@BtnText,@BtnIMG,@BtnAuthority,@BtnIsToolBar,@BtnTips,@BtnGroupID,@zfbz");            
            strSql.Append(") ");            
            		
			SqlParameter[] parameters = {
			            new SqlParameter("@BtnName", SqlDbType.VarChar,50) ,            
                        new SqlParameter("@BtnText", SqlDbType.VarChar,50) ,            
                        new SqlParameter("@BtnIMG", SqlDbType.VarChar,50) ,            
                        new SqlParameter("@BtnAuthority", SqlDbType.VarChar,10) ,            
                        new SqlParameter("@BtnIsToolBar", SqlDbType.VarChar,10) ,            
                        new SqlParameter("@BtnTips", SqlDbType.VarChar,200) ,            
                        new SqlParameter("@BtnGroupID", SqlDbType.VarChar,10) ,            
                        new SqlParameter("@zfbz", SqlDbType.VarChar,10)             
              
            };
			            
            parameters[0].Value = model.BtnName;                        
            parameters[1].Value = model.BtnText;                        
            parameters[2].Value = model.BtnIMG;                        
            parameters[3].Value = model.BtnAuthority;                        
            parameters[4].Value = model.BtnIsToolBar;                        
            parameters[5].Value = model.BtnTips;                        
            parameters[6].Value = model.BtnGroupID;                        
            parameters[7].Value = model.zfbz;                        
			            DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
            			
		}
		
		
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(YIEternalMIS.Model.YIESysBTNDefault model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update YIESysBTNDefault set ");
			                        
            strSql.Append(" BtnName = @BtnName , ");                                    
            strSql.Append(" BtnText = @BtnText , ");                                    
            strSql.Append(" BtnIMG = @BtnIMG , ");                                    
            strSql.Append(" BtnAuthority = @BtnAuthority , ");                                    
            strSql.Append(" BtnIsToolBar = @BtnIsToolBar , ");                                    
            strSql.Append(" BtnTips = @BtnTips , ");                                    
            strSql.Append(" BtnGroupID = @BtnGroupID , ");                                    
            strSql.Append(" zfbz = @zfbz  ");            			
			strSql.Append(" where BtnName=@BtnName  ");
						
SqlParameter[] parameters = {
			            new SqlParameter("@BtnName", SqlDbType.VarChar,50) ,            
                        new SqlParameter("@BtnText", SqlDbType.VarChar,50) ,            
                        new SqlParameter("@BtnIMG", SqlDbType.VarChar,50) ,            
                        new SqlParameter("@BtnAuthority", SqlDbType.VarChar,10) ,            
                        new SqlParameter("@BtnIsToolBar", SqlDbType.VarChar,10) ,            
                        new SqlParameter("@BtnTips", SqlDbType.VarChar,200) ,            
                        new SqlParameter("@BtnGroupID", SqlDbType.VarChar,10) ,            
                        new SqlParameter("@zfbz", SqlDbType.VarChar,10)             
              
            };
						            
            parameters[0].Value = model.BtnName;                        
            parameters[1].Value = model.BtnText;                        
            parameters[2].Value = model.BtnIMG;                        
            parameters[3].Value = model.BtnAuthority;                        
            parameters[4].Value = model.BtnIsToolBar;                        
            parameters[5].Value = model.BtnTips;                        
            parameters[6].Value = model.BtnGroupID;                        
            parameters[7].Value = model.zfbz;                        
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
		public bool Delete(string BtnName)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from YIESysBTNDefault ");
			strSql.Append(" where BtnName=@BtnName ");
						SqlParameter[] parameters = {
					new SqlParameter("@BtnName", SqlDbType.VarChar,50)			};
			parameters[0].Value = BtnName;


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
		public YIEternalMIS.Model.YIESysBTNDefault GetModel(string BtnName)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select BtnName, BtnText, BtnIMG, BtnAuthority, BtnIsToolBar, BtnTips, BtnGroupID, zfbz  ");			
			strSql.Append("  from YIESysBTNDefault ");
			strSql.Append(" where BtnName=@BtnName ");
						SqlParameter[] parameters = {
					new SqlParameter("@BtnName", SqlDbType.VarChar,50)			};
			parameters[0].Value = BtnName;

			
			YIEternalMIS.Model.YIESysBTNDefault model=new YIEternalMIS.Model.YIESysBTNDefault();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			
			if(ds.Tables[0].Rows.Count>0)
			{
																model.BtnName= ds.Tables[0].Rows[0]["BtnName"].ToString();
																																model.BtnText= ds.Tables[0].Rows[0]["BtnText"].ToString();
																																model.BtnIMG= ds.Tables[0].Rows[0]["BtnIMG"].ToString();
																																model.BtnAuthority= ds.Tables[0].Rows[0]["BtnAuthority"].ToString();
																																model.BtnIsToolBar= ds.Tables[0].Rows[0]["BtnIsToolBar"].ToString();
																																model.BtnTips= ds.Tables[0].Rows[0]["BtnTips"].ToString();
																																model.BtnGroupID= ds.Tables[0].Rows[0]["BtnGroupID"].ToString();
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
			strSql.Append(" FROM YIESysBTNDefault ");
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
			strSql.Append(" FROM YIESysBTNDefault ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			strSql.Append(" order by " + filedOrder);
			return DbHelperSQL.Query(strSql.ToString());
		}

   
	}
}

