using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebServiceForAirport.Models;

namespace WebServiceForAirport.Repository
{
    /// <summary>
    /// 
    /// </summary>
    public interface IRepositoryByAirportName:IDisposable
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        IEnumerable<Airport> GetAllByAirportName();
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Airport GetAirportNameByID(int id);
        /// <summary>
        /// 
        /// </summary>
        void CreateAirportName();
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        void EditAirportName(int id);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        void DeleteAirportName(int id);
    }
}
