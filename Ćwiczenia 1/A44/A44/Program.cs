using System;
using System.Diagnostics.Eventing.Reader;

namespace A44
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("axˆ2 + bx + c = 0");

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

            Console.Write("Podaj wartość c: ");
            double c;
            while (!double.TryParse(Console.ReadLine(), out c))
            {
                Console.Write("Podana wartość nie jest liczbą. Podaj liczbę: ");
            }

            var delta = b*b - 4*a*c;
            if (delta < 0)
            {
                Console.WriteLine("Funkcja nie ma miejsc zerowych.");
            }
            else if (delta == 0)
            {
                Console.WriteLine($"x1: {-b / 2*a}");
            }
            else
            {
                Console.WriteLine($"x1: {-b-Math.Sqrt(delta) / 2*a}");
                Console.WriteLine($"x2: {-b+Math.Sqrt(delta) / 2*a}");
            }

            Console.ReadKey();
        }
    }
}
