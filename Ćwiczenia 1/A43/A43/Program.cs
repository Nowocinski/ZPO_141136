using System;

namespace A43
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("ax + b = 0");

            Console.Write("Podaj wartość a: ");
            double a;
            while (!double.TryParse(Console.ReadLine(), out a))
            {
                Console.Write("Podana wartość nie jest liczbą. Podaj liczbę: ");
            }

            Console.Write("Podaj wartość b: ");
            double b;
            while (!double.TryParse(Console.ReadLine(), out b))
            {
                Console.Write("Podana wartość nie jest liczbą. Podaj liczbę: ");
            }

            if (a != 0)
            {
                var x = -b / a;
                Console.WriteLine($"Wynik x: {x}");
            }
            else
            {
                Console.WriteLine("a nie może mieć wartości zero.");
            }

            Console.ReadKey();
        }
    }
}
