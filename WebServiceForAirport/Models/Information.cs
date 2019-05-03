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
    public class Information
    {
        /// <summary>
        /// 
        /// </summary>
        public int ID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string NumberFlight { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string NumberBoard { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public virtual Airport airport { get; set; }
    }
}