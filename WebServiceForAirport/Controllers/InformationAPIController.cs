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
    public class InformationAPIController : ApiController
    {
        IRepository<Information> repo;
        /// <summary>
        /// 
        /// </summary>
        public InformationAPIController()
        {
            repo = new InformationRepository();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Information> GetAll()
        {
            return repo.GetAll();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Information GetById(int id)
        {
            return repo.Get(id);
        }
    }
}
