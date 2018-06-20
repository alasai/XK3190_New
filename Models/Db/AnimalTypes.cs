using System;
using System.Collections.Generic;
using System.Text;
using SqlSugar;

namespace Models.Db
{
    /// <summary>
    /// 货物表
    /// </summary>
    public class AnimalTypes
    {
        [SugarColumn(IsPrimaryKey = true, IsIdentity = true)]
        public int animalTypeId { get; set; }
        public string animalTypeName { get; set; }
        public decimal price { get; set; }
        public string traceCode { get; set; }
    }
}
