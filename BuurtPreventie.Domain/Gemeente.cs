using System;
using System.Collections.Generic;
using System.Text;

namespace BuurtPreventie.Domain
{
    public class Gemeente
    {
        public int Id { get; set; }

        public int Postcode { get; set; }
        public string Naam { get; set; }

        public ICollection<Zone> Zones { get; set; }
    }
}
