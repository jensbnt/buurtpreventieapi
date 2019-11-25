using BuurtPreventie.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BuurtPreventie.Models
{
    public class CreateZoneModel
    {
        public string Naam { get; set; }
        public string Beschrijving { get; set; }
        public int GemeenteId { get; set; }

        public Zone ToZone()
        {
            return new Zone
            {
                Naam = Naam,
                Beschrijving = Beschrijving,
                GemeenteId = GemeenteId
            };
        }
    }
}
