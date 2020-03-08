using System;

namespace A29
{
    class Program
    {
        static void Main()
        {
            Console.Write("Podaj długość boku sześcianu: ");
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

            Console.WriteLine($"Pole: {a * a * a}");
            Console.WriteLine($"Obwód: {6 * a * a}");
            Console.ReadKey();
        }
    }
}
