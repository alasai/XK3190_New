using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
namespace Models.Db
{
    //Headsoff
    public class Headsoff
    {

        /// <summary>
        /// animalId
        /// </summary>		

        public string animalId { get; set; }
        /// <summary>
        /// attachTime
        /// </summary>		

        public DateTime attachTime { get; set; }
        /// <summary>
        /// upload
        /// </summary>		

        public bool uploaded { get; set; }
        /// <summary>
        /// flag
        /// </summary>		

        public bool flag { get; set; }

        public int yearNum { get; set; }
        public int sort { get; set; }

    }
}