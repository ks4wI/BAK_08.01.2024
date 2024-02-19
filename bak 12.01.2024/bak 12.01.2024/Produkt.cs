using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bak_12._01._2024
{
    public abstract class Produkt : IProdukt
    {
        public string Nazwa;
        public string Opis;
        public int Cena;
        public int Ilosc;

        protected Produkt(string nazwa, string opis, int cena, int ilosc)
        {
            Nazwa = nazwa;
            Opis = opis;
            Cena = cena;
            Ilosc = ilosc;
        }

        public void WyswietlInfo()
        {
            Console.WriteLine($"Nazwa: {Nazwa}, Opis: {Opis}, Cena: {Cena}, Ilość: {Ilosc}");
        }

        public int AktualnaCena()
        {
            return Cena;
        }

        public string OpisProduktu()
        {
            return Opis;
        }

        public int DostepnaIlosc()
        {
            return Ilosc;
        }
    }
}
