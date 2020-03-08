using System;

namespace A32
{
    class Program
    {
        static void Main()
        {
            Console.Write("Podaj długość podstawy: ");
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

            Console.Write("Podaj długość wysokości: ");
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

            var l = Math.Sqrt(h * h + r + r);

            Console.WriteLine($"Pole: {Math.PI * r * r + Math.PI * r * l}");
            Console.WriteLine($"Objętość: {1.0/3.0 * Math.PI * r*r * h}");
            Console.ReadKey();
        }
    }
}
