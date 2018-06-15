/*************************************************************************************
     * 类 名 称：       IOpenModuleForm
     * 命名空间：       YIEternalMIS.Interfaces
     * 文 件 名：       IOpenModuleForm
     * 创建时间：       2017/6/12 9:27:18
     * 作    者：        王宏巍
     * 说   明：        要打开窗体类
     * 修改时间：
     * 修 改 人：
 *************************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using YIEternalMIS.Common;
using System.Drawing;

namespace YIEternalMIS.Interfaces
{
    public interface IOpenModuleForm
    {

        /// <summary>
        /// 窗体ClassName
        /// </summary>
        string FormName { get; set; }
        /// <summary>
        /// 窗体的Caption
        /// </summary>
        string FormText { get; set; }

        /// <summary>
        /// 窗体Tag 用于存储相关数据
        /// </summary>
        string FormTag { get; set; }

        /// <summary>
        /// 窗体的32大小图标
        /// </summary>
        Image FormImage32 { get; set; }
        /// <summary>
        /// 窗体对应16大小图标
        /// </summary>
        Image FormImage16 { get; set; }

        /// <summary>
        /// 窗体所在程序集
        /// </summary>
        string FormAssembly { get; set; }

        /// <summary>
        /// 窗体的打开类型
        /// </summary>
        FormOpenType FormOpenType { get; set; }

        /// <summary>
        /// 主窗口类型
        /// </summary>
        FromNavOrRibbonType FormType { get; set; }

    }
}
