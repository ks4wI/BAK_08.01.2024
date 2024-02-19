using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bak_12._01._2024
{
    public class Klient : Osoba
    {
        public List<IProdukt> Koszyk = new List<IProdukt>();

        public Klient(string imie, string nazwisko) : base(imie, nazwisko)
        {
        }

        public void DodajDoKoszyka(IProdukt produkt)
        {
            int ilosc = produkt.DostepnaIlosc();

            if (produkt != null && produkt.DostepnaIlosc() > 0)
            {
                Koszyk.Add(produkt);
                produkt.DostepnaIlosc();
            }
        }

        public int WyswietlCene(IProdukt produkt)
        {
            return produkt.AktualnaCena();
        }

        public int ObliczKosztKoszyka()
        {
            int suma = 0;
            foreach (var produkt in Koszyk)
            {
                suma += produkt.AktualnaCena();
            }
            return suma;
        }
    }
}
