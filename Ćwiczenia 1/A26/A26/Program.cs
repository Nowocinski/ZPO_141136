using System;

namespace A26
{
    class Program
    {
        static void Main()
        {
            Console.Write("Podaj długość pierwszego boku A: ");
            double a;
            while (!double.TryParse(Console.ReadLine(), out a) || a <= 0)
            {
                if (a <= 0)
                {
                    Console.Write("Liczba musi być większa od zera. Podaj poprawną liczbę: ");
                    continue;
                }

                Console.Write("Podana wartość nie jest liczbą. Podaj liczbę: ");
            }

            Console.Write("Podaj długość pierwszego boku B: ");
            double b;
            while (!double.TryParse(Console.ReadLine(), out b) || b <= 0)
            {
                if (b <= 0)
                {
                    Console.Write("Liczba musi być większa od zera. Podaj poprawną liczbę: ");
                    continue;
                }

                Console.Write("Podana wartość nie jest liczbą. Podaj liczbę: ");
            }

            Console.WriteLine($"Pole: {a*b}");
            Console.WriteLine($"Obwód: {a*2 + b*2}");
            Console.ReadKey();
        }
    }
}
