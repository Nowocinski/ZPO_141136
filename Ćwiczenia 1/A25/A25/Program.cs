using System;

namespace A25
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

            Console.Write("Podaj długość drugiego boku: ");
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

            Console.Write("Podaj długość trzeciego boku: ");
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

            if (a + b < c || a + c < b || b + c < a)
            {
                Console.WriteLine($"Dla boków o długości {a}, {b} i {c} nie można utworzyć trójkąta");
            }
            else
            {
                Console.WriteLine($"Pole: {Math.Sqrt((a + b + c) * (a + b - c) * (a - b + c) * (-a + b + c)) / 4}");
                Console.WriteLine($"Obwód: {a + b + c}");
            }

            Console.ReadKey();
        }
    }
}
