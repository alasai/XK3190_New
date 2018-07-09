using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppService.DbContext;
using WeightManage.Models.Db;
using YIEternalMIS.Common;

namespace WeightManage.AppService
{
    public class LoginAppService
    {
        public Loginer Login(string uname, string pwd)
        {
            Loginer userer = null;
            try
            {
                
                using (var sql= SugarDbContext.GetInstance())
                {
                    var user = sql.Queryable<Opers>().Where(s => s.userName == uname && s.password == pwd)
                        .First();
                    if (user == null)
                    {
                        return null;
                    }
                    userer = new Loginer();
                    //存储登录用户信息
                    userer.Account = user.userName;
                    userer.AccountName = user.operName;
                    userer.LoginTime = DateTime.Now;
                }

            }
            catch (Exception e)
            {
               LogNHelper.Exception(e);
            }

            return userer;
        }

        public string UpdatePwd(string uname, string oldPwd, string newPwd)
        {
            try
            {
                string encodePwd = CEncoder.Encode(oldPwd);
                using (var sql=SugarDbContext.GetInstance())
                {
                    var id = sql.Queryable<Opers>().Where(s => s.userName == uname && s.password == encodePwd)
                        .Select(s => s.Id).First();
                    if (id == 0)
                    {
                        return "原始密码错误!!!";
                    }
                   string newEncodePwd= CEncoder.Encode(newPwd);

                    sql.Updateable<Opers>().UpdateColumns(s => new Opers() {password = newEncodePwd})
                        .Where(s => s.Id == id).ExecuteCommand();
                }
            }
            catch (Exception ex)
            {
               LogNHelper.Exception(ex);
                return "密码修改失败!!!";
            }

            return string.Empty;
        }
    }
}
