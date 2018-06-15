using System;
using System.Collections.Generic;
using System.Text;

namespace Models.Db
{
    public class ProductModel
    {
        public int productId { get; set; }
        public string productName { get; set; }

        public string productNo { get; set; }
        public string spec { get; set; }
        public string barcode { get; set; }
        public string comment { get; set; }
        public bool isFixedWeight { get; set; }
        public decimal nominalWeight { get; set; }
        public string ingredients { get; set; }
        public string expiration { get; set; }
        public string storageCondition { get;set; }

        public bool isBoned { get; set; }
        public string isfixedStr { get { return isFixedWeight ? "是" : "否"; } }
    }
}
