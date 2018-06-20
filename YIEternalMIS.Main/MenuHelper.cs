using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YIEternalMIS.Core;
using YIEternalMIS.Core.SystemCore;

namespace YIEternalMIS.Main
{
public class MenuHelper
    {

        public static void InitMenu()
        {
            var list = new List<MenuListDto>();

            list.Add(new MenuListDto() { MenuId = "1",MenuPid = "0", MenuSort = 1, MenuText = "基础数据", Icon = "Format" });
            list.Add(new MenuListDto() { MenuId = "2", MenuPid = "1", MenuSort = 1, MenuText = "", Icon = "Format" });
            //list.Add(new MenuListDto() { MenuId = "3", OpenType = "1", MenuPid = "2", MenuSort = 1, MenuText = "字典管理", Icon = "Format", OpenAssembly = "YIEternalMIS.SystemModule", OpenFormClassName = "YIEMsgForm" });
            list.Add(new MenuListDto() { MenuId = "3",MenuPid = "2", MenuSort = 1, MenuText = "系统参数", Icon = "Format", OpenAssembly = "WeightManage.Module", OpenFormClassName = "Views.FactoryForm" });
            list.Add(new MenuListDto() { MenuId = "8",  MenuPid = "2", MenuSort = 2, MenuText = "产品管理", Icon = "Product", OpenAssembly = "WeightManage.Module", OpenFormClassName = "Views.ProductForm" });
            list.Add(new MenuListDto() { MenuId = "9", MenuPid = "2", MenuSort = 3, MenuText = "货物价格", Icon = "Price", OpenAssembly = "WeightManage.Module", OpenFormClassName = "Views.PriceForm" });


            list.Add(new MenuListDto() { MenuId = "4",MenuPid = "0", MenuSort = 2, MenuText = "称重管理", Icon = "WeightedPies" });
            list.Add(new MenuListDto() { MenuId = "5", MenuPid = "4", MenuSort = 1, MenuText = "", Icon = "Format" });
            list.Add(new MenuListDto() { MenuId = "6",MenuPid = "5", MenuSort = 1, MenuText = "电子称", Icon = "WeightedPies", OpenAssembly = "WeightManage.Module", OpenFormClassName = "WeightForm" });
            list.Add(new MenuListDto() { MenuId = "7",MenuPid = "5", MenuSort = 2, MenuText = "本地报表打印", Icon = "SelectData", OpenAssembly = "WeightManage.Module", OpenFormClassName = "WeightReportForm" });
            list.Add(new MenuListDto() { MenuId = "10", MenuPid = "5", MenuSort = 3, MenuText = "报表打印", Icon = "SelectData", OpenAssembly = "WeightManage.Module", OpenFormClassName = "Views.ReportForm" });
            SystemAuthentication.SystemMenuList = list;
        }
    }
}
