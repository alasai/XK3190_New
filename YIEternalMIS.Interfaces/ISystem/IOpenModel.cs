/*************************************************************************************
     * 类 名 称：       IOpenModel
     * 命名空间：       YIEternalMIS.Interfaces
     * 文 件 名：       IOpenModel
     * 创建时间：       2017/6/9 15:55:03
     * 作    者：        王宏巍
     * 说   明：
     * 修改时间：
     * 修 改 人：
 *************************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.XtraBars;

namespace YIEternalMIS.Interfaces
{
    public interface IOpenModel
    {
        /// <summary>
        /// 窗口打开方法
        /// </summary>
        /// <param name="MenuNewID">窗口编号</param>
        IOpenModuleForm GetOpenFormPro(string MenuNewID );

        IOpenModuleForm GetOpenFormProNew(string MenuNewID);
    }
}
