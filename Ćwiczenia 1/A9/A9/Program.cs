using System;

namespace A9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Wprowadź tekst: ");
            var tekst = Console.ReadLine();

            if (tekst.Length < 2)
            {
                Console.WriteLine("Tekst jest za krótki do sprócenia");
            }
            else
            {
                Console.WriteLine(tekst.Remove(1, 1));
            }

            Console.ReadKey();
        }
    }
}
