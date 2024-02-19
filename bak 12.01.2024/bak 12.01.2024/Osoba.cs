using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bak_12._01._2024
{
    public abstract class Osoba
    {
        public string Imie;
        public string Nazwisko;

        protected Osoba(string imie, string nazwisko)
        {
            Imie = imie;
            Nazwisko = nazwisko;
        }
    }
}
