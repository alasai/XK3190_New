/*************************************************************************************
    * 类 名 称：       tb_DataSet
    * 命名空间：       YIEternalMIS.BLL
    * 文 件 名：       tb_DataSet
    * 创建时间：       2017/6/5 14:35:54
    * 作    者：        王宏巍
    * 说   明：
    * 修改时间：
    * 修 改 人：
*************************************************************************************/
using System;
using System.Data;
using System.Collections.Generic;
using YIEternalMIS.Common;
using YIEternalMIS.Model;
namespace YIEternalMIS.BLL
{
    /// <summary>
    /// tb_DataSet
    /// </summary>
    public partial class tb_DataSet
    {
        private readonly YIEternalMIS.DAL.tb_DataSet dal = new YIEternalMIS.DAL.tb_DataSet();
        public tb_DataSet()
        { }
        #region  BasicMethod
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int isid)
        {
            return dal.Exists(isid);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(YIEternalMIS.Model.tb_DataSet model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(YIEternalMIS.Model.tb_DataSet model)
        {
            return dal.Update(model);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(int isid)
        {

            return dal.Delete(isid);
        }
        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool DeleteList(string isidlist)
        {
            return dal.DeleteList(isidlist);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public YIEternalMIS.Model.tb_DataSet GetModel(int isid)
        {

            return dal.GetModel(isid);
        }

        /// <summary>
        /// 得到一个对象实体，从缓存中
        /// </summary>
        public YIEternalMIS.Model.tb_DataSet GetModelByCache(int isid)
        {

            string CacheKey = "tb_DataSetModel-" + isid;
            object objModel = YIEternalMIS.Common.DataCache.GetCache(CacheKey);
            if (objModel == null)
            {
                try
                {
                    objModel = dal.GetModel(isid);
                    if (objModel != null)
                    {
                        int ModelCache = YIEternalMIS.Common.ConfigHelper.GetConfigInt("ModelCache");
                        YIEternalMIS.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
                    }
                }
                catch { }
            }
            return (YIEternalMIS.Model.tb_DataSet)objModel;
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
        public List<YIEternalMIS.Model.tb_DataSet> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<YIEternalMIS.Model.tb_DataSet> DataTableToList(DataTable dt)
        {
            List<YIEternalMIS.Model.tb_DataSet> modelList = new List<YIEternalMIS.Model.tb_DataSet>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                YIEternalMIS.Model.tb_DataSet model;
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


