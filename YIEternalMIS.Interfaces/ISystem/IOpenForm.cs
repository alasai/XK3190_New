/*************************************************************************************
     * 类 名 称：       IOpenForm
     * 命名空间：       YIEternalMIS.Interfaces
     * 文 件 名：       IOpenForm
     * 创建时间：       2017/6/20 11:12:11
     * 作    者：        王宏巍
     * 说   明：
     * 修改时间：
     * 修 改 人：
 *************************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YIEternalMIS.Interfaces
{
    public interface IOpenForm
    {
        /// <summary>
        /// 窗口打开方法
        /// </summary>
        /// <param name="FormModule"></param>
        void OpenForm(IOpenModuleForm FormModule);

        void OpenForm(string sMenuNewID);


        /// <summary>
        /// Nav样式的主窗口展开Group切换主界面流程图
        /// </summary>
        /// <param name="sMenuNewID"></param>
        void NavGroupExpanded(string sMenuNewID);

        void NavGroupExpanded(IOpenModuleForm GroupModule);
    }
}
