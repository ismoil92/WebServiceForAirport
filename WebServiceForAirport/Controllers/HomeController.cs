using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebServiceForAirport.Models;

namespace WebServiceForAirport.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    public class HomeController : Controller
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        // GET: Home
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="aircont"></param>
        /// <returns></returns>
        //POST:Home
        [HttpPost]
        public ActionResult Index(AirDBContext aircont)
        {
            return null;
        }
    }
}