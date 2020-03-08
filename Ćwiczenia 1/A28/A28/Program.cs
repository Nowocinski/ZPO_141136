using System;

namespace A28
{
    class Program
    {
        static void Main()
        {
            Console.Write("Podaj promień kuli: ");
            double R;
            while (!double.TryParse(Console.ReadLine(), out R) || R <= 0)
            {
                if (R <= 0)
                {
                    Console.Write("Liczba musi być większa od zera. Podaj poprawną liczbę: ");
                    continue;
                }

                Console.Write("Podana wartość nie jest liczbą. Podaj liczbę: ");
            }

            Console.WriteLine($"Pole: {4 * Math.PI * R * R}");
            Console.WriteLine($"Objętość: {4.0/3.0 * Math.PI * R * R * R}");
            Console.ReadKey();
        }
    }
}
