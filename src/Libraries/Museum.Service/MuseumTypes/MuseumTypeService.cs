using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Museum.Core.Data;
using Museum.Core.Domain;

namespace Museum.Service.MuseumTypes
{
    public class MuseumTypeService : IMuseumTypeService
    {
        private readonly IRepository<MuseumType> _museumTypeRepository;

        public MuseumTypeService(IRepository<MuseumType> museumTypeRepository)
        {
            _museumTypeRepository = museumTypeRepository;
        }

        public MuseumType GetMuseumTypeById(int museumTypeId)
        {
            if (museumTypeId <= 0)
                return null;

            return _museumTypeRepository.GetById(museumTypeId);
        }

        public IEnumerable<MuseumType> GetAllMuseumTypes()
        {
            return _museumTypeRepository.GetAll();
        }

        public void Insert(MuseumType museumType)
        {
            if (museumType == null)
                throw new ArgumentNullException(nameof(museumType));

            _museumTypeRepository.Insert(museumType);

            // log
        }

        public void Insert(IEnumerable<MuseumType> museumTypes)
        {
            if (museumTypes == null)
                throw new ArgumentNullException(nameof(museumTypes));

            _museumTypeRepository.Insert(museumTypes);

            // log
        }

        public void Update(MuseumType museumType)
        {
            if (museumType == null)
                throw new ArgumentNullException(nameof(museumType));

            _museumTypeRepository.Update(museumType);

            // log
        }

        public void Update(IEnumerable<MuseumType> museumTypes)
        {
            if (museumTypes == null)
                throw new ArgumentNullException(nameof(museumTypes));

            _museumTypeRepository.Update(museumTypes);

            // log
        }

        public void Delete(MuseumType museumType)
        {
            if (museumType == null)
                throw new ArgumentNullException(nameof(museumType));

            _museumTypeRepository.Delete(museumType);

            // log
        }

        public void Delete(IEnumerable<MuseumType> museumTypes)
        {
            if (museumTypes == null)
                throw new ArgumentNullException(nameof(museumTypes));

            _museumTypeRepository.Delete(museumTypes);

            // log
        }
    }
}
