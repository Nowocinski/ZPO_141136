using System;

namespace A37
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine((DateTime.Now - new DateTime(DateTime.Now.Year, 1, 1)).TotalHours);
            Console.ReadKey();
        }
    }
}
