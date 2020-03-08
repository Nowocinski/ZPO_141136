using System;

namespace A7
{
    class Program
    {
        static void Main()
        {
            Console.Write("Podaj pierwszą liczbę: ");
            double liczba1;
            while (!double.TryParse(Console.ReadLine(), out liczba1))
            {
                Console.Write("Podana wartość nie jest liczbą. Podaj liczbę: ");
            }

            Console.Write("Podaj drugą liczbę: ");
            double liczba2;
            while (!double.TryParse(Console.ReadLine(), out liczba2))
            {
                Console.Write("Podana wartość nie jest liczbą. Podaj liczbę: ");
            }

            Console.Write("Podaj trzecią liczbę: ");
            double liczba3;
            while (!double.TryParse(Console.ReadLine(), out liczba3))
            {
                Console.Write("Podana wartość nie jest liczbą. Podaj liczbę: ");
            }

            Console.WriteLine($"Średnia arytemtyczna: {(liczba1 + liczba2 + liczba3)/3}");
            Console.WriteLine($"Średnia geometryczna: {Math.Pow(liczba1 * liczba2 * liczba3, 1.0/3.0)}");
            Console.ReadKey();
        }
    }
}
