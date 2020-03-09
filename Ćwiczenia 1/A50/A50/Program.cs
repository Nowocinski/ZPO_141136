using System;

namespace A50
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
                Console.Write($"{dni}-{miesiąc}-{rok} to ");

                switch (data.DayOfWeek)
                {
                    case DayOfWeek.Monday:
                        Console.WriteLine("poniedziałek");
                        break;
                    case DayOfWeek.Tuesday:
                        Console.WriteLine("wtorek");
                        break;
                    case DayOfWeek.Wednesday:
                        Console.WriteLine("środa");
                        break;
                    case DayOfWeek.Thursday:
                        Console.WriteLine("czwartek");
                        break;
                    case DayOfWeek.Friday:
                        Console.WriteLine("piątek");
                        break;
                    case DayOfWeek.Saturday:
                        Console.WriteLine("sobota");
                        break;
                    case DayOfWeek.Sunday:
                        Console.WriteLine("Niedziela");
                        break;
                }
            }
            catch
            {
                Console.WriteLine($"Nie można utworzyć datę {dni}-{miesiąc}-{rok}.");
            }

            Console.ReadKey();
        }
    }
}
