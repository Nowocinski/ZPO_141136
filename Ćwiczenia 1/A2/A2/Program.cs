using System;

namespace A2
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

            Console.WriteLine($"Suma liczb {liczba1} i {liczba2} to {liczba1+liczba2}");
            Console.ReadKey();
        }
    }
}
