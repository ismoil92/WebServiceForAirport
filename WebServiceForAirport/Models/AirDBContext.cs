using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;


namespace WebServiceForAirport.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class AirDBContext:DbContext
    {
        /// <summary>
        /// 
        /// </summary>
        public DbSet<Airport> Airports { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public DbSet<Departure_Arrival> Departires_Arrivals { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public DbSet<PitStop> PitStops { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public DbSet<Information> Informations { get; set; }
    }
}