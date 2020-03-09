using System;

namespace A34
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine((DateTime.Now - new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day)).TotalSeconds);
            Console.ReadKey();
        }
    }
}
