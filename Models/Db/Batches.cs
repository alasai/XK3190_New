using System;
using System.Collections.Generic;
using System.Text;
using SqlSugar;

namespace Models.Db
{
    /// <summary>
    /// 送宰基本信息
    /// </summary>
    public class Batches
    {
        /// <summary>
        /// 批次号
        /// </summary>
        [SugarColumn(IsPrimaryKey = true)]
        public string batchId { get; set; }
        /// <summary>
        ///年月日 
        /// </summary>
        public int yearNum { get; set; }
        /// <summary>
        /// 第几个
        /// </summary>
        public int sort { get; set; }
        /// <summary>
        /// 送宰人
        /// </summary>
        public string hostName { get; set; }
        /// <summary>
        /// 身份证
        /// </summary>
        public string PIN { get; set; }
        /// <summary>
        /// 联系电话
        /// </summary>
        public string tel { get; set; }
        /// <summary>
        /// 称重完成
        /// </summary>
        public bool flag { get; set; }
        /// <summary>
        /// 上传标识
        /// </summary>
        public bool upload { get; set; }
        /// <summary>
        /// 货物id
        /// </summary>
        public int animalTypeId { get; set; }
        /// <summary>
        /// 货物名称
        /// </summary>
        public string animalTypeName { get; set; }
        /// <summary>
        /// 开始时间
        /// </summary>
        public DateTime weighingBeginTime { get; set; }

        /// <summary>
        /// 结束时间
        /// </summary>
        public DateTime weighingFinishedTime { get; set; }
        /// <summary>
        /// 是否溯源
        /// </summary>
        public bool istrace { get; set; }
        /// <summary>
        /// 原产地
        /// </summary>
        public string originalPlace { get; set; }
    }
}
