using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebServiceForAirport.Models;
using System.Data.Entity;
using Newtonsoft.Json;
using System.Xml;
using WebServiceForAirport.Repository;

namespace WebServiceForAirport.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    public class AirportAPIController : ApiController
    {
        /// <summary>
        /// 
        /// </summary>
       IRepository<Airport> repo;
        /// <summary>
        /// 
        /// </summary>
        public AirportAPIController()
        {
            repo = new AirportRepository();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Airport> GetAll()
        {
            return repo.GetAll();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Airport GetById(int id)
        {
            return null;
        }
    }
}
