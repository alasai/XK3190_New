/*************************************************************************************
    * 类 名 称：       Msg
    * 命名空间：       Common
    * 文 件 名：       Msg
    * 创建时间：       2017/6/2 9:52:30
    * 作    者：        王宏巍
    * 说   明：
    * 修改时间：
    * 修 改 人：
*************************************************************************************/
using System.Reflection;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;

namespace YIEternalMIS.Common
{
    /// <summary>
    /// 系统消息提示窗体
    /// </summary>
    public class Msg
    {

        /// <summary>
        /// 打开对话框
        /// </summary>
        /// <param name="msg">本次对话内容</param>
        /// <returns></returns>
        public static bool AskQuestion(string msg)
        {
            DialogResult r;
            r = DevExpress.XtraEditors.XtraMessageBox.Show(msg, "确认信息！",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2);
            return (r == DialogResult.Yes);
        }

        /// <summary>
        /// 显示系统异常
        /// </summary>
        /// <param name="e">系统异常</param>
        public static void ShowException(Exception e)
        {
            string s = e.Message;
            string innerMsg = string.Empty;

            if (e.InnerException != null)
            {
                innerMsg = e.InnerException.Message;
                s += "\n" + innerMsg;
            }

            Warning(s);
        }

        public static void ShowException(Exception ex, string customMessage)
        {
            if (ex is CustomException)
                ShowException(ex);
            else if (customMessage != "")
                Warning(customMessage);
            else
                Warning(ex.Message);
        }

        /// <summary>
        /// 警告提示框
        /// </summary>
        /// <param name="msg">警告内容</param>
        public static void Warning(string msg)
        {
            DevExpress.XtraEditors.XtraMessageBox.Show(msg, "警告",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation,
                MessageBoxDefaultButton.Button1);
        }

        /// <summary>
        /// 错误消息提示框
        /// </summary>
        /// <param name="msg">错误消息内容</param>
        public static void ShowError(string msg)
        {
            DevExpress.XtraEditors.XtraMessageBox.Show(msg, "警告",
                MessageBoxButtons.OK,
                MessageBoxIcon.Hand,
                MessageBoxDefaultButton.Button1);
        }

        /// <summary>
        /// 信息提示框
        /// </summary>
        /// <param name="msg">本次显示的消息</param>
        public static void ShowInformation(string msg)
        {
            DevExpress.XtraEditors.XtraMessageBox.Show(msg, "信息",
                MessageBoxButtons.OK,
                MessageBoxIcon.Asterisk,
                MessageBoxDefaultButton.Button1);
        }



        


    }

    }
