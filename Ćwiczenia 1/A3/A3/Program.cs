using System;

namespace A3
{
    class Program
    {
        static void Main()
        {
            Console.Write("Podaj pierwszą liczbę: ");
            double liczba1;
            while (!double.TryParse(Console.ReadLine(), out liczba1))
            {
                Console.Write("Podana wartość nie jest liczbą. Podaj liczbę: ");
            }

            Console.Write("Podaj drugą liczbę: ");
            double liczba2;
            while (!double.TryParse(Console.ReadLine(), out liczba2))
            {
                Console.Write("Podana wartość nie jest liczbą. Podaj liczbę: ");
            }

            if (liczba2 == 0)
            {
                Console.WriteLine($"Operacja niewykonywalna. Nie można dzielić przez zero.");
            }
            else
            {
                Console.WriteLine($"Wynik dzielenia {liczba1} przez {liczba2} to {liczba1 / liczba2}");
            }

            Console.ReadKey();
        }
    }
}
