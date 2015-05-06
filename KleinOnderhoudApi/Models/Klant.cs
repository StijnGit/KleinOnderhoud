using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KleinOnderhoudApi.Models
{
    public class Klant
    {
        public int Id { get; set; }
        public string Naam { get; set; }
        public string Voornaam { get; set; }
        public List<Wagen> lstWagen { get; set; }

        public Klant(string naam, string voornaam)
        {
            this.Naam = naam;
            this.Voornaam = voornaam;
        }
    }
}