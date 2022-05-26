using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Klubovi.Models
{
    public class Klub
    {
        public static int id = 0;
        public int Id { get; set; }
        public string Naziv { get; set; }
        public string Grad { get; set; }
        public bool Aktivan { get; set; }
        public int Bodovi { get; set; }
    }
}