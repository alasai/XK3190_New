using System;
using System.Collections.Generic;
using System.Text;
using SqlSugar;

namespace WeightManage.Models.Db
{
   public class Params
    {
        /// <summary>
        /// 工厂编号
        /// </summary>
        [SugarColumn(IsPrimaryKey = true)]
        public string factoryId { get; set; }
        /// <summary>
        /// 工厂名称
        /// </summary>
       public string factoryName { get; set; }
        /// <summary>
        /// 单只钩终
        /// </summary>
       public decimal hookWeight { get; set; }
        /// <summary>
        /// 出肉率
        /// </summary>
       public decimal meatRate { get; set; }
        /// <summary>
        /// 溯源地址
        /// </summary>
       public string traceURL { get; set; }
        /// <summary>
        /// 域名
        /// </summary>
       public string serverUrl { get; set; }
        /// <summary>
        /// 含骨率
        /// </summary>
       public decimal bonedRate { get; set; }
        /// <summary>
        /// 总钩重
        /// </summary>
       public decimal hooksWeight { get; set; }
        /// <summary>
        /// 钩数量
        /// </summary>
       public int hookCount { get; set; }
    }
}
