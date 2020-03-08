using System;
using System.Collections.Generic;
using System.Linq;

namespace A19
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Podaj pierwszą liczbę: ");
            int liczba1;
            while (!int.TryParse(Console.ReadLine(), out liczba1))
            {
                Console.Write("Podana wartość nie jest liczbą. Podaj liczbę: ");
            }

            Console.Write("Podaj drugą liczbę: ");
            int liczba2;
            while (!int.TryParse(Console.ReadLine(), out liczba2))
            {
                Console.Write("Podana wartość nie jest liczbą. Podaj liczbę: ");
            }

            Console.Write("Podaj trzecią liczbę: ");
            int liczba3;
            while (!int.TryParse(Console.ReadLine(), out liczba3))
            {
                Console.Write("Podana wartość nie jest liczbą. Podaj liczbę: ");
            }

            var liczby = new List<int>();
            liczby.Add(liczba1);
            liczby.Add(liczba2);
            liczby.Add(liczba3);

            Console.WriteLine($"Min: {liczby.Min()}");
            Console.WriteLine($"Max: {liczby.Max()}");

            Console.ReadKey();
        }
    }
}
