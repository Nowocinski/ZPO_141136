using System;
using System.Runtime.InteropServices;

namespace A45
{
    class Program
    {
        static void Main()
        {
            Console.Write("Podaj liczbę: ");
            int liczba;
            while (!int.TryParse(Console.ReadLine(), out liczba))
            {
                Console.Write("Podana wartość nie jest liczbą całkowitą. Podaj liczbę: ");
            }

            if (liczba <= 31 && liczba > 0)
            {
                Console.WriteLine($"Liczba {liczba} może być dniem miesiąca");
            }
            else
            {
                Console.WriteLine($"Liczba {liczba} nie może być dniem miesiąca");
            }

            Console.ReadKey();
        }
    }
}
