using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Museum.Core.Domain;

namespace Museum.Service.Areas
{
    public interface IAreaService
    {
        Area GetAreaById(int id);
        IEnumerable<Area> GetAllAreas();
        void InsertArea(Area area);
        void InsertAreas(IEnumerable<Area> areas);
        void UpdateArea(Area area);
        void UpdateAreas(IEnumerable<Area> areas);
        void DeleteArea(Area area);
        void DeleteAreas(IEnumerable<Area> areas);
    }
}
