using System;

namespace A31
{
    class Program
    {
        static void Main()
        {
            Console.Write("Podaj długość boku A: ");
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

            Console.Write("Podaj długość boku B: ");
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

            Console.Write("Podaj długość boku B: ");
            double c;
            while (!double.TryParse(Console.ReadLine(), out c) || c <= 0)
            {
                if (c <= 0)
                {
                    Console.Write("Liczba musi być większa od zera. Podaj poprawną liczbę: ");
                    continue;
                }

                Console.Write("Podana wartość nie jest liczbą. Podaj liczbę: ");
            }

            Console.WriteLine($"Pole: {2*a*b + 2*b*c + 2*a*c}");
            Console.WriteLine($"Objętość: {a * b * c}");
            Console.ReadKey();
        }
    }
}
