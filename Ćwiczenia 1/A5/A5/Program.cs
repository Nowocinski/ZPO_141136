using System;

namespace A5
{
    class Program
    {
        static void Main()
        {
            Console.Write("Podaj pierwszą liczbę: ");
            int liczba1;
            while (!int.TryParse(Console.ReadLine(), out liczba1))
            {
                Console.Write("Podana wartość nie jest liczbą całkowitą. Podaj liczbę: ");
            }

            Console.Write("Podaj drugą liczbę: ");
            int liczba2;
            while (!int.TryParse(Console.ReadLine(), out liczba2))
            {
                Console.Write("Podana wartość nie jest liczbą całkowitą. Podaj liczbę: ");
            }

            Console.Write("Podaj trzecią liczbę: ");
            int liczba3;
            while (!int.TryParse(Console.ReadLine(), out liczba3))
            {
                Console.Write("Podana wartość nie jest liczbą całkowitą. Podaj liczbę: ");
            }

            Console.WriteLine($"Wynik mnożenia liczb {liczba1}, {liczba2}, {liczba3} to {liczba1 * liczba2 * liczba3}");
            Console.ReadKey();
        }
    }
}
