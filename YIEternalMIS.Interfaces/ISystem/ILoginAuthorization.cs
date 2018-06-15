/*************************************************************************************
     * 类 名 称：       ILoginAuthorization
     * 命名空间：       YIEternalMIS.Interfaces
     * 文 件 名：       ILoginAuthorization
     * 创建时间：       2017/6/2 15:36:07
     * 作    者：        王宏巍
     * 说   明：
     * 修改时间：
     * 修 改 人：
 *************************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using YIEternalMIS.Common;

namespace YIEternalMIS.Interfaces
{
    public interface ILoginAuthorization
    {
        bool SupportLogout { get; }

        bool Login(LoginUser loginUser);
        void Logout();
        void EditPwd(LoginUser loginuser, string sNewPwd);
    }
}
