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
    public class PitStopRepository:IRepository<PitStop>
    {
        AirDBContext db;
        /// <summary>
        /// 
        /// </summary>
        public PitStopRepository()
        {
            db = new AirDBContext();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public IEnumerable<PitStop> GetAll()
        {
            return db.PitStops.ToList();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public PitStop Get(int id)
        {
            return db.PitStops.Find(id);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pt"></param>
        public void Create(PitStop pt)
        {
            db.PitStops.Add(pt);
            db.SaveChanges();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pt"></param>
        public void Update(PitStop pt)
        {
            db.Entry(pt).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        public void Delete(int id)
        {
            PitStop pt = db.PitStops.Find(id);
            if(pt!=null)
            {
                db.PitStops.Remove(pt);
                db.SaveChanges();
            }
        }

        bool disposed = false;
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