/*************************************************************************************
     * 类 名 称：       ISystemMSG
     * 命名空间：       YIEternalMIS.Interfaces
     * 文 件 名：       ISystemMSG
     * 创建时间：       2017/6/27 13:10:58
     * 作    者：        王宏巍
     * 说   明：         系统消息管理接口
     * 修改时间：
     * 修 改 人：
 *************************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YIEternalMIS.Interfaces
{
    public interface ISystemMSG
    {
        bool DoADD();
        bool DoEdit(string sMsgID);
        bool DoDelete(string sMsgID);
    }
}
