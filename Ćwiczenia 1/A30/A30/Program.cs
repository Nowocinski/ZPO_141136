using System;

namespace A30
{
    class Program
    {
        static void Main()
        {
            Console.Write("Podaj promień podstawy: ");
            double r;
            while (!double.TryParse(Console.ReadLine(), out r) || r <= 0)
            {
                if (r <= 0)
                {
                    Console.Write("Liczba musi być większa od zera. Podaj poprawną liczbę: ");
                    continue;
                }

                Console.Write("Podana wartość nie jest liczbą. Podaj liczbę: ");
            }

            Console.Write("Podaj wysokość: ");
            double h;
            while (!double.TryParse(Console.ReadLine(), out h) || h <= 0)
            {
                if (h <= 0)
                {
                    Console.Write("Liczba musi być większa od zera. Podaj poprawną liczbę: ");
                    continue;
                }

                Console.Write("Podana wartość nie jest liczbą. Podaj liczbę: ");
            }

            Console.WriteLine($"Pole: {2 * (Math.PI * r * 4) + (2 * Math.PI * r * h)}");
            Console.WriteLine($"Objętość: {Math.PI * r * r * h}");
            Console.ReadKey();
        }
    }
}
