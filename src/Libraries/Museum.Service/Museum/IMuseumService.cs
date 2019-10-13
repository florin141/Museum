using Museum.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Museum.Service.Museum
{
    public interface IMuseumService
    {
        /// <summary>
        /// Gets all museums
        /// </summary>
        /// <param name="areaName">Area name; null load all museums</param>
        /// <param name="cityName">City name; null load all museums</param>
        /// <param name="regionName">Region name; null load all museums</param>
        /// <param name="countryName">Country name; null load all museums</param>
        /// <param name="featureName">Feature name; null load all museums</param>
        /// <param name="ownerName">Owner name; null load all museums</param>
        /// <param name="museumType">Museum type; null load all museums</param>
        /// <returns></returns>
        IEnumerable<Museums> GetAllMuseums(
            string cityName = null,
            string countryName = null,
            string featureName = null,
            string ownerName = null,
            string museumType = null);
    }
}
