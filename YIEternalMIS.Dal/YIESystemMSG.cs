/*************************************************************************************
    * 类 名 称：       YIESystemMSG
    * 命名空间：       YIEternalMIS.Dal
    * 文 件 名：       YIESystemMSG
    * 创建时间：       2017/6/23 10:53:14
    * 作    者：        王宏巍
    * 说   明：
    * 修改时间：
    * 修 改 人：
*************************************************************************************/
using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using YIEternalMIS.DBUtility;//Please add references

namespace YIEternalMIS.DAL
{
    /// <summary>
    /// 数据访问类:YIESystemMSG
    /// </summary>
    public partial class YIESystemMSG
    {
        public YIESystemMSG()
        { }
        #region  BasicMethod

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string MsgID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from YIESystemMSG");
            strSql.Append(" where MsgID=@MsgID ");
            SqlParameter[] parameters = {
					new SqlParameter("@MsgID", SqlDbType.VarChar,50)			};
            parameters[0].Value = MsgID;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(YIEternalMIS.Model.YIESystemMSG model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into YIESystemMSG(");
            strSql.Append("MsgID,MsgTitle,MsgUp,MsgText,Loginid,LoginName,MsgRelease,MsgSdate,MsgEdate,MsgExpiry,MsgType)");
            strSql.Append(" values (");
            strSql.Append("@MsgID,@MsgTitle,@MsgUp,@MsgText,@Loginid,@LoginName,@MsgRelease,@MsgSdate,@MsgEdate,@MsgExpiry,@MsgType)");
            SqlParameter[] parameters = {
					new SqlParameter("@MsgID", SqlDbType.VarChar,50),
					new SqlParameter("@MsgTitle", SqlDbType.VarBinary,200),
					new SqlParameter("@MsgUp", SqlDbType.VarChar,10),
					new SqlParameter("@MsgText", SqlDbType.Text),
					new SqlParameter("@Loginid", SqlDbType.VarChar,50),
					new SqlParameter("@LoginName", SqlDbType.VarChar,50),
					new SqlParameter("@MsgRelease", SqlDbType.DateTime),
					new SqlParameter("@MsgSdate", SqlDbType.DateTime),
					new SqlParameter("@MsgEdate", SqlDbType.DateTime),
					new SqlParameter("@MsgExpiry", SqlDbType.Int,4),
					new SqlParameter("@MsgType", SqlDbType.VarChar,10)};
            parameters[0].Value = model.MsgID;
            parameters[1].Value = model.MsgTitle;
            parameters[2].Value = model.MsgUp;
            parameters[3].Value = model.MsgText;
            parameters[4].Value = model.Loginid;
            parameters[5].Value = model.LoginName;
            parameters[6].Value = model.MsgRelease;
            parameters[7].Value = model.MsgSdate;
            parameters[8].Value = model.MsgEdate;
            parameters[9].Value = model.MsgExpiry;
            parameters[10].Value = model.MsgType;

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
        public bool Update(YIEternalMIS.Model.YIESystemMSG model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update YIESystemMSG set ");
            strSql.Append("MsgTitle=@MsgTitle,");
            strSql.Append("MsgUp=@MsgUp,");
            strSql.Append("MsgText=@MsgText,");
            strSql.Append("Loginid=@Loginid,");
            strSql.Append("LoginName=@LoginName,");
            strSql.Append("MsgRelease=@MsgRelease,");
            strSql.Append("MsgSdate=@MsgSdate,");
            strSql.Append("MsgEdate=@MsgEdate,");
            strSql.Append("MsgExpiry=@MsgExpiry,");
            strSql.Append("MsgType=@MsgType");
            strSql.Append(" where MsgID=@MsgID ");
            SqlParameter[] parameters = {
					new SqlParameter("@MsgTitle", SqlDbType.VarBinary,200),
					new SqlParameter("@MsgUp", SqlDbType.VarChar,10),
					new SqlParameter("@MsgText", SqlDbType.Text),
					new SqlParameter("@Loginid", SqlDbType.VarChar,50),
					new SqlParameter("@LoginName", SqlDbType.VarChar,50),
					new SqlParameter("@MsgRelease", SqlDbType.DateTime),
					new SqlParameter("@MsgSdate", SqlDbType.DateTime),
					new SqlParameter("@MsgEdate", SqlDbType.DateTime),
					new SqlParameter("@MsgExpiry", SqlDbType.Int,4),
					new SqlParameter("@MsgType", SqlDbType.VarChar,10),
					new SqlParameter("@MsgID", SqlDbType.VarChar,50)};
            parameters[0].Value = model.MsgTitle;
            parameters[1].Value = model.MsgUp;
            parameters[2].Value = model.MsgText;
            parameters[3].Value = model.Loginid;
            parameters[4].Value = model.LoginName;
            parameters[5].Value = model.MsgRelease;
            parameters[6].Value = model.MsgSdate;
            parameters[7].Value = model.MsgEdate;
            parameters[8].Value = model.MsgExpiry;
            parameters[9].Value = model.MsgType;
            parameters[10].Value = model.MsgID;

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
        public bool Delete(string MsgID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from YIESystemMSG ");
            strSql.Append(" where MsgID=@MsgID ");
            SqlParameter[] parameters = {
					new SqlParameter("@MsgID", SqlDbType.VarChar,50)			};
            parameters[0].Value = MsgID;

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
        public bool DeleteList(string MsgIDlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from YIESystemMSG ");
            strSql.Append(" where MsgID in (" + MsgIDlist + ")  ");
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
        public YIEternalMIS.Model.YIESystemMSG GetModel(string MsgID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 MsgID,MsgTitle,MsgUp,MsgText,Loginid,LoginName,MsgRelease,MsgSdate,MsgEdate,MsgExpiry,MsgType from YIESystemMSG ");
            strSql.Append(" where MsgID=@MsgID ");
            SqlParameter[] parameters = {
					new SqlParameter("@MsgID", SqlDbType.VarChar,50)			};
            parameters[0].Value = MsgID;

            YIEternalMIS.Model.YIESystemMSG model = new YIEternalMIS.Model.YIESystemMSG();
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
        public YIEternalMIS.Model.YIESystemMSG DataRowToModel(DataRow row)
        {
            YIEternalMIS.Model.YIESystemMSG model = new YIEternalMIS.Model.YIESystemMSG();
            if (row != null)
            {
                if (row["MsgID"] != null)
                {
                    model.MsgID = row["MsgID"].ToString();
                }
                if (row["MsgTitle"] != null && row["MsgTitle"].ToString() != "")
                {
                    model.MsgTitle = row["MsgTitle"].ToString();
                }
                if (row["MsgUp"] != null)
                {
                    model.MsgUp = row["MsgUp"].ToString();
                }
                if (row["MsgText"] != null)
                {
                    model.MsgText = row["MsgText"].ToString();
                }
                if (row["Loginid"] != null)
                {
                    model.Loginid = row["Loginid"].ToString();
                }
                if (row["LoginName"] != null)
                {
                    model.LoginName = row["LoginName"].ToString();
                }
                if (row["MsgRelease"] != null && row["MsgRelease"].ToString() != "")
                {
                    model.MsgRelease = DateTime.Parse(row["MsgRelease"].ToString());
                }
                if (row["MsgSdate"] != null && row["MsgSdate"].ToString() != "")
                {
                    model.MsgSdate = DateTime.Parse(row["MsgSdate"].ToString());
                }
                if (row["MsgEdate"] != null && row["MsgEdate"].ToString() != "")
                {
                    model.MsgEdate = DateTime.Parse(row["MsgEdate"].ToString());
                }
                if (row["MsgExpiry"] != null && row["MsgExpiry"].ToString() != "")
                {
                    model.MsgExpiry = int.Parse(row["MsgExpiry"].ToString());
                }
                if (row["MsgType"] != null)
                {
                    model.MsgType = row["MsgType"].ToString();
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
            strSql.Append("select MsgID,MsgTitle,MsgUp,MsgText,Loginid,LoginName,MsgRelease,MsgSdate,MsgEdate,MsgExpiry,MsgType ");
            strSql.Append(" FROM YIESystemMSG ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperSQL.Query(strSql.ToString());
        }


        /// <summary>
        /// 获取MSGType  公告分类聚合表
        /// </summary>
        public DataSet GetGroupList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select MsgType ");
            strSql.Append(" FROM YIESystemMSG ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }

            strSql.Append( "  Group By  MsgType " );
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
            strSql.Append(" MsgID,MsgTitle,MsgUp,MsgText,Loginid,LoginName,MsgRelease,MsgSdate,MsgEdate,MsgExpiry,MsgType ");
            strSql.Append(" FROM YIESystemMSG ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" order by " + filedOrder);
            return DbHelperSQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 获取记录总数
        /// </summary>
        public int GetRecordCount(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) FROM YIESystemMSG ");
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
                strSql.Append("order by T.MsgID desc");
            }
            strSql.Append(")AS Row, T.*  from YIESystemMSG T ");
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
            parameters[0].Value = "YIESystemMSG";
            parameters[1].Value = "MsgID";
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


