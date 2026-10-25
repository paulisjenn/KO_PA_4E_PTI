using System;

namespace NotatkiKonsola
{
    class Program
    {
        static void Main(string[] args)
        {
            Notatka notatka1 = new Notatka("Zadanie domowe", "Dokończyć projekt z informatyki");
            Notatka notatka2 = new Notatka("Zakupy", "Kupić mleko i chleb");

            Console.WriteLine("=== Notatka 1 ===");
            notatka1.Wyswietl();
            notatka1.Diagnostyka();

            Console.WriteLine();

            Console.WriteLine("=== Notatka 2 ===");
            notatka2.Wyswietl();
            notatka2.Diagnostyka();

            Console.ReadKey();
        }
    }
}