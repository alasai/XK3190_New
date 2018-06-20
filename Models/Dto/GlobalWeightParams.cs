using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Dto
{
    public class GlobalWeightParams
    {
        public static decimal HooksWeight { get; set; }
        public static int HookCount { get; set; }

        public string WeightPort { get; set; }
        public string WeightHookPort { get; set; }
        public string HeadHookPort { get; set; }
    }
}
