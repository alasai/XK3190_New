/*************************************************************************************
    * 类 名 称：       DevGridViewXML
    * 命名空间：       YIEternalMIS.Library
    * 文 件 名：       DevGridViewXML
    * 创建时间：       2017/6/27 14:19:59
    * 作    者：        王宏巍
    * 说   明：        获取窗口的XML本地样式，窗口关闭的时候保存样式
    * 修改时间：
    * 修 改 人：
*************************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.XtraGrid.Views.Grid;

namespace YIEternalMIS.Library
{
    public class DevGridViewXML
    {
        private GridView _view;
        public DevGridViewXML( GridView gv )
        {
            _view = gv;
        }

        public void LoadXML()
        {

        }
    }
}
