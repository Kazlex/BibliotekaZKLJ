using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotekaZKLJ
{
    public static class Clanovi
    {
        public static string Ime { get; set; } = string.Empty;

        public static string Prezime { get; set; } = string.Empty;

        public static string Mail { get; set; } = string.Empty;
    }

    public static class Knige
    {
        public static string Naziv { get; set; } = string.Empty;

        public static string Zanr { get; set; } = string.Empty;

        public static DateTime Vreme { get; set; } = DateTime.Now;

    }
}
