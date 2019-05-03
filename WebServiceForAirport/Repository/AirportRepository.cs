using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebServiceForAirport.Models;

namespace WebServiceForAirport.Repository
{
    /// <summary>
    /// 
    /// </summary>
    public class AirportRepository:IRepository<Airport>
    {
        AirDBContext db;
        /// <summary>
        /// 
        /// </summary>
        public AirportRepository()
        {
            db = new AirDBContext();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Airport> GetAll()
        {
            return db.Airports.ToList();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Airport Get(int id)
        {
            return db.Airports.Find(id);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="a"></param>
        public void Create(Airport a)
        {
            db.Airports.Add(a);
            db.SaveChanges();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="a"></param>
        public void Update(Airport a)
        {
            db.Entry(a).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        public void Delete(int id)
        {
            Airport air = db.Airports.Find(id);
            if(air!=null)
            {
                db.Airports.Remove(air);
                db.SaveChanges();
            }
        }
        private bool disposed = false;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="disposing"></param>
        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    db.Dispose();
                }
            }
            this.disposed = true;
        }
        /// <summary>
        /// 
        /// </summary>
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}