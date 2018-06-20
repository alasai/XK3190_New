using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YIEternalMIS.Core.SystemCore
{
public class MenuListDto
    {
        public string MenuId { get; set; }
        public string MenuName { get; set; }
        public string MenuPid { get; set; }
        public string MenuText { get; set; }
        public string Icon { get; set; }
        public int MenuSort { get; set; }
        public string OpenAssembly { get; set; }
        public string OpenFormClassName { get; set; }

        /// <summary>
        /// 1-MdiOpen,2-DiaLogOpen,3-DefaultOpen
        /// </summary>
        public string OpenType { get; set; } ="1";
    }
}
