using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeightManage.Models.Db;


namespace WeightManage.Models.Dto
{
    public class WeightInitDto
    {
        /// <summary>
        /// 基本信息
        /// </summary>
        public Batches BatchInfo { get; set; }

        public List<AnimalTypes> Products { get; set; }
        public decimal HooksWeight { get; set; }
        public int HookCount { get; set; }
    }
}
