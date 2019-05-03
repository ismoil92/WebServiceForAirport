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
    public class InformationRepository:IRepository<Information>
    {
        AirDBContext db;
        /// <summary>
        /// 
        /// </summary>
        public InformationRepository()
        {
            db = new AirDBContext();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Information> GetAll()
        {
            return db.Informations.ToList();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Information Get(int id)
        {
            return db.Informations.Find(id);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="info"></param>
        public void Create(Information info)
        {
            db.Informations.Add(info);
            db.SaveChanges();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="info"></param>
        public void Update(Information info)
        {
            db.Entry(info).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        public void Delete(int id)
        {
            Information info = db.Informations.Find(id);
            if(info!=null)
            {
                db.Informations.Remove(info);
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