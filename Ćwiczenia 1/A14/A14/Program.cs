using System;

namespace A14
{
    class Program
    {
        static void Main()
        {
            int suma = 0;
            int licznik = 0;
            int liczba = 1;

            while (licznik <= 100)
            {
                bool istniejeDzielnik = false;
                for (var i = 1; i < liczba; i++)
                {
                    if (i != liczba && i != 1 && liczba%i == 0)
                    {
                        istniejeDzielnik = true;
                        break;
                    }
                }

                if (istniejeDzielnik == false)
                {
                    suma += liczba;
                    licznik++;
                }

                liczba++;
            }

            Console.WriteLine($"Suma 100 pierwszych liczb pierwszych: {suma}");
            Console.ReadKey();
        }
    }
}
