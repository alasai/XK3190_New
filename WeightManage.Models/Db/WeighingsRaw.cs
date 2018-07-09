using System;
using System.Collections.Generic;
using System.Text;

namespace WeightManage.Models.Db
{
    public class WeighingsRaw
    {
        public string batchId { get; set; }
        public string hookIds { get; set; }
        public int hooksCount { get; set; }
        public decimal grossWeights { get; set; }
        public decimal hookWeights { get; set; }
        public DateTime weighingTime { get; set; }
        public string productName { get; set; }
        public decimal ProductPrice { get; set; }
    }
}
