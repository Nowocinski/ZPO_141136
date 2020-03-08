using System;

namespace A20
{
    class Program
    {
        static void Main()
        {
            Console.Write("Podaj liczbę: ");
            int liczba;
            while (!int.TryParse(Console.ReadLine(), out liczba) || liczba < 0)
            {
                if (liczba < 0)
                {
                    Console.Write("Liczba nie może być ujemna. Podaj liczbę dodatnią: ");
                    continue;
                }
                Console.Write("Podana wartość nie jest liczbą. Podaj liczbę: ");
            }

            var licznik = liczba;
            for (var i = 0; i < liczba; i++)
            {
                for (var j = 0; j < licznik; j++)
                {
                    Console.Write(liczba);
                }

                Console.WriteLine();
                licznik--;
            }

            Console.ReadKey();
        }
    }
}
