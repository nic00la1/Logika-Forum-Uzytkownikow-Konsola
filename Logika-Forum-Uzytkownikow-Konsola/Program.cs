using System;

namespace LogikaForumUzytkownikowKonsola
{
    public class Osoba
    {
        private int id;
        private string imie;
        public static int LiczbaInstancji { get; private set; } = 0;

        // Konstruktor bezparametrowy
        public Osoba()
        {
            id = 0;
            imie = string.Empty;
            LiczbaInstancji++;
        }

        // Konstruktor z dwoma parametrami
        public Osoba(int id, string imie)
        {
            this.id = id;
            this.imie = imie;
            LiczbaInstancji++;
        }

        // Konstruktor kopiujący
        public Osoba(Osoba innaOsoba)
        {
            this.id = innaOsoba.id;
            this.imie = innaOsoba.imie;
            LiczbaInstancji++;
        }

        // Metoda do wypisania imienia
        public void WypiszImie(string inneImie)
        {
            if (string.IsNullOrEmpty(imie))
            {
                Console.WriteLine("Brak danych");
            }
            else
            {
                Console.WriteLine($"Cześć {inneImie}, mam na imię {imie}");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Osoba osoba1 = new Osoba();
            Osoba osoba2 = new Osoba(1, "Jan");
            Osoba osoba3 = new Osoba(osoba2);

            osoba1.WypiszImie("Adam");
            osoba2.WypiszImie("Ewa");
            osoba3.WypiszImie("Kasia");

            Console.WriteLine($"Liczba instancji klasy Osoba: {Osoba.LiczbaInstancji}");
        }
    }
}
