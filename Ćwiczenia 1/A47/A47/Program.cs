using System;

namespace A47
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

            if (liczba % 4 == 0 && liczba % 100 != 0 || liczba % 400 == 0)
            {
                Console.WriteLine("Podany liczba może być rokiem przestepny.");
            }
            else
            {
                Console.WriteLine("Podany liczba nie może być rokiem przestepny.");
            }

            Console.ReadKey();
        }
    }
}
