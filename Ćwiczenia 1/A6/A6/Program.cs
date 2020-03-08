using System;

namespace A6
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine($"{'x', 5}{0, 5}{1, 5}{2, 5}{3, 5}{4, 5}{5, 5}");
            for (var i = 0; i <= 5; i++)
            {
                Console.Write($"{i, 5}");

                for (var j = 0; j <= 5; j++)
                {
                    Console.Write($"{i*j, 5}");
                }

                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
