using System;
using System.Collections.Generic;
using System.Linq;

namespace A18
{
    class Program
    {
        static void Main()
        {
            var vektor1 = new List<int>();
            var vektor2 = new List<int>();
            int liczba;

            Console.WriteLine("Podaj wartości pierwszego wektora używając entera (aby zakończyć podaj wartość, która nie jest liczbą):");
            while (int.TryParse(Console.ReadLine(), out liczba))
            {
                vektor1.Add(liczba);
            }

            Console.WriteLine("Podaj wartości drugiego wektora używając entera (aby zakończyć podaj wartość, która nie jest liczbą):");
            while (int.TryParse(Console.ReadLine(), out liczba))
            {
                vektor2.Add(liczba);
            }

            if (vektor1.Count != vektor2.Count)
            {
                Console.WriteLine("Wektory mają różną długość. Nie można policzyć iloczynu skalarnego.");
            }

            Console.WriteLine($"Iloczyn skalarny: {vektor1.Select((t, i) => t * vektor2[i]).Sum()}");
            Console.ReadKey();
        }
    }
}
