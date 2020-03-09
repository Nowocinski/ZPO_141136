using System;

namespace A54
{
    class Program
    {
        static void Main()
        {
            Console.Write("Podaj liczbę: ");
            int liczba;
            while (!int.TryParse(Console.ReadLine(), out liczba))
            {
                Console.Write("Podana wartość nie jest liczbą całkowitą. Podaj liczbę: ");
            }

            var i = 0;
            while (i <= liczba)
            {
                for (var j = 1; j <= i; j++)
                {
                    Console.Write($"{j, 2}");
                }
                i++;
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
