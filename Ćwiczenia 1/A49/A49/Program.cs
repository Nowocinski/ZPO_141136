using System;

namespace A49
{
    class Program
    {
        static void Main()
        {
            Console.Write("Podaj liczbę (godziny): ");
            int godzina;
            while (!int.TryParse(Console.ReadLine(), out godzina))
            {
                Console.Write("Podana wartość nie jest liczbą całkowitą. Podaj liczbę: ");
            }

            Console.Write("Podaj liczbę (minuty): ");
            int minuta;
            while (!int.TryParse(Console.ReadLine(), out minuta))
            {
                Console.Write("Podana wartość nie jest liczbą całkowitą. Podaj liczbę: ");
            }

            Console.Write("Podaj liczbę (sekundy): ");
            int sekunda;
            while (!int.TryParse(Console.ReadLine(), out sekunda))
            {
                Console.Write("Podana wartość nie jest liczbą całkowitą. Podaj liczbę: ");
            }

            try
            {
                var data = new DateTime(2000, 1, 1, godzina, minuta, sekunda);
                Console.WriteLine($"Można utworzyć czasu {godzina}:{minuta}:{sekunda}.");
            }
            catch
            {
                Console.WriteLine($"Nie można utworzyć czasu {godzina}:{minuta}:{sekunda}.");
            }

            Console.ReadKey();
        }
    }
}
