using System;
using System.Collections.Generic;
using System.Text;

namespace BuurtPreventie.Domain
{
    public class Zone
    {
        public int Id { get; set; }

        public string Naam { get; set; }
        public string Beschrijving { get; set; }

        public int GemeenteId { get; set; }
        public Gemeente Gemeente { get; set; }

        public ICollection<Opmerking> Opmerkingen { get; set; }
    }
}
