using System;
using System.Runtime.CompilerServices;

namespace C1
{
    class Car
    {
        private double pojemonoscSilnika;
        private string marka;
        public static int iloscKol;

        public Car()
        {
            
        }

        public Car(double pojemonoscSilnika, string marka)
        {
            this.pojemonoscSilnika = pojemonoscSilnika;
            this.marka = marka;
        }

        public static Car Create()
        {
            return new Car();
        }

        static Car()
        {
            iloscKol = 4;
        }

        ~Car()
        {
            Console.WriteLine("Zwalniam pamięć");
            Console.ReadKey();
        }
    }
}
