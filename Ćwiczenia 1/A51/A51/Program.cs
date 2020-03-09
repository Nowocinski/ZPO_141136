using System;

namespace A51
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

            if (liczba >= 100 & liczba < 1000)
            {
                Console.WriteLine("Liczba musi składać się z 3 cyfr.");
            }

            if (liczba%10 == liczba/100)
            {
                Console.WriteLine($"Liczba {liczba} jest palindromem.");
            }
            else
            {
                Console.WriteLine($"Liczba {liczba} nie jest palindromem.");
            }

            Console.ReadKey();
        }
    }
}
