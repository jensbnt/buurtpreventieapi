using BuurtPreventie.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BuurtPreventie.Models
{
    public class CreateOpmerkingModel
    {
        public string Tekst { get; set; }
        public string Gebruiker { get; set; }
        public int ZoneId { get; set; }

        public Opmerking ToOpmerking()
        {
            return new Opmerking
            {
                Tekst = Tekst,
                Gebruiker = Gebruiker,
                Tijd = DateTime.Now,
                ZoneId = ZoneId
            };
        }
    }
}
