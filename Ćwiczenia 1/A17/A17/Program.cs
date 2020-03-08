using System;

namespace A17
{
    class Program
    {
        static void Main()
        {
            Console.Write("Podaj liczbę w systemie szesnastkowym: ");
            var tekst = Console.ReadLine();

            try
            {
                Console.WriteLine($"Liczba {tekst} w systemie dziesiętnym to {Convert.ToInt32(tekst, 16)}");
            }
            catch
            {
                Console.WriteLine($"Nie można zamienić liczby {tekst} na system dziesiętny");
            }

            Console.ReadKey();
        }
    }
}
