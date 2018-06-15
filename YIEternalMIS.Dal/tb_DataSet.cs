/*************************************************************************************
    * 类 名 称：       tb_DataSet
    * 命名空间：       YIEternalMIS.Dal
    * 文 件 名：       tb_DataSet
    * 创建时间：       2017/6/5 14:36:04
    * 作    者：        王宏巍
    * 说   明：
    * 修改时间：
    * 修 改 人：
*************************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using YIEternalMIS.DBUtility;//Please add references



namespace YIEternalMIS.DAL
{
    /// <summary>
    /// 数据访问类:tb_DataSet
    /// </summary>
    public partial class tb_DataSet
    {
        public tb_DataSet()
        { }
        #region  BasicMethod
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int isid)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from tb_DataSet");
            strSql.Append(" where isid=@isid");
            SqlParameter[] parameters = {
					new SqlParameter("@isid", SqlDbType.Int,4)
			};
            parameters[0].Value = isid;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(YIEternalMIS.Model.tb_DataSet model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into tb_DataSet(");
            strSql.Append("DataSetID,DataSetName,ServerIP,DBName,DBUserName,DBUserPassword,Remark)");
            strSql.Append(" values (");
            strSql.Append("@DataSetID,@DataSetName,@ServerIP,@DBName,@DBUserName,@DBUserPassword,@Remark)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@DataSetID", SqlDbType.VarChar,20),
					new SqlParameter("@DataSetName", SqlDbType.NVarChar,20),
					new SqlParameter("@ServerIP", SqlDbType.VarChar,50),
					new SqlParameter("@DBName", SqlDbType.VarChar,250),
					new SqlParameter("@DBUserName", SqlDbType.VarChar,50),
					new SqlParameter("@DBUserPassword", SqlDbType.VarChar,50),
					new SqlParameter("@Remark", SqlDbType.NVarChar,250)};
            parameters[0].Value = model.DataSetID;
            parameters[1].Value = model.DataSetName;
            parameters[2].Value = model.ServerIP;
            parameters[3].Value = model.DBName;
            parameters[4].Value = model.DBUserName;
            parameters[5].Value = model.DBUserPassword;
            parameters[6].Value = model.Remark;

            object obj = DbHelperSQL.GetSingle(strSql.ToString(), parameters);
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
        public bool Update(YIEternalMIS.Model.tb_DataSet model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update tb_DataSet set ");
            strSql.Append("DataSetID=@DataSetID,");
            strSql.Append("DataSetName=@DataSetName,");
            strSql.Append("ServerIP=@ServerIP,");
            strSql.Append("DBName=@DBName,");
            strSql.Append("DBUserName=@DBUserName,");
            strSql.Append("DBUserPassword=@DBUserPassword,");
            strSql.Append("Remark=@Remark");
            strSql.Append(" where isid=@isid");
            SqlParameter[] parameters = {
					new SqlParameter("@DataSetID", SqlDbType.VarChar,20),
					new SqlParameter("@DataSetName", SqlDbType.NVarChar,20),
					new SqlParameter("@ServerIP", SqlDbType.VarChar,50),
					new SqlParameter("@DBName", SqlDbType.VarChar,250),
					new SqlParameter("@DBUserName", SqlDbType.VarChar,50),
					new SqlParameter("@DBUserPassword", SqlDbType.VarChar,50),
					new SqlParameter("@Remark", SqlDbType.NVarChar,250),
					new SqlParameter("@isid", SqlDbType.Int,4)};
            parameters[0].Value = model.DataSetID;
            parameters[1].Value = model.DataSetName;
            parameters[2].Value = model.ServerIP;
            parameters[3].Value = model.DBName;
            parameters[4].Value = model.DBUserName;
            parameters[5].Value = model.DBUserPassword;
            parameters[6].Value = model.Remark;
            parameters[7].Value = model.isid;

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
        public bool Delete(int isid)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from tb_DataSet ");
            strSql.Append(" where isid=@isid");
            SqlParameter[] parameters = {
					new SqlParameter("@isid", SqlDbType.Int,4)
			};
            parameters[0].Value = isid;

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
        public bool DeleteList(string isidlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from tb_DataSet ");
            strSql.Append(" where isid in (" + isidlist + ")  ");
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
        public YIEternalMIS.Model.tb_DataSet GetModel(int isid)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 isid,DataSetID,DataSetName,ServerIP,DBName,DBUserName,DBUserPassword,Remark from tb_DataSet ");
            strSql.Append(" where isid=@isid");
            SqlParameter[] parameters = {
					new SqlParameter("@isid", SqlDbType.Int,4)
			};
            parameters[0].Value = isid;

            YIEternalMIS.Model.tb_DataSet model = new YIEternalMIS.Model.tb_DataSet();
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
        public YIEternalMIS.Model.tb_DataSet DataRowToModel(DataRow row)
        {
            YIEternalMIS.Model.tb_DataSet model = new YIEternalMIS.Model.tb_DataSet();
            if (row != null)
            {
                if (row["isid"] != null && row["isid"].ToString() != "")
                {
                    model.isid = int.Parse(row["isid"].ToString());
                }
                if (row["DataSetID"] != null)
                {
                    model.DataSetID = row["DataSetID"].ToString();
                }
                if (row["DataSetName"] != null)
                {
                    model.DataSetName = row["DataSetName"].ToString();
                }
                if (row["ServerIP"] != null)
                {
                    model.ServerIP = row["ServerIP"].ToString();
                }
                if (row["DBName"] != null)
                {
                    model.DBName = row["DBName"].ToString();
                }
                if (row["DBUserName"] != null)
                {
                    model.DBUserName = row["DBUserName"].ToString();
                }
                if (row["DBUserPassword"] != null)
                {
                    model.DBUserPassword = row["DBUserPassword"].ToString();
                }
                if (row["Remark"] != null)
                {
                    model.Remark = row["Remark"].ToString();
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
            strSql.Append("select isid,DataSetID,DataSetName,ServerIP,DBName,DBUserName,DBUserPassword,Remark ");
            strSql.Append(" FROM tb_DataSet ");
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
            strSql.Append(" isid,DataSetID,DataSetName,ServerIP,DBName,DBUserName,DBUserPassword,Remark ");
            strSql.Append(" FROM tb_DataSet ");
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
            strSql.Append("select count(1) FROM tb_DataSet ");
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
                strSql.Append("order by T.isid desc");
            }
            strSql.Append(")AS Row, T.*  from tb_DataSet T ");
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
            parameters[0].Value = "tb_DataSet";
            parameters[1].Value = "isid";
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


