using bak_12._01._2024;

public class Program1
{
    private static Klient klient = new Klient("wojciu", "urbanski");

    public static void Main(string[] args)
    {
        while(true)
        {
            Console.WriteLine("wybierz opcje: ");
            Console.WriteLine("1. dodaj spodnie do koszyka");
            Console.WriteLine("2. dodaj kurtke do koszyka");
            Console.WriteLine("3. dodaj majtki do koszyka");
            Console.WriteLine("4. dodaj czapke do koszyka");
            Console.WriteLine("5. dodaj okulary do koszyka");
            Console.WriteLine("6. dodaj okulary do koszyka");
            Console.WriteLine("7. wyswietl cene koszyka");
            Console.WriteLine("8. wyjscie");
            string wybor = Console.ReadLine();

            switch (wybor)
            {
                case "1":
                    klient.DodajDoKoszyka(new Ksiazka("harry potter", "bardzo fajna ksiazka, ciekawa i wciagajaca", 30, 15));
                    Console.WriteLine("dodano ksiazke do koszyka.\n ");
                    break;
                case "2":
                    klient.DodajDoKoszyka(new Ksiazka("ania z zielonego wzgorza", "bardzo slaba ksiazka, ktora jest slaba", 20, 50));
                    Console.WriteLine("dodano ksiazke do koszyka.\n ");
                    break;
                case "3":
                    klient.DodajDoKoszyka(new Elektronika("nvidia rtx 4070ti", "karta graficzna", 5000, 5));
                    Console.WriteLine("dodano elektronike do koszyka.\n ");
                    break;
                case "4":
                    klient.DodajDoKoszyka(new Elektronika("intel core i7 13gen", "procesor", 3000, 10));
                    Console.WriteLine("dodano elektronike do koszyka.\n ");
                    break;
                case "5":
                    klient.DodajDoKoszyka(new Odziez("bluza", "dobrej jakosci bluza niebieska", 100, 70));
                    Console.WriteLine("dodano odziez do koszyka.\n ");
                    break;
                case "6":
                    klient.DodajDoKoszyka(new Odziez("kurtka", "slabej jakosci czarna kurtka", 700, 20));
                    Console.WriteLine("dodano odziez do koszyka.\n ");
                    break;
                case "7":
                    Console.WriteLine("wyswietl cene koszyka: " + klient.ObliczKosztKoszyka() + " zl\n");
                    break;
                case "8":
                    Console.WriteLine("wyjscie\n"); Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("podaj prawidlowa opcje\n");
                    break;
            }
        }
    }
}
public interface IProdukt
{
    void WyswietlInfo();
    int AktualnaCena();
    int DostepnaIlosc();
}
