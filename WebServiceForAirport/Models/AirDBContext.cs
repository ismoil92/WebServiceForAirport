using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

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
        public AirDBContext()
        {
            this.Configuration.ProxyCreationEnabled = false;
            this.Configuration.LazyLoadingEnabled = false;
        }
        /// <summary>
        /// 
        /// </summary>
        public DbSet<Airport> Airports { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public DbSet<DepartureAndArrival> DepartiresAndArrivals { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public DbSet<PitStop> PitStops { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public DbSet<Information> Informations { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            //Primary Key for Airport
            modelBuilder.Entity<Airport>()
                .HasKey(a => a.ID);

            //Primary Key for Departure-Arrival
            modelBuilder.Entity<DepartureAndArrival>()
                .HasKey(da => da.ID);

            //Primary Key for PitStop
            modelBuilder.Entity<PitStop>()
                .HasKey(p => p.ID);

            //Primary Key for Information
            modelBuilder.Entity<Information>()
                .HasKey(i => i.ID);


            //one-to-one Airport - Information
            modelBuilder.Entity<Airport>()
                .HasRequired(a=>a.information)
                .WithRequiredPrincipal(a=>a.airport);

            //one-to-many Airport - Departure-Arrival
            modelBuilder.Entity<Airport>()
                .HasMany(a => a.DepArrList)
                .WithRequired(da => da.airport);

            //one-to-many Airport - PitStop
            modelBuilder.Entity<Airport>()
                .HasMany(a => a.PitStopList)
                .WithRequired(pi => pi.airport);
            base.OnModelCreating(modelBuilder);
        }
    }
}