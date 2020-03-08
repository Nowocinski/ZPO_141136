using System;

namespace A15
{
    class Program
    {
        static void Main()
        {
            var suma = 0;

            Console.Write("Podaj liczbę: ");
            int liczba;
            
            while (!int.TryParse(Console.ReadLine(), out liczba))
            {
                Console.Write("Podana wartość nie jest liczbą. Podaj liczbę: ");
            }

            int licznaKopia = liczba;

            while (true)
            {
                suma += liczba%10;

                if (liczba < 10)
                {
                    break;
                }

                liczba /= 10;
            }

            Console.WriteLine($"Suma cyfr liczby {licznaKopia} to {suma}");
            Console.ReadKey();
        }
    }
}
