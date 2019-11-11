using BuurtPreventie.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuurtPreventie.Data.Repositories.Interfaces
{
    public interface IZoneRepository
    {
        ICollection<Zone> GetAll();
        ICollection<Zone> GetAllByGemeenteId(int gemeenteId);

        Zone GetById(int id);

        int Add(Zone zone);

        void Update(Zone zone);

        void Delete(int zoneId);
    }
}
