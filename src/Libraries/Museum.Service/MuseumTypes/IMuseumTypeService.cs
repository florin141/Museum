using Museum.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Museum.Service.MuseumTypes
{
    public interface IMuseumTypeService
    {
        MuseumType GetMuseumTypeById(int museumTypeId);
        IEnumerable<MuseumType> GetAllMuseumTypes();
        void Insert(MuseumType museumType);
        void Insert(IEnumerable<MuseumType> museumTypes);
        void Update(MuseumType museumType);
        void Update(IEnumerable<MuseumType> museumTypes);
        void Delete(MuseumType museumType);
        void Delete(IEnumerable<MuseumType> museumTypes);
    }
}
