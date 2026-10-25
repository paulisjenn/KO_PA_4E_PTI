using System;

namespace NotatkiKonsola
{
    /// <summary>
    /// Klasa Notatka - reprezentuje pojedynczą notatkę tekstową.
    /// pola: licznik (statyczny), id, tytul, tresc
    /// metody: Wyswietl(), Diagnostyka()
    /// autor: Paulina Kozyra
    /// </summary>
    class Notatka
    {
        private static int licznik = 0;
        private int id;
        protected string tytul;
        protected string tresc;

        public Notatka(string tytul, string tresc)
        {
            licznik++;
            id = licznik;
            this.tytul = tytul;
            this.tresc = tresc;
        }

        public void Wyswietl()
        {
            Console.WriteLine($"Tytuł: {tytul}");
            Console.WriteLine($"Treść: {tresc}");
        }

        public void Diagnostyka()
        {
            Console.WriteLine($"id={id}; licznik={licznik}; tytul={tytul}; tresc={tresc}");
        }
    }
}
