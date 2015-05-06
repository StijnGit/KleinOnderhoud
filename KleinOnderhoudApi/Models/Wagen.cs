using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KleinOnderhoudApi.Models
{
    public class Wagen
    {
        public string Merk { get; set; }
        public string Nummerplaat { get; set; }
        public string Bouwjaar { get; set; }
        public string Type { get; set; }
    }
}