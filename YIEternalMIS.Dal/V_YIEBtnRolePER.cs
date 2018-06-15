/*************************************************************************************
    * 类 名 称：       V_YIEBtnRolePER
    * 命名空间：       YIEternalMIS.Dal
    * 文 件 名：       V_YIEBtnRolePER
    * 创建时间：       2017/6/8 10:17:46
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
    /// 数据访问类:V_YIEBtnRolePER
    /// </summary>
    public partial class V_YIEBtnRolePER
    {
        public V_YIEBtnRolePER()
        { }
        #region  BasicMethod

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public YIEternalMIS.Model.V_YIEBtnRolePER GetModel(string RoleID, string MenuNewID, string BtnName)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 RoleID,BtnPermission,MenuNewID,BtnName,BtnText,BtnImg,BtnAuthority,BtnIsToolBar,BtnTips,BtnGroupID,BtnVisible,BtnWlog,BtnSort,BtnToolBarSort from V_YIEBtnRolePER ");
            strSql.Append(" where RoleID=@RoleID and MenuNewID=@MenuNewID and BtnName=@BtnName ");
            SqlParameter[] parameters = {
					new SqlParameter("@RoleID", SqlDbType.VarChar,100),
					new SqlParameter("@MenuNewID", SqlDbType.VarChar,100),
					new SqlParameter("@BtnName", SqlDbType.VarChar,50)			};
            parameters[0].Value = RoleID;
            parameters[1].Value = MenuNewID;
            parameters[2].Value = BtnName;

            YIEternalMIS.Model.V_YIEBtnRolePER model = new YIEternalMIS.Model.V_YIEBtnRolePER();
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
        public YIEternalMIS.Model.V_YIEBtnRolePER DataRowToModel(DataRow row)
        {
            YIEternalMIS.Model.V_YIEBtnRolePER model = new YIEternalMIS.Model.V_YIEBtnRolePER();
            if (row != null)
            {
                if (row["RoleID"] != null)
                {
                    model.RoleID = row["RoleID"].ToString();
                }
                if (row["BtnPermission"] != null)
                {
                    model.BtnPermission = row["BtnPermission"].ToString();
                }
                if (row["MenuNewID"] != null)
                {
                    model.MenuNewID = row["MenuNewID"].ToString();
                }
                if (row["BtnName"] != null)
                {
                    model.BtnName = row["BtnName"].ToString();
                }
                if (row["BtnText"] != null)
                {
                    model.BtnText = row["BtnText"].ToString();
                }
                if (row["BtnImg"] != null)
                {
                    model.BtnImg = row["BtnImg"].ToString();
                }
                if (row["BtnAuthority"] != null)
                {
                    model.BtnAuthority = row["BtnAuthority"].ToString();
                }
                if (row["BtnIsToolBar"] != null)
                {
                    model.BtnIsToolBar = row["BtnIsToolBar"].ToString();
                }
                if (row["BtnTips"] != null)
                {
                    model.BtnTips = row["BtnTips"].ToString();
                }
                if (row["BtnGroupID"] != null)
                {
                    model.BtnGroupID = row["BtnGroupID"].ToString();
                }
                if (row["BtnVisible"] != null)
                {
                    model.BtnVisible = row["BtnVisible"].ToString();
                }
                if (row["BtnWlog"] != null)
                {
                    model.BtnWlog = row["BtnWlog"].ToString();
                }
                if (row["BtnSort"] != null && row["BtnSort"].ToString() != "")
                {
                    model.BtnSort = int.Parse(row["BtnSort"].ToString());
                }
                if (row["BtnToolBarSort"] != null && row["BtnToolBarSort"].ToString() != "")
                {
                    model.BtnToolBarSort = int.Parse(row["BtnToolBarSort"].ToString());
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
            strSql.Append("select RoleID,BtnPermission,MenuNewID,BtnName,BtnText,BtnImg,BtnAuthority,BtnIsToolBar,BtnTips,BtnGroupID,BtnVisible,BtnWlog,BtnSort,BtnToolBarSort ");
            strSql.Append(" FROM V_YIEBtnRolePER ");
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
            strSql.Append(" RoleID,BtnPermission,MenuNewID,BtnName,BtnText,BtnImg,BtnAuthority,BtnIsToolBar,BtnTips,BtnGroupID,BtnVisible,BtnWlog,BtnSort,BtnToolBarSort ");
            strSql.Append(" FROM V_YIEBtnRolePER ");
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
            strSql.Append("select count(1) FROM V_YIEBtnRolePER ");
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
                strSql.Append("order by T.BtnName desc");
            }
            strSql.Append(")AS Row, T.*  from V_YIEBtnRolePER T ");
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
            parameters[0].Value = "V_YIEBtnRolePER";
            parameters[1].Value = "BtnName";
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


