using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebServiceForAirport.Models;
using WebServiceForAirport.Repository;

namespace WebServiceForAirport.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    public class PitStopAPIController : ApiController
    {
        IRepository<PitStop> repo;
        /// <summary>
        /// 
        /// </summary>
        public PitStopAPIController()
        {
            repo = new PitStopRepository();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public IEnumerable<PitStop> GetAll()
        {
            return repo.GetAll();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public PitStop GetById(int id)
        {
            return repo.Get(id);
        }
    }
}
