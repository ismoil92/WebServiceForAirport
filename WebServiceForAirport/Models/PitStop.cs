using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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
        [Key]
        [ForeignKey("airport")]
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
        public Airport airport { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Information info { get; set; }
    }
}