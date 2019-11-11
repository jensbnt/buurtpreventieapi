using BuurtPreventie.Data.Repositories.Interfaces;
using BuurtPreventie.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BuurtPreventie.Data.Repositories
{
    public class ZoneRepository : IZoneRepository
    {
        private readonly BuurtPreventieContext _context;

        public ZoneRepository(BuurtPreventieContext context)
        {
            _context = context;
        }

        public ICollection<Zone> GetAll()
        {
            return _context.Zones.ToList();
        }

        public ICollection<Zone> GetAllByGemeenteId(int gemeenteId)
        {
            return _context.Zones.Where(z => z.GemeenteId == gemeenteId).ToList();
        }

        public Zone GetById(int id)
        {
            return _context.Zones.Include(z => z.Opmerkingen).First(z => z.Id == id);
        }

        public int Add(Zone zone)
        {
            _context.Zones.Add(zone);
            _context.SaveChanges();

            return zone.Id;
        }

        public void Update(Zone zone)
        {
            _context.Zones.Update(zone);
            _context.SaveChanges();
        }

        public void Delete(int zoneId)
        {
            Zone zone = _context.Zones.Find(zoneId);
            _context.Zones.Add(zone);
            _context.SaveChanges();
        }
    }
}
