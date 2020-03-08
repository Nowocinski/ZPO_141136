using System;

namespace A12
{
    class Program
    {
        static void Main()
        {
            Console.Write("Wprowadź tekst: ");
            var tekst = Console.ReadLine() + " ";

            string najdłuższeSłowo = "";
            var słowo = "";

            for (var i = 0; i < tekst.Length; i++)
            {
                var znak = tekst[i];
                if (znak != ' ')
                {
                    słowo += znak;
                }
                else
                {
                    if (słowo.Length > najdłuższeSłowo.Length)
                    {
                        najdłuższeSłowo = słowo;
                        słowo = "";
                    }
                }
            }

            Console.WriteLine($"Najdłuższe słowo to: {najdłuższeSłowo}");
            Console.ReadKey();
        }
    }
}
