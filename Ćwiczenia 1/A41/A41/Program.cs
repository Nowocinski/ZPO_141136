using System;

namespace A41
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

            if (liczba1 % liczba2 == 0)
            {
                Console.WriteLine($"Liczba {liczba1} jest podzielna przez {liczba2}.");
            }
            else
            {
                Console.WriteLine($"Liczba {liczba1} nie jest podzielna przez {liczba2}.");
            }


            Console.ReadKey();
        }
    }
}
