using System;

namespace A27
{
    class Program
    {
        static void Main()
        {
            Console.Write("Podaj długość pierwszego boku: ");
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

            Console.WriteLine($"Pole: {a * a}");
            Console.WriteLine($"Obwód: {a * 4}");
            Console.ReadKey();
        }
    }
}
