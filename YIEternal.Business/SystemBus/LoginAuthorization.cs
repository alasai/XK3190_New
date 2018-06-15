/*************************************************************************************
    * 类 名 称：       LoginAuthorization
    * 命名空间：       YIEternalMIS.Business
    * 文 件 名：       LoginAuthorization
    * 创建时间：       2017/6/7 9:17:21
    * 作    者：        王宏巍
    * 说   明：        用户登录接口类
    * 修改时间：
    * 修 改 人：
*************************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using YIEternalMIS.Interfaces;
using YIEternalMIS.Common;
using System.Data;
using YIEternalMIS.Core;
using System.Windows.Forms;

namespace YIEternalMIS.Business
{
    public class LoginAuthorization : ILoginAuthorization
    {
        public bool SupportLogout { get { return true; } }

        /// <summary>
        /// 系统登录
        /// </summary>
        /// <param name="loginUser"></param>
        /// <returns></returns>
        public bool Login(LoginUser loginUser)
        {
            string sUserID, sPwd;
            int LoginCount;
            bool bResult = false;
            sUserID = loginUser.Account;
            //加密后判断
            sPwd = CEncoder.Encode(loginUser.Password);
            try
            {
                BLL.YIEMYUser YIEuser = new BLL.YIEMYUser();
                Model.YIEMYUser YIEModel = new Model.YIEMYUser();
                LoginCount = YIEuser.GetList("LoginID ='" + sUserID + "' AND PassWord = '" + sPwd + "'").Tables[0].Rows.Count;
                if (LoginCount <= 0)
                {
                    Msg.ShowInformation("您输入的用户名和密码不匹配!!!");
                    return bResult;
                }
                YIEModel = YIEuser.GetModel(sUserID);
                YIEModel.LoginState = "1";
                YIEModel.LoginInDate = BLL.YIEDoFun.DoGetServerDateTime();
                Loginer userer = new Loginer();

                
                //存储登录用户信息
                userer.Account = YIEModel.Loginid;
                userer.AccountName = YIEModel.LoginName;
                userer.DataSetID = loginUser.DataSetID;
                userer.DataSetName = loginUser.DataSetDBName;
                userer.LoginTime = BLL.YIEDoFun.DoGetServerDateTime();
                Loginer.CurrentUser = userer;
                //更新用户登录状态
                YIEuser.Update(YIEModel);
                //下载用户权限
                GetUserAuthor(userer);
                bResult = true;
            }
            catch(Exception ex)
            { Msg.ShowException(ex); }
            finally
            {
                //还原系统配置为System 数据库
                if(!bResult) 
                {
                    IWriteSQLConfigValue cfgNormal = new INIFileWriter(Application.StartupPath + SqlConfiguration.INI_CFG_PATH);
                    SqlConfiguration.SetSQLConfig(cfgNormal);
                    SqlConfiguration.SetConnstr(SqlConfiguration.CurrentConnectionString);
                }
            }
            return bResult;
        }
        public bool LoginNew(LoginUser loginUser)
        {
            string sUserID, sPwd;
            int LoginCount;
            bool bResult = false;
            sUserID = loginUser.Account;
            //加密后判断
            sPwd = CEncoder.Encode(loginUser.Password);
            try
            {
                BLL.YIEMYUser YIEuser = new BLL.YIEMYUser();
                Model.YIEMYUser YIEModel = new Model.YIEMYUser();
                LoginCount = YIEuser.GetList("LoginID ='" + sUserID + "' AND PassWord = '" + sPwd + "'").Tables[0].Rows.Count;
                if (LoginCount <= 0)
                {
                    Msg.ShowInformation("您输入的用户名和密码不匹配!!!");
                    return bResult;
                }
                YIEModel = YIEuser.GetModel(sUserID);
                YIEModel.LoginState = "1";
                YIEModel.LoginInDate = DateTime.Now;
                Loginer userer = new Loginer();


                //存储登录用户信息
                userer.Account = YIEModel.Loginid;
                userer.AccountName = YIEModel.LoginName;
                userer.DataSetID = loginUser.DataSetID;
                userer.DataSetName = loginUser.DataSetDBName;
                userer.LoginTime = BLL.YIEDoFun.DoGetServerDateTime();
                Loginer.CurrentUser = userer;
                //更新用户登录状态
               // YIEuser.Update(YIEModel);
                //下载用户权限
                GetUserAuthor(userer);
                bResult = true;
            }
            catch (Exception ex)
            { Msg.ShowException(ex); }
            finally
            {
                //还原系统配置为System 数据库
                if (!bResult)
                {
                    IWriteSQLConfigValue cfgNormal = new INIFileWriter(Application.StartupPath + SqlConfiguration.INI_CFG_PATH);
                    SqlConfiguration.SetSQLConfig(cfgNormal);
                    SqlConfiguration.SetConnstr(SqlConfiguration.CurrentConnectionString);
                }
            }
            return bResult;
        }
        /// <summary>
        /// 系统登出
        /// </summary>
        public void Logout()
        {
            DateTime ldtserver;
            try
            {
                BLL.YIEMYUser LoginUser = new BLL.YIEMYUser();
                Model.YIEMYUser _LoginModel = new Model.YIEMYUser();
                _LoginModel = LoginUser.GetModel( Loginer.CurrentUser.Account );
                //获取系统时间\
                ldtserver = BLL.YIEDoFun.DoGetServerDateTime();
                _LoginModel.LoginOutDate = ldtserver;
                //登录状态改为0未登录
                _LoginModel.LoginState = "0";
                //更新登录状态和登出时间
                LoginUser.Update(_LoginModel);
            }
            catch (Exception ex)
            { Msg.ShowException(ex); }
        }


        /// <summary>
        /// 修改密码
        /// </summary>
        /// <param name="loginuser">当前登录用户类</param>
        /// <param name="sNewPwd">新密码【未加密】</param>
        public void EditPwd(LoginUser loginuser, string sNewPwd)
        {
            //获取当前登录用户
            string sUserID = loginuser.Account;
            string sPWD = CEncoder.Encode(loginuser.Password);
            
            BLL.YIEMYUser YIEuser = new BLL.YIEMYUser();
            Model.YIEMYUser YIEModel = new Model.YIEMYUser();
            //获取用户实体
            YIEModel = YIEuser.GetModel(sUserID);
            if( sPWD != YIEModel.PassWord) 
            {
                Msg.ShowError("原始密码错误!!!");
                return ;
            }

            loginuser.Password = sNewPwd;
            YIEModel.PassWord = CEncoder.Encode(loginuser.Password);
            if (YIEuser.Update(YIEModel))
            {
                //保存本地配置文件
                if (SystemConfig.CurrentConfig.LoginSave)
                {
                    Common.SystemConfig.CurrentConfig.LastLoginPWD = CEncoder.Encode(loginuser.Password);
                    Common.SystemConfig.WriteSettings(Common.SystemConfig.CurrentConfig);
                }
                Msg.ShowInformation("密码修改成功!!!");
            }
            else
                Msg.ShowError("密码修改失败!!!");
        }
        /// <summary>
        /// 下载用户权限
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        bool GetUserAuthor( Loginer user )
        {
            string UserID = user.Account;
            string RoleID;
            string LoginSysID = SystemConfig.LoginSysID;
            string sSystype = SystemConfig.SysType;
            //获取用户表
            bool DtResult = false;

            DataTable _ldt =  new BLL.YIEMYUser().GetList("LoginID='" + UserID + "'").Tables[0];
            if (_ldt.Rows.Count <= 0)
            {
                Msg.ShowInformation("获取用户信息失败，无法下载用户权限信息!!!");
                return DtResult;
            }
            RoleID = _ldt.Rows[0]["RoleID"].ToString();
            
            //下载能打开的窗口权限  包含所有子系统
            ILoginAuth ilogin = new BLL.V_YIEFormRolePER();
            SystemAuthentication.UserAuthorities = ilogin.GetList("Permission = '1' AND MenuVisible = '1' AND RoleID ='" + RoleID + "' AND SysID = '" + LoginSysID + "'" ).Tables[0];
            
            ////带子系统模式，下载子系统代码
            //if( !(sSystype == "1"))
            //{
            //    SystemAuthentication.SysAuthorities = ilogin.GetGroupDt("Permission = '1' AND MenuVisible = '1' AND RoleID ='" + RoleID + "'").Tables[0];
            //}
            

            return true;


        }

        bool GetBtnFormAuthor( Loginer user , string FromClassName )
        {
            return true;
        }






    }
}
