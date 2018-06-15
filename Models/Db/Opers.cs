using System;
using System.Collections.Generic;
using System.Text;
using SqlSugar;

namespace Models.Db
{
    public class Opers
    {
        [SugarColumn(IsPrimaryKey = true,IsIdentity = true)]
        public int Id { get; set; }

        public string userName { get; set; }
        public string operName { get; set; }
        public string password { get; set; }
        public bool isAdmin { get; set; }
        public bool isRepoter { get; set; }
        public bool stopped { get; set; }
        public string jobNumber { get; set; }
        [SugarColumn(IsIgnore = true)]
        public string isAdminStr { get { return isAdmin ? "是" : "否"; } }
        public string jobStation { get; set; }
    }
}
