using System;
using System.Linq;

namespace A10
{
    class Program
    {
        static void Main()
        {
            Console.Write("Wprowadź tekst: ");
            var tekst = Console.ReadLine();

            if (tekst.Length < 2)
            {
                Console.WriteLine("Tekst jest za krótki");
            }
            else
            {
                var pierwszyZnak = tekst.First();
                var ostatniZnak = tekst.Last();
                tekst = tekst.Remove(0, 1);
                tekst = tekst.Remove(tekst.Length - 1, 1);
                Console.WriteLine($"{ostatniZnak}{tekst}{pierwszyZnak}");
            }

            Console.ReadKey();
        }
    }
}
