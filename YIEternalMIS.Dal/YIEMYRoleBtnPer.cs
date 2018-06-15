using System; 
using System.Text;
using System.Data.SqlClient;
using System.Collections.Generic; 
using System.Data;
using YIEternalMIS.DBUtility;
namespace YIEternalMIS.DAL  
{
	 	//YIEMYRoleBtnPer
		public partial class YIEMYRoleBtnPer
	{
   		     
		public bool Exists(string RoleID,string MenuNewID,string BtnName)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from YIEMYRoleBtnPer");
			strSql.Append(" where ");
			                                       strSql.Append(" RoleID = @RoleID and  ");
                                                                   strSql.Append(" MenuNewID = @MenuNewID and  ");
                                                                   strSql.Append(" BtnName = @BtnName  ");
                            			SqlParameter[] parameters = {
					new SqlParameter("@RoleID", SqlDbType.VarChar,100),
					new SqlParameter("@MenuNewID", SqlDbType.VarChar,100),
					new SqlParameter("@BtnName", SqlDbType.VarChar,50)			};
			parameters[0].Value = RoleID;
			parameters[1].Value = MenuNewID;
			parameters[2].Value = BtnName;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}
		
				
		
		/// <summary>
		/// 增加一条数据
		/// </summary>
		public void Add(YIEternalMIS.Model.YIEMYRoleBtnPer model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into YIEMYRoleBtnPer(");			
            strSql.Append("RoleID,MenuNewID,BtnName,BtnPermission");
			strSql.Append(") values (");
            strSql.Append("@RoleID,@MenuNewID,@BtnName,@BtnPermission");            
            strSql.Append(") ");            
            		
			SqlParameter[] parameters = {
			            new SqlParameter("@RoleID", SqlDbType.VarChar,100) ,            
                        new SqlParameter("@MenuNewID", SqlDbType.VarChar,100) ,            
                        new SqlParameter("@BtnName", SqlDbType.VarChar,50) ,            
                        new SqlParameter("@BtnPermission", SqlDbType.VarChar,10)             
              
            };
			            
            parameters[0].Value = model.RoleID;                        
            parameters[1].Value = model.MenuNewID;                        
            parameters[2].Value = model.BtnName;                        
            parameters[3].Value = model.BtnPermission;                        
			            DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
            			
		}
		
		
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(YIEternalMIS.Model.YIEMYRoleBtnPer model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update YIEMYRoleBtnPer set ");
			                        
            strSql.Append(" RoleID = @RoleID , ");                                    
            strSql.Append(" MenuNewID = @MenuNewID , ");                                    
            strSql.Append(" BtnName = @BtnName , ");                                    
            strSql.Append(" BtnPermission = @BtnPermission  ");            			
			strSql.Append(" where RoleID=@RoleID and MenuNewID=@MenuNewID and BtnName=@BtnName  ");
						
SqlParameter[] parameters = {
			            new SqlParameter("@RoleID", SqlDbType.VarChar,100) ,            
                        new SqlParameter("@MenuNewID", SqlDbType.VarChar,100) ,            
                        new SqlParameter("@BtnName", SqlDbType.VarChar,50) ,            
                        new SqlParameter("@BtnPermission", SqlDbType.VarChar,10)             
              
            };
						            
            parameters[0].Value = model.RoleID;                        
            parameters[1].Value = model.MenuNewID;                        
            parameters[2].Value = model.BtnName;                        
            parameters[3].Value = model.BtnPermission;                        
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
		public bool Delete(string RoleID,string MenuNewID,string BtnName)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from YIEMYRoleBtnPer ");
			strSql.Append(" where RoleID=@RoleID and MenuNewID=@MenuNewID and BtnName=@BtnName ");
						SqlParameter[] parameters = {
					new SqlParameter("@RoleID", SqlDbType.VarChar,100),
					new SqlParameter("@MenuNewID", SqlDbType.VarChar,100),
					new SqlParameter("@BtnName", SqlDbType.VarChar,50)			};
			parameters[0].Value = RoleID;
			parameters[1].Value = MenuNewID;
			parameters[2].Value = BtnName;


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
		public YIEternalMIS.Model.YIEMYRoleBtnPer GetModel(string RoleID,string MenuNewID,string BtnName)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select RoleID, MenuNewID, BtnName, BtnPermission  ");			
			strSql.Append("  from YIEMYRoleBtnPer ");
			strSql.Append(" where RoleID=@RoleID and MenuNewID=@MenuNewID and BtnName=@BtnName ");
						SqlParameter[] parameters = {
					new SqlParameter("@RoleID", SqlDbType.VarChar,100),
					new SqlParameter("@MenuNewID", SqlDbType.VarChar,100),
					new SqlParameter("@BtnName", SqlDbType.VarChar,50)			};
			parameters[0].Value = RoleID;
			parameters[1].Value = MenuNewID;
			parameters[2].Value = BtnName;

			
			YIEternalMIS.Model.YIEMYRoleBtnPer model=new YIEternalMIS.Model.YIEMYRoleBtnPer();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			
			if(ds.Tables[0].Rows.Count>0)
			{
																model.RoleID= ds.Tables[0].Rows[0]["RoleID"].ToString();
																																model.MenuNewID= ds.Tables[0].Rows[0]["MenuNewID"].ToString();
																																model.BtnName= ds.Tables[0].Rows[0]["BtnName"].ToString();
																																model.BtnPermission= ds.Tables[0].Rows[0]["BtnPermission"].ToString();
																										
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
			strSql.Append(" FROM YIEMYRoleBtnPer ");
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
			strSql.Append(" FROM YIEMYRoleBtnPer ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			strSql.Append(" order by " + filedOrder);
			return DbHelperSQL.Query(strSql.ToString());
		}

   
	}
}

