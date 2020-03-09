using System;

namespace A48
{
    class Program
    {
        static void Main()
        {
            Console.Write("Podaj liczbę (dni): ");
            int dni;
            while (!int.TryParse(Console.ReadLine(), out dni))
            {
                Console.Write("Podana wartość nie jest liczbą całkowitą. Podaj liczbę: ");
            }

            Console.Write("Podaj liczbę (miesiąc): ");
            int miesiąc;
            while (!int.TryParse(Console.ReadLine(), out miesiąc))
            {
                Console.Write("Podana wartość nie jest liczbą całkowitą. Podaj liczbę: ");
            }

            Console.Write("Podaj liczbę (rok): ");
            int rok;
            while (!int.TryParse(Console.ReadLine(), out rok))
            {
                Console.Write("Podana wartość nie jest liczbą całkowitą. Podaj liczbę: ");
            }

            try
            {
                var data = new DateTime(rok, miesiąc, dni);
                Console.WriteLine($"Można utworzyć daty {dni}-{miesiąc}-{rok}.");
            }
            catch
            {
                Console.WriteLine($"Nie można utworzyć datę {dni}-{miesiąc}-{rok}.");
            }

            Console.ReadKey();
        }
    }
}
