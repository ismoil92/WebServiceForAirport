using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebServiceForAirport.Models;

namespace WebServiceForAirport.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    public class WebAPIController : ApiController
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Information> GetAll()
        {
            return null;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Information GET(int id)
        {
            return null;
        }
    }
}
