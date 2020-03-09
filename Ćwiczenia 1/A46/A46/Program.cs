using System;

namespace A46
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

            if (liczba <= 12 && liczba > 0)
            {
                Console.WriteLine($"Liczba {liczba} może być numerem miesiąca");
            }
            else
            {
                Console.WriteLine($"Liczba {liczba} nie może być numerem miesiąca");
            }

            Console.ReadKey();
        }
    }
}
