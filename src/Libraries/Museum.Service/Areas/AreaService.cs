using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Museum.Core.Data;
using Museum.Core.Domain;

namespace Museum.Service.Areas
{
    public class AreaService : IAreaService
    {
        private readonly IRepository<Area> _areaRepository;

        public AreaService(IRepository<Area> areaRepository)
        {
            _areaRepository = areaRepository;
        }

        public Area GetAreaById(int areaId)
        {
            if (areaId == 0)
                return null;

            return _areaRepository.GetById(areaId);
        }

        public IEnumerable<Area> GetAllAreas()
        {
            return _areaRepository.GetAll();
        }

        public void InsertArea(Area area)
        {
            if (area == null)
                throw new ArgumentNullException(nameof(area));

            _areaRepository.Insert(area);
        }

        public void InsertAreas(IEnumerable<Area> areas)
        {
            if (areas == null)
                throw new ArgumentNullException(nameof(areas));

            _areaRepository.Insert(areas);
        }

        public void UpdateArea(Area area)
        {
            if (area == null)
                throw new ArgumentNullException(nameof(area));

            _areaRepository.Update(area);
        }

        public void UpdateAreas(IEnumerable<Area> areas)
        {
            if (areas == null)
                throw new ArgumentNullException(nameof(areas));

            _areaRepository.Update(areas);
        }

        public void DeleteArea(Area area)
        {
            if (area == null)
                throw new ArgumentNullException(nameof(area));

            _areaRepository.Delete(area);
        }

        public void DeleteAreas(IEnumerable<Area> areas)
        {
            if (areas == null)
                throw new ArgumentNullException(nameof(areas));

            _areaRepository.Delete(areas);
        }
    }
}
