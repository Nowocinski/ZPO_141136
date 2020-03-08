using System;

namespace A11
{
    class Program
    {
        static void Main()
        {
            Console.Write("Wprowadź tekst: ");
            var tekst = Console.ReadLine();

            Console.WriteLine(tekst.ToUpper());

            Console.ReadKey();
        }
    }
}
