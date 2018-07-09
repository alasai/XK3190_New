using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
namespace WeightManage.Models.Db
{
    //Cuttings
    public class Cuttings
    {

        /// <summary>
        /// traceId
        /// </summary>		

        public string traceId { get; set; }
        /// <summary>
        /// batchId
        /// </summary>		

        public string batchId { get; set; }
        /// <summary>
        /// productName
        /// </summary>		

        public string productName { get; set; }
        /// <summary>
        /// netWeight
        /// </summary>		

        public decimal netWeight { get; set; }
        /// <summary>
        /// ingredients
        /// </summary>		

        public string ingredients { get; set; }
        /// <summary>
        /// storageCondition
        /// </summary>		

        public string storageCondition { get; set; }
        /// <summary>
        /// expiration
        /// </summary>		

        public string expiration { get; set; }
        /// <summary>
        /// producingTime
        /// </summary>		

        public DateTime producingTime { get; set; }
        /// <summary>
        /// uploaded
        /// </summary>		

        public bool uploaded { get; set; }

    }
}