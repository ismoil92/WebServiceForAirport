using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebServiceForAirport.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class Airport
    {
        /// <summary>
        /// 
        /// </summary>
        public int ID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Country { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string City { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string NameAirport { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Airline { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string CodeAirport { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public bool Active { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public virtual Information information { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public virtual ICollection<DepartureAndArrival> DepArrList { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public virtual ICollection<PitStop> PitStopList { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Airport()
        {
            DepArrList = new List<DepartureAndArrival>();
            PitStopList = new List<PitStop>();
        }
    }
}