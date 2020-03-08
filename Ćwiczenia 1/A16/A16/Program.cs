using System;
using System.Collections.Generic;

namespace A16
{
    class Program
    {
        static void Main()
        {
            Console.Write("Wprowadź tekst: ");
            var tekst = Console.ReadLine() + " ";

            var słowa = new List<string>();
            var słowo = "";
            foreach (var znak in tekst)
            {
                if (znak != ' ')
                {
                    słowo += znak;
                }
                else
                {
                    słowa.Add(słowo);
                    słowo = "";
                }
            }

            słowa.Reverse();

            foreach (var słowoZListy in słowa)
            {
                Console.Write($"{słowoZListy} ");
            }

            Console.ReadKey();
        }
    }
}
