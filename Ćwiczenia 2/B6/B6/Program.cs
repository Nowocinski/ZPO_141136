using System;

namespace B6
{
    class Program
    {
        static void Main()
        {
            Data data = new Data();
            data.UstawDzień(10);
            data.UstawMiesiąc(6);
            data.UstawRok(1996);
            Console.WriteLine(data.DzieńTygodnia());
            Console.ReadKey();
        }
    }
}
