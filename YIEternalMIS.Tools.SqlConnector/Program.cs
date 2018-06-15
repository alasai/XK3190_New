using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;

namespace YIEternalMIS.Tools.SqlConnector
{
    static class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            Application.ThreadException += new ThreadExceptionEventHandler(Application_ThreadException);//捕获系统所产生的异常。            
            frmSQLConnector.ExecuteConnection();//打开配置窗体
            Application.Exit();
        }

        private static void Application_ThreadException(object sender, ThreadExceptionEventArgs e)
        {
            MessageBox.Show(e.Exception.Message, "警告",
              MessageBoxButtons.OK,
              MessageBoxIcon.Hand,
              MessageBoxDefaultButton.Button1);
        }
    }

}