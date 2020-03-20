using System;

namespace B1
{
    class Program
    {
        static void Main()
        {
            int czas;
            bool odpowiedz;
            Pies pies = new Pies();
            WlascicielPsa wlascicielPsa = new WlascicielPsa();

            czas = 10;
            pies.UstawCzasPosilku(czas);
            odpowiedz = wlascicielPsa.ZabierzNaSpacer(pies);
            Console.WriteLine($"Pies ostani posiłek jadł {czas}.");
            Console.WriteLine($"Czy właściciel powinien wyprowadzić psa na spracer? {odpowiedz}");

            czas = 4;
            pies.UstawCzasPosilku(czas);
            odpowiedz = wlascicielPsa.ZabierzNaSpacer(pies);
            Console.WriteLine($"Pies ostani posiłek jadł {czas}.");
            Console.WriteLine($"Czy właściciel powinien wyprowadzić psa na spracer? {odpowiedz}");
            Console.ReadKey();
        }
    }

    class Pies
    {
        private int ileGodzinTemuPiesZjadłPosiłek;

        public void UstawCzasPosilku(int czas)
        {
            if (czas < 0)
            {
                throw new Exception("Czas nie może być mniejszy od zera.");
            }

            this.ileGodzinTemuPiesZjadłPosiłek = czas;
        }

        public int PobierzCzasPosilku()
        {
            return this.ileGodzinTemuPiesZjadłPosiłek;
        }

        public bool PotrzebnySpacer()
        {
            return this.ileGodzinTemuPiesZjadłPosiłek > 5;
        }
    }

    class WlascicielPsa
    {
        public bool ZabierzNaSpacer(Pies pies)
        {
            return pies.PotrzebnySpacer();
        }
    }
}
