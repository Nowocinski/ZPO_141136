using System;

namespace A24
{
    class Program
    {
        static void Main()
        {
            Console.Write("Podaj wielkość kontową: ");
            double liczba;
            while (!double.TryParse(Console.ReadLine(), out liczba))
            {
                Console.Write("Podana wartość nie jest liczbą. Podaj liczbę: ");
            }

            Console.WriteLine($"Wartość w radianach: {(Math.PI / 180) * liczba}");
            Console.ReadKey();
        }
    }
}
