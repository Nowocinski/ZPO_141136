using System;

namespace A53
{
    class Program
    {
        static void Main()
        {
            for (var i = 0; i < 3; i++)
            {
                for (var j = 0; j < 20; j++)
                {
                    Console.Write("P");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
