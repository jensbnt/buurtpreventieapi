using BuurtPreventie.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuurtPreventie.Data.Repositories.Interfaces
{
    public interface IGemeenteRepository
    {
        ICollection<Gemeente> GetAll();
        ICollection<Gemeente> GetAllFiltered(string filter);

        Gemeente GetById(int id);

        int Add(Gemeente gemeente);

        void Update(Gemeente gemeente);

        void Delete(int postcode);
    }
}
