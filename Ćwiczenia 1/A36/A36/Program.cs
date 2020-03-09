using System;

namespace A36
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine((DateTime.Now - new DateTime(DateTime.Now.Year, 1, 1)).TotalDays);
            Console.ReadKey();
        }
    }
}
