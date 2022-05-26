using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace parfemi.Models
{
    public class Parfem
    {
        public Parfem()
        {

        }
        public string Id { get; set; }
        public string Naziv { get; set; }
        public MirisnaNota Nota { get; set; }
        public int Cena { get; set; }
        public bool Akcija { get; set; }
    }
}