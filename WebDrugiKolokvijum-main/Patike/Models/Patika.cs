using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Patike.Models
{
    public enum BrendPatika
    {
        Puma,
        Adidas,
        Nike
    }

    public class Patika
    {
        public Patika()
        {

        }
        public Patika(string id, string naziv, string cena, string velicina, BrendPatika brend, string akcija)
        {
            Id = id;
            Naziv = naziv;
            Cena = cena;
            Velicina = velicina;
            Brend = brend;
            Akcija = akcija;
        }

        public String Id { get; set; }
        public String Naziv { get; set; }
        public String Cena { get; set; }
        public String Velicina { get; set; }
        public BrendPatika Brend { get; set; }
        public String Akcija { get; set; }
    }
}