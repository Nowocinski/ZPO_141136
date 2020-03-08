using System;

namespace A8
{
    class Program
    {
        static void Main()
        {
            Console.Write("Podaj temperaturę w stopniach °C: ");
            double temperaturaC;
            while (!double.TryParse(Console.ReadLine(), out temperaturaC))
            {
                Console.Write("Podana wartość nie jest liczbą. Podaj liczbę: ");
            }

            Console.WriteLine($"°K: {temperaturaC + 273.15}");
            Console.WriteLine($"°F: {32 + 9.0/5.0 * temperaturaC}");
            Console.ReadKey();
        }
    }
}
