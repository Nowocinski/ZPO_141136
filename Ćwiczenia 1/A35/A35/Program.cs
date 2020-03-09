using System;

namespace A35
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine((DateTime.Now - new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day)).TotalMinutes);
            Console.ReadKey();
        }
    }
}
