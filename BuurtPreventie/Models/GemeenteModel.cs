using BuurtPreventie.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BuurtPreventie.Models
{
    public class GemeenteModel
    {
        public string Postcode { get; set; }
        public string Naam { get; set; }

        public Gemeente GetGemeente()
        {
            return new Gemeente
            {
                Postcode = int.Parse(Postcode),
                Naam = Naam,
            };
        }
    }
}
