/*************************************************************************************
    * 类 名 称：       UpdateType
    * 命名空间：       Common
    * 文 件 名：       UpdateType
    * 创建时间：       2017/6/2 10:01:53
    * 作    者：        王宏巍
    * 说   明：        窗口操作状态和数据操作状态 , 主窗口类型
    * 修改时间：
    * 修 改 人：
*************************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YIEternalMIS.Common
{
    /// <summary>
    /// 数据窗体的操作类型
    /// </summary>
    public enum UpdateType
    {
        None,

        /// <summary>
        /// 新增状态
        /// </summary>
        Add,

        /// <summary>
        /// 修改状态
        /// </summary>
        Modify
    }


    /// <summary>
    /// 数据操作状态
    /// </summary>
    public enum Operationstate
    {

        /// <summary>
        /// 已取消
        /// </summary>
        ToCancel,


        /// <summary>
        /// 已保存
        /// </summary>
        ToSave,

    }


    public enum FormOpenType
    {
        /// <summary>
        /// MDI模式打开窗口
        /// </summary>

        MdiOpen,
        /// <summary>
        /// 弹出式打开窗口，保留当前黄口在最前
        /// </summary>
        DiaLogOpen,
        /// <summary>
        /// 预留模式 ，暂时未用。
        /// </summary>
        DefaultOpen
    }


    public enum FromNavOrRibbonType
    {
        /// <summary>
        /// NavBar主窗口模式打开窗口
        /// </summary>
        NavBar,
        /// <summary>
        /// Ribbon主窗口模式打开窗口
        /// </summary>
        Ribbon,
        /// <summary>
        /// 预留模式，暂时未用
        /// </summary>
        DefaultType
    }


}
