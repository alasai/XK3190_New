/*************************************************************************************
    * 类 名 称：       YIESystemMSG
    * 命名空间：       YIEternalMIS.BLL
    * 文 件 名：       YIESystemMSG
    * 创建时间：       2017/6/23 10:53:58
    * 作    者：        王宏巍
    * 说   明：        系统通知、消息BLL类
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
    /// YIESystemMSG
    /// </summary>
    public partial class YIESystemMSG:YIEternalMIS.Interfaces.IDataGridControlPage
    {
        private readonly YIEternalMIS.DAL.YIESystemMSG dal = new YIEternalMIS.DAL.YIESystemMSG();
        public YIESystemMSG()
        { }
        #region  BasicMethod
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string MsgID)
        {

            return dal.Exists(MsgID);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(YIEternalMIS.Model.YIESystemMSG model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(YIEternalMIS.Model.YIESystemMSG model)
        {
            return dal.Update(model);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(string MsgID)
        {

            return dal.Delete(MsgID);
        }
        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool DeleteList(string MsgIDlist)
        {
            return dal.DeleteList(MsgIDlist);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public YIEternalMIS.Model.YIESystemMSG GetModel(string MsgID)
        {

            return dal.GetModel(MsgID);
        }

        /// <summary>
        /// 得到一个对象实体，从缓存中
        /// </summary>
        public YIEternalMIS.Model.YIESystemMSG GetModelByCache(string MsgID)
        {

            string CacheKey = "YIESystemMSGModel-" + MsgID;
            object objModel = YIEternalMIS.Common.DataCache.GetCache(CacheKey);
            if (objModel == null)
            {
                try
                {
                    objModel = dal.GetModel(MsgID);
                    if (objModel != null)
                    {
                        int ModelCache = YIEternalMIS.Common.ConfigHelper.GetConfigInt("ModelCache");
                        YIEternalMIS.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
                    }
                }
                catch { }
            }
            return (YIEternalMIS.Model.YIESystemMSG)objModel;
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            return dal.GetList(strWhere);
        }


        /// <summary>
        /// 获取MSGType  公告分类聚合表
        /// </summary>
        public DataSet GetGroupList(string strWhere)
        {
            return dal.GetGroupList(strWhere);
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
        public List<YIEternalMIS.Model.YIESystemMSG> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<YIEternalMIS.Model.YIESystemMSG> DataTableToList(DataTable dt)
        {
            List<YIEternalMIS.Model.YIESystemMSG> modelList = new List<YIEternalMIS.Model.YIESystemMSG>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                YIEternalMIS.Model.YIESystemMSG model;
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


