/*************************************************************************************
    * 类 名 称：       YIEMYUser
    * 命名空间：       YIEternalMIS.Dal
    * 文 件 名：       YIEMYUser
    * 创建时间：       2017/6/7 9:29:29
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
    /// 数据访问类:YIEMYUser
    /// </summary>
    public partial class YIEMYUser
    {
        public YIEMYUser()
        { }
        #region  BasicMethod

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string Loginid)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from YIEMYUser");
            strSql.Append(" where Loginid=@Loginid ");
            SqlParameter[] parameters = {
					new SqlParameter("@Loginid", SqlDbType.VarChar,50)			};
            parameters[0].Value = Loginid;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(YIEternalMIS.Model.YIEMYUser model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into YIEMYUser(");
            strSql.Append("Loginid,LoginName,PassWord,RoleID,DeptID,DeptName,LoginState,Xb,Zw,Csrq,Jtdz,YdTel,GDTel,Xl,Userstate,Bz,Zfbz,Lrsj,LrrUserid,LoginInDate,LoginOutDate)");
            strSql.Append(" values (");
            strSql.Append("@Loginid,@LoginName,@PassWord,@RoleID,@DeptID,@DeptName,@LoginState,@Xb,@Zw,@Csrq,@Jtdz,@YdTel,@GDTel,@Xl,@Userstate,@Bz,@Zfbz,@Lrsj,@LrrUserid,@LoginInDate,@LoginOutDate)");
            SqlParameter[] parameters = {
					new SqlParameter("@Loginid", SqlDbType.VarChar,50),
					new SqlParameter("@LoginName", SqlDbType.VarChar,50),
					new SqlParameter("@PassWord", SqlDbType.VarChar,50),
					new SqlParameter("@RoleID", SqlDbType.VarChar,100),
					new SqlParameter("@DeptID", SqlDbType.VarChar,100),
					new SqlParameter("@DeptName", SqlDbType.VarChar,100),
					new SqlParameter("@LoginState", SqlDbType.VarChar,10),
					new SqlParameter("@Xb", SqlDbType.VarChar,10),
					new SqlParameter("@Zw", SqlDbType.VarChar,10),
					new SqlParameter("@Csrq", SqlDbType.DateTime),
					new SqlParameter("@Jtdz", SqlDbType.VarChar,400),
					new SqlParameter("@YdTel", SqlDbType.VarChar,20),
					new SqlParameter("@GDTel", SqlDbType.VarChar,20),
					new SqlParameter("@Xl", SqlDbType.VarChar,20),
					new SqlParameter("@Userstate", SqlDbType.VarChar,20),
					new SqlParameter("@Bz", SqlDbType.VarChar,200),
					new SqlParameter("@Zfbz", SqlDbType.VarChar,10),
					new SqlParameter("@Lrsj", SqlDbType.DateTime),
					new SqlParameter("@LrrUserid", SqlDbType.VarChar,50),
					new SqlParameter("@LoginInDate", SqlDbType.DateTime),
					new SqlParameter("@LoginOutDate", SqlDbType.DateTime)};
            parameters[0].Value = model.Loginid;
            parameters[1].Value = model.LoginName;
            parameters[2].Value = model.PassWord;
            parameters[3].Value = model.RoleID;
            parameters[4].Value = model.DeptID;
            parameters[5].Value = model.DeptName;
            parameters[6].Value = model.LoginState;
            parameters[7].Value = model.Xb;
            parameters[8].Value = model.Zw;
            parameters[9].Value = model.Csrq;
            parameters[10].Value = model.Jtdz;
            parameters[11].Value = model.YdTel;
            parameters[12].Value = model.GDTel;
            parameters[13].Value = model.Xl;
            parameters[14].Value = model.Userstate;
            parameters[15].Value = model.Bz;
            parameters[16].Value = model.Zfbz;
            parameters[17].Value = model.Lrsj;
            parameters[18].Value = model.LrrUserid;
            parameters[19].Value = model.LoginInDate;
            parameters[20].Value = model.LoginOutDate;

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
        public bool Update(YIEternalMIS.Model.YIEMYUser model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update YIEMYUser set ");
            strSql.Append("LoginName=@LoginName,");
            strSql.Append("PassWord=@PassWord,");
            strSql.Append("RoleID=@RoleID,");
            strSql.Append("DeptID=@DeptID,");
            strSql.Append("DeptName=@DeptName,");
            strSql.Append("LoginState=@LoginState,");
            strSql.Append("Xb=@Xb,");
            strSql.Append("Zw=@Zw,");
            strSql.Append("Csrq=@Csrq,");
            strSql.Append("Jtdz=@Jtdz,");
            strSql.Append("YdTel=@YdTel,");
            strSql.Append("GDTel=@GDTel,");
            strSql.Append("Xl=@Xl,");
            strSql.Append("Userstate=@Userstate,");
            strSql.Append("Bz=@Bz,");
            strSql.Append("Zfbz=@Zfbz,");
            strSql.Append("Lrsj=@Lrsj,");
            strSql.Append("LrrUserid=@LrrUserid,");
            strSql.Append("LoginInDate=@LoginInDate,");
            strSql.Append("LoginOutDate=@LoginOutDate");
            strSql.Append(" where Loginid=@Loginid ");
            SqlParameter[] parameters = {
					new SqlParameter("@LoginName", SqlDbType.VarChar,50),
					new SqlParameter("@PassWord", SqlDbType.VarChar,50),
					new SqlParameter("@RoleID", SqlDbType.VarChar,100),
					new SqlParameter("@DeptID", SqlDbType.VarChar,100),
					new SqlParameter("@DeptName", SqlDbType.VarChar,100),
					new SqlParameter("@LoginState", SqlDbType.VarChar,10),
					new SqlParameter("@Xb", SqlDbType.VarChar,10),
					new SqlParameter("@Zw", SqlDbType.VarChar,10),
					new SqlParameter("@Csrq", SqlDbType.DateTime),
					new SqlParameter("@Jtdz", SqlDbType.VarChar,400),
					new SqlParameter("@YdTel", SqlDbType.VarChar,20),
					new SqlParameter("@GDTel", SqlDbType.VarChar,20),
					new SqlParameter("@Xl", SqlDbType.VarChar,20),
					new SqlParameter("@Userstate", SqlDbType.VarChar,20),
					new SqlParameter("@Bz", SqlDbType.VarChar,200),
					new SqlParameter("@Zfbz", SqlDbType.VarChar,10),
					new SqlParameter("@Lrsj", SqlDbType.DateTime),
					new SqlParameter("@LrrUserid", SqlDbType.VarChar,50),
					new SqlParameter("@LoginInDate", SqlDbType.DateTime),
					new SqlParameter("@LoginOutDate", SqlDbType.DateTime),
					new SqlParameter("@Loginid", SqlDbType.VarChar,50)};
            parameters[0].Value = model.LoginName;
            parameters[1].Value = model.PassWord;
            parameters[2].Value = model.RoleID;
            parameters[3].Value = model.DeptID;
            parameters[4].Value = model.DeptName;
            parameters[5].Value = model.LoginState;
            parameters[6].Value = model.Xb;
            parameters[7].Value = model.Zw;
            parameters[8].Value = model.Csrq;
            parameters[9].Value = model.Jtdz;
            parameters[10].Value = model.YdTel;
            parameters[11].Value = model.GDTel;
            parameters[12].Value = model.Xl;
            parameters[13].Value = model.Userstate;
            parameters[14].Value = model.Bz;
            parameters[15].Value = model.Zfbz;
            parameters[16].Value = model.Lrsj;
            parameters[17].Value = model.LrrUserid;
            parameters[18].Value = model.LoginInDate;
            parameters[19].Value = model.LoginOutDate;
            parameters[20].Value = model.Loginid;

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
        public bool Delete(string Loginid)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from YIEMYUser ");
            strSql.Append(" where Loginid=@Loginid ");
            SqlParameter[] parameters = {
					new SqlParameter("@Loginid", SqlDbType.VarChar,50)			};
            parameters[0].Value = Loginid;

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
        public bool DeleteList(string Loginidlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from YIEMYUser ");
            strSql.Append(" where Loginid in (" + Loginidlist + ")  ");
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
        public YIEternalMIS.Model.YIEMYUser GetModel(string Loginid)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 Loginid,LoginName,PassWord,RoleID,DeptID,DeptName,LoginState,Xb,Zw,Csrq,Jtdz,YdTel,GDTel,Xl,Userstate,Bz,Zfbz,Lrsj,LrrUserid,LoginInDate,LoginOutDate from YIEMYUser ");
            strSql.Append(" where Loginid=@Loginid ");
            SqlParameter[] parameters = {
					new SqlParameter("@Loginid", SqlDbType.VarChar,50)			};
            parameters[0].Value = Loginid;

            YIEternalMIS.Model.YIEMYUser model = new YIEternalMIS.Model.YIEMYUser();
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
        public YIEternalMIS.Model.YIEMYUser DataRowToModel(DataRow row)
        {
            YIEternalMIS.Model.YIEMYUser model = new YIEternalMIS.Model.YIEMYUser();
            if (row != null)
            {
                if (row["Loginid"] != null)
                {
                    model.Loginid = row["Loginid"].ToString();
                }
                if (row["LoginName"] != null)
                {
                    model.LoginName = row["LoginName"].ToString();
                }
                if (row["PassWord"] != null)
                {
                    model.PassWord = row["PassWord"].ToString();
                }
                if (row["RoleID"] != null)
                {
                    model.RoleID = row["RoleID"].ToString();
                }
                if (row["DeptID"] != null)
                {
                    model.DeptID = row["DeptID"].ToString();
                }
                if (row["DeptName"] != null)
                {
                    model.DeptName = row["DeptName"].ToString();
                }
                if (row["LoginState"] != null)
                {
                    model.LoginState = row["LoginState"].ToString();
                }
                if (row["Xb"] != null)
                {
                    model.Xb = row["Xb"].ToString();
                }
                if (row["Zw"] != null)
                {
                    model.Zw = row["Zw"].ToString();
                }
                if (row["Csrq"] != null && row["Csrq"].ToString() != "")
                {
                    model.Csrq = DateTime.Parse(row["Csrq"].ToString());
                }
                if (row["Jtdz"] != null)
                {
                    model.Jtdz = row["Jtdz"].ToString();
                }
                if (row["YdTel"] != null)
                {
                    model.YdTel = row["YdTel"].ToString();
                }
                if (row["GDTel"] != null)
                {
                    model.GDTel = row["GDTel"].ToString();
                }
                if (row["Xl"] != null)
                {
                    model.Xl = row["Xl"].ToString();
                }
                if (row["Userstate"] != null)
                {
                    model.Userstate = row["Userstate"].ToString();
                }
                if (row["Bz"] != null)
                {
                    model.Bz = row["Bz"].ToString();
                }
                if (row["Zfbz"] != null)
                {
                    model.Zfbz = row["Zfbz"].ToString();
                }
                if (row["Lrsj"] != null && row["Lrsj"].ToString() != "")
                {
                    model.Lrsj = DateTime.Parse(row["Lrsj"].ToString());
                }
                if (row["LrrUserid"] != null)
                {
                    model.LrrUserid = row["LrrUserid"].ToString();
                }
                if (row["LoginInDate"] != null && row["LoginInDate"].ToString() != "")
                {
                    model.LoginInDate = DateTime.Parse(row["LoginInDate"].ToString());
                }
                if (row["LoginOutDate"] != null && row["LoginOutDate"].ToString() != "")
                {
                    model.LoginOutDate = DateTime.Parse(row["LoginOutDate"].ToString());
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
            strSql.Append("select Loginid,LoginName,PassWord,RoleID,DeptID,DeptName,LoginState,Xb,Zw,Csrq,Jtdz,YdTel,GDTel,Xl,Userstate,Bz,Zfbz,Lrsj,LrrUserid,LoginInDate,LoginOutDate ");
            strSql.Append(" FROM YIEMYUser ");
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
            strSql.Append(" Loginid,LoginName,PassWord,RoleID,DeptID,DeptName,LoginState,Xb,Zw,Csrq,Jtdz,YdTel,GDTel,Xl,Userstate,Bz,Zfbz,Lrsj,LrrUserid,LoginInDate,LoginOutDate ");
            strSql.Append(" FROM YIEMYUser ");
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
            strSql.Append("select count(1) FROM YIEMYUser ");
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
                strSql.Append("order by T.Loginid desc");
            }
            strSql.Append(")AS Row, T.*  from YIEMYUser T ");
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
            parameters[0].Value = "YIEMYUser";
            parameters[1].Value = "Loginid";
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


