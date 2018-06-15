using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
namespace Models.Db
{
    //Weighings
    public class Weighings
    {

        /// <summary>
        /// batchId
        /// </summary>		

        public string batchId { get; set; }
        /// <summary>
        /// hookId
        /// </summary>		

        public string hookId { get; set; }
        /// <summary>
        /// attachTime
        /// </summary>		

        public DateTime attachTime { get; set; }
        /// <summary>
        /// animalId
        /// </summary>		

        public string animalId { get; set; }
        /// <summary>
        /// netWeight
        /// </summary>		

        public decimal netWeight { get; set; }
        /// <summary>
        /// weighingTime
        /// </summary>		

        public DateTime weighingTime { get; set; }
        /// <summary>
        /// uploaded
        /// </summary>		

        public bool uploaded { get; set; }

    }
}