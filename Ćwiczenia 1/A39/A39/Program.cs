using System;

namespace A39
{
    class Program
    {
        static void Main()
        {
            Console.Write("Podaj liczbę: ");
            double liczba;
            while (!double.TryParse(Console.ReadLine(), out liczba))
            {
                Console.Write("Podana wartość nie jest liczbą. Podaj liczbę: ");
            }

            if (liczba < 0)
            {
                Console.WriteLine("Nie można pierwiastkować liczb ujemnych.");
            }
            else
            {
                var wynik = Math.Sqrt(liczba);
                Console.WriteLine($"Wynik: {wynik}");
            }

            Console.ReadKey();
        }
    }
}
