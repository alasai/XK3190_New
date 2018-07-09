/*************************************************************************************
    * 类 名 称：       CCursor
    * 命名空间：       Common
    * 文 件 名：       CCursor
    * 创建时间：       2017/6/2 14:17:37
    * 作    者：        王宏巍
    * 说   明：
    * 修改时间：
    * 修 改 人：
*************************************************************************************/
using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace YIEternalMIS.Common
{

    /// <summary>
    /// 显示等待光标
    /// </summary>
    public class CCursor
    {
        [DllImport("user32.dll")]
        public static extern long GetCursorPos(ref System.Drawing.Point lpPoint);

        /// <summary>
        /// 显示等待光标
        /// </summary>
        public static void ShowWaitCursor()
        {
            Cursor.Current = Cursors.WaitCursor;
            Cursor.Show();
        }

        /// <summary>
        /// 显示预设光标
        /// </summary>
        public static void ShowDefaultCursor()
        {
            Cursor.Current = Cursors.Default;
            Cursor.Show();
        }
    }
}
