using System;
using System.Collections.Generic;
using System.Text;

namespace BuurtPreventie.Domain
{
    public class Opmerking
    {
        public int Id { get; set; }

        public string Tekst { get; set; }
        public string Gebruiker { get; set; }

        public DateTime Tijd { get; } = DateTime.Now;

        public int ZoneId { get; set; }
        public Zone Zone { get; set; }
    }
}
