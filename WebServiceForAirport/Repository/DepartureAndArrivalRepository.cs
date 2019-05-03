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
    public class DepartureAndArrivalRepository:IRepository<DepartureAndArrival>
    {
        AirDBContext db;
        /// <summary>
        /// 
        /// </summary>
        public DepartureAndArrivalRepository()
        {
            db = new AirDBContext();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public IEnumerable<DepartureAndArrival> GetAll()
        {
            return db.DepartiresAndArrivals.ToList();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public DepartureAndArrival Get(int id)
        {
            return db.DepartiresAndArrivals.Find(id);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="da"></param>
        public void Create(DepartureAndArrival da)
        {
            db.DepartiresAndArrivals.Add(da);
            db.SaveChanges();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="da"></param>
        public void Update(DepartureAndArrival da)
        {
            db.Entry(da).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        public void Delete(int id)
        {
            DepartureAndArrival da = db.DepartiresAndArrivals.Find(id);
            if(da!=null)
            {
                db.DepartiresAndArrivals.Remove(da);
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