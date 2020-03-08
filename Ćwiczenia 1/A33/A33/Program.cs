using System;

namespace A33
{
    class Program
    {
        static void Main()
        {
            var licznik = 0;
            var rok = DateTime.UtcNow.Date.Year;
            var miesiąc = DateTime.UtcNow.Date.Month;
            var dni = DateTime.DaysInMonth(rok, miesiąc);

            var pierwszyDzieńMiesiąca = new DateTime(rok, miesiąc, 1);
            var dzieńTygodnia = (int)pierwszyDzieńMiesiąca.DayOfWeek;

            Console.WriteLine($"{"Pn", 5}{"Wt", 5}{"Śr", 5}{"Cz", 5}{"Pt", 5}{"Sb", 5}{"Ni", 5}");

            if (dzieńTygodnia == 0)
            {
                for (var j = 0; j < 6; j++)
                {
                    Console.Write($"{null, 5}");
                }

                Console.WriteLine($"{1, 5}");
                licznik++;
            }
            else
            {
                for (var j = 0; j < dzieńTygodnia - 1; j++)
                {
                    Console.Write($"{null,5}");
                }

                for (var i = 0; i < 8 - dzieńTygodnia; i++)
                {
                    licznik++;
                    Console.Write($"{licznik, 5}");
                }

                Console.WriteLine();
            }

            var nowyTydzień = 0;
            for (var i = licznik + 1; i <= dni; i++)
            {
                Console.Write($"{i, 5}");
                nowyTydzień++;
                if (nowyTydzień == 7)
                {
                    nowyTydzień = 0;
                    Console.WriteLine();
                }
            }

            Console.ReadKey();
        }
    }
}
