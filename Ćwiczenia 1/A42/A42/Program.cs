using System;

namespace A42
{
    class Program
    {
        static void Main()
        {
            Console.Write("Podaj liczbę nr 1: ");
            int liczba1;
            while (!int.TryParse(Console.ReadLine(), out liczba1))
            {
                Console.Write("Podana wartość nie jest liczbą. Podaj liczbę: ");
            }

            Console.Write("Podaj liczbę nr 2: ");
            int liczba2;
            while (!int.TryParse(Console.ReadLine(), out liczba2))
            {
                Console.Write("Podana wartość nie jest liczbą. Podaj liczbę: ");
            }

            Console.Write("Podaj liczbę nr 3: ");
            int liczba3;
            while (!int.TryParse(Console.ReadLine(), out liczba3))
            {
                Console.Write("Podana wartość nie jest liczbą. Podaj liczbę: ");
            }

            var max = liczba1;
            if (liczba2 > max)
            {
                max = liczba2;
            }

            if (liczba3 > max)
            {
                max = liczba3;
            }

            var min = liczba1;
            if (liczba2 < min)
            {
                min = liczba2;
            }

            if (liczba3 < min)
            {
                min = liczba3;
            }

            int wartośćŚrodkowa;
            if (liczba2 < liczba1 && liczba2 > liczba3 || liczba2 > liczba1 && liczba2 < liczba3)
            {
                wartośćŚrodkowa = liczba2;
            }

            else if (liczba1 < liczba3 && liczba1 > liczba2 || liczba1 > liczba3 && liczba1 < liczba2)
            {
                wartośćŚrodkowa = liczba1;
            }

            else
            {
                wartośćŚrodkowa = 3;
            }

            Console.WriteLine($"{max}, {wartośćŚrodkowa}, {min}");
            Console.ReadKey();
        }
    }
}
