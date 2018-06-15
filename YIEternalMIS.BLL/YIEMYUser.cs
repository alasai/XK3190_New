/*************************************************************************************
    * 类 名 称：       YIEMYUser
    * 命名空间：       YIEternalMIS.BLL
    * 文 件 名：       YIEMYUser
    * 创建时间：       2017/6/7 9:30:29
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
    /// YIEMYUser
    /// </summary>
    public partial class YIEMYUser
    {
        private readonly YIEternalMIS.DAL.YIEMYUser dal = new YIEternalMIS.DAL.YIEMYUser();
        public YIEMYUser()
        { }
        #region  BasicMethod
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string Loginid)
        {
            return dal.Exists(Loginid);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(YIEternalMIS.Model.YIEMYUser model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(YIEternalMIS.Model.YIEMYUser model)
        {
            return dal.Update(model);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(string Loginid)
        {

            return dal.Delete(Loginid);
        }
        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool DeleteList(string Loginidlist)
        {
            return dal.DeleteList(Loginidlist);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public YIEternalMIS.Model.YIEMYUser GetModel(string Loginid)
        {

            return dal.GetModel(Loginid);
        }

        /// <summary>
        /// 得到一个对象实体，从缓存中
        /// </summary>
        public YIEternalMIS.Model.YIEMYUser GetModelByCache(string Loginid)
        {

            string CacheKey = "YIEMYUserModel-" + Loginid;
            object objModel = YIEternalMIS.Common.DataCache.GetCache(CacheKey);
            if (objModel == null)
            {
                try
                {
                    objModel = dal.GetModel(Loginid);
                    if (objModel != null)
                    {
                        int ModelCache = YIEternalMIS.Common.ConfigHelper.GetConfigInt("ModelCache");
                        YIEternalMIS.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
                    }
                }
                catch { }
            }
            return (YIEternalMIS.Model.YIEMYUser)objModel;
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
        public List<YIEternalMIS.Model.YIEMYUser> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<YIEternalMIS.Model.YIEMYUser> DataTableToList(DataTable dt)
        {
            List<YIEternalMIS.Model.YIEMYUser> modelList = new List<YIEternalMIS.Model.YIEMYUser>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                YIEternalMIS.Model.YIEMYUser model;
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


