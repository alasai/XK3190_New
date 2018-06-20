using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SqlSugar;

namespace Models
{
    [SugarTable("WeightGrid")]
     public class WeightGridDto
    {
        [SugarColumn(IsPrimaryKey = true)]
        public string Id { get; set; }
        public string BatchId { get; set; }
        public int SerialNum { get; set; }
        public string Name { get; set; }
        public string IdNumber { get; set; }
        public decimal Price { get; set; }
        public int Num { get; set; }
        public string ProductName { get; set; }
        public decimal MaoWeight { get; set; }
        public decimal PiWeight { get; set; }
        public decimal NetWeight { get; set; }
        public decimal TotalPrice { get; set; }
        public DateTime WeightTime { get; set; }
        /// <summary>
        /// 是否已经提交到服务器
        /// </summary>
        public int Uploadflag { get; set; }
    }
}
