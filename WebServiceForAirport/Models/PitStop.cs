using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebServiceForAirport.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class PitStop
    {
        /// <summary>
        /// 
        /// </summary>
        public int ID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string PitStopCity { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public DateTime PitStopTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int? AirportID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public virtual Airport airport { get; set; }
    }
}