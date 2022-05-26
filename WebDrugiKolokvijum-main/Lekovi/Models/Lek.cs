using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lekovi.Models
{
    public enum VrstaLeka
    { 
        Prirodni,
        Laboratorijski,
        Placebo
    }
    public class Lek
    {
        public Lek()
        {

        }
        public Lek(string id, string naziv, int cena, string godina, VrstaLeka vrstaLeka, string naAkciji)
        {
            Id = id;
            Naziv = naziv;
            Cena = cena;
            Godina = godina;
            VrstaLeka = vrstaLeka;
            NaAkciji = naAkciji;
        }

        public String Id { get; set; }
        public String Naziv { get; set; }
        public int Cena { get; set; }
        public String Godina { get; set; }
        public VrstaLeka VrstaLeka { get; set; }
        public String NaAkciji { get; set; }
    }
}