/*************************************************************************************
     * 类 名 称：       IGetChildMainDataTable
     * 命名空间：       YIEternalMIS.Interfaces
     * 文 件 名：       IGetChildMainDataTable
     * 创建时间：       2017/6/23 11:04:46
     * 作    者：        王宏巍
     * 说   明：        获取系统主界面参数表
     * 修改时间：
     * 修 改 人：
 *************************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace YIEternalMIS.Interfaces
{
    public interface IGetChildMainDataTable
    {
        DataTable GetDataTable();
    }
}
