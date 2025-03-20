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
            // Wyświetlenie liczby zarejestrowanych osób
            Console.WriteLine($"Liczba zarejestrowanych osób to {Osoba.LiczbaInstancji}");

            // Tworzenie instancji klasy Osoba za pomocą konstruktora bezparametrowego
            Osoba osoba1 = new Osoba();

            // Tworzenie instancji klasy Osoba za pomocą konstruktora z dwoma parametrami
            Console.Write("Wprowadź id: ");
            int id = int.Parse(Console.ReadLine());
            Console.Write("Wprowadź imię: ");
            string imie = Console.ReadLine();
            Osoba osoba2 = new Osoba(id, imie);

            // Tworzenie instancji klasy Osoba za pomocą konstruktora kopiującego
            Osoba osoba3 = new Osoba(osoba2);

            // Wywołanie metody do wypisania imienia z parametrem "Jan" dla wszystkich utworzonych obiektów
            osoba1.WypiszImie("Jan");
            osoba2.WypiszImie("Jan");
            osoba3.WypiszImie("Jan");

            // Ponowne wyświetlenie liczby zarejestrowanych osób
            Console.WriteLine($"Liczba zarejestrowanych osób to {Osoba.LiczbaInstancji}");
        }
    }
}
