using System;

namespace B2
{
    class Wycieczka
    {
        private int cena;
        public string kraj;
        private bool allInclusive;
        public int hotelGwiazdki;

        public void ObliczCene()
        {

        }

        protected void WyswietlCene()
        {
            Console.WriteLine($"Cena: {this.cena}");
        }

        public void UstawallInclusive(bool allInclusive)
        {
            this.allInclusive = allInclusive;
        }
    }
}
