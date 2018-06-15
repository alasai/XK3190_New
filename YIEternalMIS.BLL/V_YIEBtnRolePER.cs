/*************************************************************************************
    * 类 名 称：       V_YIEBtnRolePER
    * 命名空间：       YIEternalMIS.BLL
    * 文 件 名：       V_YIEBtnRolePER
    * 创建时间：       2017/6/8 10:18:42
    * 作    者：        王宏巍
    * 说   明：
    * 修改时间：
    * 修 改 人：
*************************************************************************************/
using System;
using System.Data;
using System.Collections.Generic;
using YIEternalMIS.Model;
using YIEternalMIS.Interfaces;

namespace YIEternalMIS.BLL
{
    /// <summary>
    /// V_YIEBtnRolePER
    /// </summary>
    public partial class V_YIEBtnRolePER: ILoginAuth,IDataGridControlPage
    {
        private readonly YIEternalMIS.DAL.V_YIEBtnRolePER dal = new YIEternalMIS.DAL.V_YIEBtnRolePER();
        public V_YIEBtnRolePER()
        { }
        #region  BasicMethod
        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public YIEternalMIS.Model.V_YIEBtnRolePER GetModel(string RoleID, string MenuNewID, string BtnName)
        {

            return dal.GetModel(RoleID, MenuNewID, BtnName);
        }
        public DataSet GetGroupDt(string strWhere)
        {
            return null;
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            return dal.GetList(strWhere);
        }
        /// <summary>
        /// 获得前几行数据
        /// </summary>
        public DataSet GetList(int Top, string strWhere, string filedOrder)
        {
            return dal.GetList(Top, strWhere, filedOrder);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<YIEternalMIS.Model.V_YIEBtnRolePER> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<YIEternalMIS.Model.V_YIEBtnRolePER> DataTableToList(DataTable dt)
        {
            List<YIEternalMIS.Model.V_YIEBtnRolePER> modelList = new List<YIEternalMIS.Model.V_YIEBtnRolePER>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                YIEternalMIS.Model.V_YIEBtnRolePER model;
                for (int n = 0; n < rowsCount; n++)
                {
                    model = dal.DataRowToModel(dt.Rows[n]);
                    if (model != null)
                    {
                        modelList.Add(model);
                    }
                }
            }
            return modelList;
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetAllList()
        {
            return GetList("");
        }

        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public int GetRecordCount(string strWhere)
        {
            return dal.GetRecordCount(strWhere);
        }
        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
        {
            return dal.GetListByPage(strWhere, orderby, startIndex, endIndex);
        }
        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        //public DataSet GetList(int PageSize,int PageIndex,string strWhere)
        //{
        //return dal.GetList(PageSize,PageIndex,strWhere);
        //}

        #endregion  BasicMethod
        #region  ExtensionMethod

        #endregion  ExtensionMethod
    }
}


