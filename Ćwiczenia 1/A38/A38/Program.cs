using System;

namespace A38
{
    class Program
    {
        static void Main()
        {
            Console.Write("Podaj pierwszą liczbę: ");
            int liczba1;
            while (!int.TryParse(Console.ReadLine(), out liczba1))
            {
                Console.Write("Podana wartość nie jest liczbą. Podaj liczbę: ");
            }

            Console.Write("Podaj drugą liczbę: ");
            int liczba2;
            while (!int.TryParse(Console.ReadLine(), out liczba2))
            {
                Console.Write("Podana wartość nie jest liczbą. Podaj liczbę: ");
            }

            try
            {
                var wynik = liczba1 / liczba2;
                Console.WriteLine($"Wynik: {wynik}");
            }
            catch
            {
                Console.WriteLine("Nie można dzielić przez zero.");
            }

            Console.ReadKey();
        }
    }
}
