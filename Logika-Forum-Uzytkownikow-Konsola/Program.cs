using System;

namespace LogikaForumUzytkownikowKonsola
{
    /// <summary>
    /// Klasa reprezentująca osobę w systemie forum użytkowników.
    /// </summary>
    public class Osoba
    {
        // Prywatne pola
        private int id;
        private string imie;

        /// <summary>
        /// Statyczne pole zliczające liczbę instancji klasy Osoba.
        /// </summary>
        public static int LiczbaInstancji { get; private set; } = 0;

        /// <summary>
        /// Konstruktor bezparametrowy, ustawia wartości domyślne dla pól.
        /// </summary>
        public Osoba()
        {
            id = 0;
            imie = string.Empty;
            LiczbaInstancji++;
        }

        /// <summary>
        /// Konstruktor z dwoma parametrami, ustawia wartości dla pól id i imie.
        /// </summary>
        /// <param name="id">Identyfikator osoby.</param>
        /// <param name="imie">Imię osoby.</param>
        public Osoba(int id, string imie)
        {
            this.id = id;
            this.imie = imie;
            LiczbaInstancji++;
        }

        /// <summary>
        /// Konstruktor kopiujący, tworzy nową instancję na podstawie innej instancji klasy Osoba.
        /// </summary>
        /// <param name="innaOsoba">Inna instancja klasy Osoba.</param>
        public Osoba(Osoba innaOsoba)
        {
            this.id = innaOsoba.id;
            this.imie = innaOsoba.imie;
            LiczbaInstancji++;
        }

        /// <summary>
        /// Metoda do wypisania imienia obiektu klasy Osoba.
        /// </summary>
        /// <param name="inneImie">Imię osoby, do której kierowany jest komunikat.</param>
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
            // Tworzenie instancji klasy Osoba
            Osoba osoba1 = new Osoba();
            Osoba osoba2 = new Osoba(1, "Jan");
            Osoba osoba3 = new Osoba(osoba2);

            // Wypisywanie imion
            osoba1.WypiszImie("Adam");
            osoba2.WypiszImie("Ewa");
            osoba3.WypiszImie("Kasia");

            // Wypisywanie liczby instancji klasy Osoba
            Console.WriteLine($"Liczba instancji klasy Osoba: {Osoba.LiczbaInstancji}");
        }
    }
}
