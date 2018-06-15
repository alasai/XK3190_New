using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppService.DbContext;
using Models;
using Models.Db;
using YIEternalMIS.Common;

namespace AppService
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
    }
}
