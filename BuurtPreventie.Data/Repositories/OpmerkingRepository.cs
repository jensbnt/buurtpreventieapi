using BuurtPreventie.Data.Repositories.Interfaces;
using BuurtPreventie.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BuurtPreventie.Data.Repositories
{
    public class OpmerkingRepository : IOpmerkingRepository
    {
        private readonly BuurtPreventieContext _context;

        public OpmerkingRepository(BuurtPreventieContext context)
        {
            _context = context;
        }

        public ICollection<Opmerking> GetAll()
        {
            return _context.Opmerkingen
                .OrderBy(o => o.Tijd)
                .ToList();
        }

        public ICollection<Opmerking> GetAllByZoneId(int zoneId)
        {
            return _context.Opmerkingen.Where(z => z.ZoneId == zoneId).ToList();
        }

        public Opmerking GetById(int id)
        {
            return _context.Opmerkingen.Find(id);
        }

        public int Add(Opmerking opmerking)
        {
            _context.Opmerkingen.Add(opmerking);
            _context.SaveChanges();

            return opmerking.Id;
        }

        public void Update(Opmerking opmerking)
        {
            _context.Opmerkingen.Update(opmerking);
            _context.SaveChanges();
        }

        public void Delete(int opmerkingId)
        {
            Opmerking opmerking =  _context.Opmerkingen.Find(opmerkingId);
            _context.Opmerkingen.Update(opmerking);
            _context.SaveChanges();
        }
    }
}
