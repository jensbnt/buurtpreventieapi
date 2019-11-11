using BuurtPreventie.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuurtPreventie.Data.Repositories.Interfaces
{
    public interface IOpmerkingRepository
    {
        ICollection<Opmerking> GetAll();
        ICollection<Opmerking> GetAllByZoneId(int zoneId);

        Opmerking GetById(int id);

        int Add(Opmerking opmerking);

        void Update(Opmerking opmerking);

        void Delete(int opmerkingId);
    }
}
