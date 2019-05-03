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
    public class DepartureAndArrivalAPIController : ApiController
    {
        IRepository<DepartureAndArrival> repo;
        /// <summary>
        /// 
        /// </summary>
        public DepartureAndArrivalAPIController()
        {
            repo = new DepartureAndArrivalRepository();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public IEnumerable<DepartureAndArrival> GetAll()
        {
            return repo.GetAll();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public DepartureAndArrival Get(int id)
        {
            return repo.Get(id);
        }
    }
}
