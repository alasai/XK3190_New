/*************************************************************************************
    * 类 名 称：       CustomException
    * 命名空间：       Common
    * 文 件 名：       CustomException
    * 创建时间：       2017/6/2 9:13:53
    * 作    者：        王宏巍
    * 说   明：        自定义异常
    * 修改时间：
    * 修 改 人：
*************************************************************************************/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



namespace YIEternalMIS.Common
{
    public class CustomException :Exception
    {
        /// <summary>
        /// 自定义异常
        /// </summary>
        /// <param name="message"></param>
        public CustomException(string message)
            : base(message)
        { }
    }
}
