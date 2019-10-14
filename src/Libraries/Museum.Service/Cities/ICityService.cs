using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Museum.Core.Domain;

namespace Museum.Service.Cities
{
    public interface ICityService
    {
        City GetCityById(int cityId);
        IEnumerable<City> GetAllCities();
        void Insert(City city);
        void Insert(IEnumerable<City> cities);
        void Update(City city);
        void Update(IEnumerable<City> cities);
        void Delete(City city);
        void Delete(IEnumerable<City> cities);
    }
}
