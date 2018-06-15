using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using YIEternalMIS.DBUtility;//Please add references
namespace YIEternalMIS.DAL
{
    /// <summary>
    /// 数据访问类:YIESysRegister
    /// </summary>
    public partial class YIESysRegister
    {
        public YIESysRegister()
        { }
        #region  BasicMethod

        /// <summary>
        /// 得到最大ID
        /// </summary>
        public int GetMaxId()
        {
            return DbHelperSQL.GetMaxID("YIEID", "YIESystemRegister");
        }

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int YIEID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from YIESystemRegister");
            strSql.Append(" where YIEID=@YIEID ");
            SqlParameter[] parameters = {
					new SqlParameter("@YIEID", SqlDbType.Int,4)			};
            parameters[0].Value = YIEID;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(YIEternalMIS.Model.YIESysRegister model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into YIESystemRegister(");
            strSql.Append("YIEID,YIEApplication,YIEMSGTitle,YIEAuthorizeUser,YIELicenses,Sdate,Edate,SysType)");
            strSql.Append(" values (");
            strSql.Append("@YIEID,@YIEApplication,@YIEMSGTitle,@YIEAuthorizeUser,@YIELicenses,@Sdate,@Edate,@SysType)");
            SqlParameter[] parameters = {
					new SqlParameter("@YIEID", SqlDbType.Int,4),
					new SqlParameter("@YIEApplication", SqlDbType.VarChar,50),
					new SqlParameter("@YIEMSGTitle", SqlDbType.VarChar,50),
					new SqlParameter("@YIEAuthorizeUser", SqlDbType.VarChar,50),
					new SqlParameter("@YIELicenses", SqlDbType.VarChar,200),
					new SqlParameter("@Sdate", SqlDbType.DateTime),
					new SqlParameter("@Edate", SqlDbType.DateTime),
					new SqlParameter("@SysType", SqlDbType.Int,4)};
            parameters[0].Value = model.YIEID;
            parameters[1].Value = model.YIEApplication;
            parameters[2].Value = model.YIEMSGTitle;
            parameters[3].Value = model.YIEAuthorizeUser;
            parameters[4].Value = model.YIELicenses;
            parameters[5].Value = model.Sdate;
            parameters[6].Value = model.Edate;
            parameters[7].Value = model.SysType;

            int rows = DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
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
        /// 更新一条数据
        /// </summary>
        public bool Update(YIEternalMIS.Model.YIESysRegister model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update YIESystemRegister set ");
            strSql.Append("YIEApplication=@YIEApplication,");
            strSql.Append("YIEMSGTitle=@YIEMSGTitle,");
            strSql.Append("YIEAuthorizeUser=@YIEAuthorizeUser,");
            strSql.Append("YIELicenses=@YIELicenses,");
            strSql.Append("Sdate=@Sdate,");
            strSql.Append("Edate=@Edate,");
            strSql.Append("SysType=@SysType");
            strSql.Append(" where YIEID=@YIEID ");
            SqlParameter[] parameters = {
					new SqlParameter("@YIEApplication", SqlDbType.VarChar,50),
					new SqlParameter("@YIEMSGTitle", SqlDbType.VarChar,50),
					new SqlParameter("@YIEAuthorizeUser", SqlDbType.VarChar,50),
					new SqlParameter("@YIELicenses", SqlDbType.VarChar,200),
					new SqlParameter("@Sdate", SqlDbType.DateTime),
					new SqlParameter("@Edate", SqlDbType.DateTime),
					new SqlParameter("@SysType", SqlDbType.Int,4),
					new SqlParameter("@YIEID", SqlDbType.Int,4)};
            parameters[0].Value = model.YIEApplication;
            parameters[1].Value = model.YIEMSGTitle;
            parameters[2].Value = model.YIEAuthorizeUser;
            parameters[3].Value = model.YIELicenses;
            parameters[4].Value = model.Sdate;
            parameters[5].Value = model.Edate;
            parameters[6].Value = model.SysType;
            parameters[7].Value = model.YIEID;

            int rows = DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
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
        public bool Delete(int YIEID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from YIESystemRegister ");
            strSql.Append(" where YIEID=@YIEID ");
            SqlParameter[] parameters = {
					new SqlParameter("@YIEID", SqlDbType.Int,4)			};
            parameters[0].Value = YIEID;

            int rows = DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
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
        /// 批量删除数据
        /// </summary>
        public bool DeleteList(string YIEIDlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from YIESystemRegister ");
            strSql.Append(" where YIEID in (" + YIEIDlist + ")  ");
            int rows = DbHelperSQL.ExecuteSql(strSql.ToString());
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
        public YIEternalMIS.Model.YIESysRegister GetModel(int YIEID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 YIEID,YIEApplication,YIEMSGTitle,YIEAuthorizeUser,YIELicenses,Sdate,Edate,SysType from YIESystemRegister ");
            strSql.Append(" where YIEID=@YIEID ");
            SqlParameter[] parameters = {
					new SqlParameter("@YIEID", SqlDbType.Int,4)			};
            parameters[0].Value = YIEID;

            YIEternalMIS.Model.YIESysRegister model = new YIEternalMIS.Model.YIESysRegister();
            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                return DataRowToModel(ds.Tables[0].Rows[0]);
            }
            else
            {
                return null;
            }
        }


        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public YIEternalMIS.Model.YIESysRegister DataRowToModel(DataRow row)
        {
            YIEternalMIS.Model.YIESysRegister model = new YIEternalMIS.Model.YIESysRegister();
            if (row != null)
            {
                if (row["YIEID"] != null && row["YIEID"].ToString() != "")
                {
                    model.YIEID = int.Parse(row["YIEID"].ToString());
                }
                if (row["YIEApplication"] != null)
                {
                    model.YIEApplication = row["YIEApplication"].ToString();
                }
                if (row["YIEMSGTitle"] != null)
                {
                    model.YIEMSGTitle = row["YIEMSGTitle"].ToString();
                }
                if (row["YIEAuthorizeUser"] != null)
                {
                    model.YIEAuthorizeUser = row["YIEAuthorizeUser"].ToString();
                }
                if (row["YIELicenses"] != null)
                {
                    model.YIELicenses = row["YIELicenses"].ToString();
                }
                if (row["Sdate"] != null && row["Sdate"].ToString() != "")
                {
                    model.Sdate = DateTime.Parse(row["Sdate"].ToString());
                }
                if (row["Edate"] != null && row["Edate"].ToString() != "")
                {
                    model.Edate = DateTime.Parse(row["Edate"].ToString());
                }
                if (row["SysType"] != null && row["SysType"].ToString() != "")
                {
                    model.SysType = int.Parse(row["SysType"].ToString());
                }
            }
            return model;
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select YIEID,YIEApplication,YIEMSGTitle,YIEAuthorizeUser,YIELicenses,Sdate,Edate,SysType ");
            strSql.Append(" FROM YIESystemRegister ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperSQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 获得前几行数据
        /// </summary>
        public DataSet GetList(int Top, string strWhere, string filedOrder)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ");
            if (Top > 0)
            {
                strSql.Append(" top " + Top.ToString());
            }
            strSql.Append(" YIEID,YIEApplication,YIEMSGTitle,YIEAuthorizeUser,YIELicenses,Sdate,Edate,SysType ");
            strSql.Append(" FROM YIESystemRegister ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" order by " + filedOrder);
            return DbHelperSQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 获取系统时间
        /// </summary>
        /// <returns></returns>
        public DateTime GetServerDateTime()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select TOP 1 GetDate() ");
            strSql.Append(" FROM YIESystemRegister ");

             DataSet ds = DbHelperSQL.Query(strSql.ToString());
            if (ds.Tables[0].Rows.Count > 0)
            {
                return  YIEternalMIS.Common.Convertto.ToNotNULLDateTime(ds.Tables[0].Rows[0][0]);
            }
            else
            {
                return DateTime.Now;
            }
        }

        /// <summary>
        /// 获取记录总数
        /// </summary>
        public int GetRecordCount(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) FROM YIESystemRegister ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            object obj = DbHelperSQL.GetSingle(strSql.ToString());
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
        /// 分页获取数据列表
        /// </summary>
        public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT * FROM ( ");
            strSql.Append(" SELECT ROW_NUMBER() OVER (");
            if (!string.IsNullOrEmpty(orderby.Trim()))
            {
                strSql.Append("order by T." + orderby);
            }
            else
            {
                strSql.Append("order by T.YIEID desc");
            }
            strSql.Append(")AS Row, T.*  from YIESystemRegister T ");
            if (!string.IsNullOrEmpty(strWhere.Trim()))
            {
                strSql.Append(" WHERE " + strWhere);
            }
            strSql.Append(" ) TT");
            strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
            return DbHelperSQL.Query(strSql.ToString());
        }

        /*
        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public DataSet GetList(int PageSize,int PageIndex,string strWhere)
        {
            SqlParameter[] parameters = {
                    new SqlParameter("@tblName", SqlDbType.VarChar, 255),
                    new SqlParameter("@fldName", SqlDbType.VarChar, 255),
                    new SqlParameter("@PageSize", SqlDbType.Int),
                    new SqlParameter("@PageIndex", SqlDbType.Int),
                    new SqlParameter("@IsReCount", SqlDbType.Bit),
                    new SqlParameter("@OrderType", SqlDbType.Bit),
                    new SqlParameter("@strWhere", SqlDbType.VarChar,1000),
                    };
            parameters[0].Value = "YIESysRegister";
            parameters[1].Value = "YIEID";
            parameters[2].Value = PageSize;
            parameters[3].Value = PageIndex;
            parameters[4].Value = 0;
            parameters[5].Value = 0;
            parameters[6].Value = strWhere;	
            return DbHelperSQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
        }*/

        #endregion  BasicMethod
        #region  ExtensionMethod

        #endregion  ExtensionMethod
    }
}

