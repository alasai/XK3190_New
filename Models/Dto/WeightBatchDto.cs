using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Dto
{
    public class WeightBatchDto
    {
        public string batchId { get; set; }
        public string hostName { get; set; }
        public string PIN { get; set; }
        public DateTime weighingBeginTime { get; set; }
        public int Num { get; set; }
    }
}
