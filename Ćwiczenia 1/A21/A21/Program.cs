using System;

namespace A21
{
    class Program
    {
        static void Main()
        {
            Console.Write("Podaj wiek: ");
            int wiek;
            while (!int.TryParse(Console.ReadLine(), out wiek))
            {
                Console.Write("Podana wartość nie jest liczbą. Podaj liczbę: ");
            }

            Console.WriteLine($"Wiek: {wiek}");
            Console.ReadKey();
        }
    }
}
