using BuurtPreventie.Data.Repositories.Interfaces;
using BuurtPreventie.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BuurtPreventie.Data.Repositories
{
    public class GemeenteRepository : IGemeenteRepository
    {
        private readonly BuurtPreventieContext _context;

        public GemeenteRepository(BuurtPreventieContext context)
        {
            _context = context;
        }

        public ICollection<Gemeente> GetAll()
        {
            return _context.Gemeentes.ToList();
        }

        public ICollection<Gemeente> GetAllFiltered(string filter)
        {
            if (filter == null || filter == "")
                return new List<Gemeente>();

            return _context.Gemeentes
                .Where(g => g.Postcode.ToString().Contains(filter) || g.Naam.Contains(filter))
                .Take(7)
                .ToList();
        }

        public Gemeente GetById(int id)
        {
            return _context.Gemeentes.Include(g => g.Zones).First(g => g.Id == id);
        }

        public int Add(Gemeente gemeente)
        {
            _context.Gemeentes.Add(gemeente);
            _context.SaveChanges();

            return gemeente.Id;
        }

        public void Update(Gemeente gemeente)
        {
            _context.Gemeentes.Update(gemeente);
            _context.SaveChanges();
        }

        public void Delete(int postcode)
        {
            Gemeente gemeente = _context.Gemeentes.Find(postcode);
            _context.Gemeentes.Remove(gemeente);
            _context.SaveChanges();
        }
    }
}
