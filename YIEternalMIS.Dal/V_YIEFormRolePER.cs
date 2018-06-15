/*************************************************************************************
    * 类 名 称：       V_YIEFormRolePER
    * 命名空间：       YIEternalMIS.Dal
    * 文 件 名：       V_YIEFormRolePER
    * 创建时间：       2017/6/8 10:22:13
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
    /// 数据访问类:V_YIEFormRolePER
    /// </summary>
    public partial class V_YIEFormRolePER
    {
        public V_YIEFormRolePER()
        { }
        #region  BasicMethod

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public YIEternalMIS.Model.V_YIEFormRolePER GetModel(string RoleID, string MenuNewID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 RoleID,Permission,SysId,SysName,MenuID,ParentMenuID,MenuLevel,MenuIcon,MenuName,MenuText,TabText,MenuOrder,MenuIsButton,MenuVisible,MenuTips,OpenAssembly,OpenFormClassName,OpenType,MenuNewID,CountBZ from V_YIEFormRolePER ");
            strSql.Append(" where RoleID=@RoleID and MenuNewID=@MenuNewID ");
            SqlParameter[] parameters = {
					new SqlParameter("@RoleID", SqlDbType.VarChar,100),
					new SqlParameter("@MenuNewID", SqlDbType.VarChar,100)			};
            parameters[0].Value = RoleID;
            parameters[1].Value = MenuNewID;

            YIEternalMIS.Model.V_YIEFormRolePER model = new YIEternalMIS.Model.V_YIEFormRolePER();
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
        public YIEternalMIS.Model.V_YIEFormRolePER DataRowToModel(DataRow row)
        {
            YIEternalMIS.Model.V_YIEFormRolePER model = new YIEternalMIS.Model.V_YIEFormRolePER();
            if (row != null)
            {
                if (row["RoleID"] != null)
                {
                    model.RoleID = row["RoleID"].ToString();
                }
                if (row["Permission"] != null)
                {
                    model.Permission = row["Permission"].ToString();
                }
                if (row["SysId"] != null)
                {
                    model.SysId = row["SysId"].ToString();
                }
                if (row["SysName"] != null)
                {
                    model.SysName = row["SysName"].ToString();
                }
                if (row["MenuID"] != null)
                {
                    model.MenuID = row["MenuID"].ToString();
                }
                if (row["ParentMenuID"] != null)
                {
                    model.ParentMenuID = row["ParentMenuID"].ToString();
                }
                if (row["MenuLevel"] != null && row["MenuLevel"].ToString() != "")
                {
                    model.MenuLevel = int.Parse(row["MenuLevel"].ToString());
                }
                if (row["MenuIcon"] != null)
                {
                    model.MenuIcon = row["MenuIcon"].ToString();
                }
                if (row["MenuName"] != null)
                {
                    model.MenuName = row["MenuName"].ToString();
                }
                if (row["MenuText"] != null)
                {
                    model.MenuText = row["MenuText"].ToString();
                }
                if (row["TabText"] != null)
                {
                    model.TabText = row["TabText"].ToString();
                }
                if (row["MenuOrder"] != null && row["MenuOrder"].ToString() != "")
                {
                    model.MenuOrder = int.Parse(row["MenuOrder"].ToString());
                }
                if (row["MenuIsButton"] != null)
                {
                    model.MenuIsButton = row["MenuIsButton"].ToString();
                }
                if (row["MenuVisible"] != null && row["MenuVisible"].ToString() != "")
                {
                    model.MenuVisible = int.Parse(row["MenuVisible"].ToString());
                }
                if (row["MenuTips"] != null)
                {
                    model.MenuTips = row["MenuTips"].ToString();
                }
                if (row["OpenAssembly"] != null)
                {
                    model.OpenAssembly = row["OpenAssembly"].ToString();
                }
                if (row["OpenFormClassName"] != null)
                {
                    model.OpenFormClassName = row["OpenFormClassName"].ToString();
                }
                if (row["OpenType"] != null && row["OpenType"].ToString() != "")
                {
                    model.OpenType = int.Parse(row["OpenType"].ToString());
                }
                if (row["MenuNewID"] != null)
                {
                    model.MenuNewID = row["MenuNewID"].ToString();
                }
                if (row["CountBZ"] != null)
                {
                    model.MenuNewID = row["CountBZ"].ToString();
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
            strSql.Append("select RoleID,Permission,SysId,SysName,MenuID,ParentMenuID,MenuLevel,MenuIcon,MenuName,MenuText,TabText,MenuOrder,MenuIsButton,MenuVisible,MenuTips,OpenAssembly,OpenFormClassName,OpenType,MenuNewID ,CountBZ ");
            strSql.Append(" FROM V_YIEFormRolePER ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperSQL.Query(strSql.ToString());
        }


        /// <summary>
        /// 获取子系统编号
        /// </summary>
        /// <param name="strWhere"></param>
        /// <returns></returns>
        public DataSet GetGroupDt( string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select SysId,SysName");
            strSql.Append(" FROM V_YIEFormRolePER ");
            
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }

            strSql.Append("Group by SysID , SysName ");
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
            strSql.Append(" RoleID,Permission,SysId,SysName,MenuID,ParentMenuID,MenuLevel,MenuIcon,MenuName,MenuText,TabText,MenuOrder,MenuIsButton,MenuVisible,MenuTips,OpenAssembly,OpenFormClassName,OpenType,MenuNewID,CountBZ ");
            strSql.Append(" FROM V_YIEFormRolePER ");
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
            strSql.Append("select count(1) FROM V_YIEFormRolePER ");
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
                strSql.Append("order by T.MenuNewID desc");
            }
            strSql.Append(")AS Row, T.*  from V_YIEFormRolePER T ");
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
            parameters[0].Value = "V_YIEFormRolePER";
            parameters[1].Value = "MenuNewID";
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


