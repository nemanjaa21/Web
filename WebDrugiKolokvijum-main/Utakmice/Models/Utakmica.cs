using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Utakmice.Models
{
    public enum Liga
    { 
         EVROPA,
         SRBIJA,
         SPANIJA
    
    }
    public enum Pobednik
    {
        DOMACIN,
        GOST,
        NERESENO

    }
    public class Utakmica
    {
        public Utakmica()
        {

        }
        public Utakmica(string id, string domacin, string gost, Liga liga, Pobednik pobednik)
        {
            Id = id;
            Domacin = domacin;
            Gost = gost;
            Liga = liga;
            Pobednik = pobednik;
        }

        public String Id { get; set; }
        public String Domacin { get; set; }
        public String Gost { get; set; }
        public Liga Liga { get; set; }
        public Pobednik Pobednik { get; set; }

    }
}