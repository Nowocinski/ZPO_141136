namespace B2
{
    class Program
    {
        static void Main()
        {
            Wycieczka w1 = new Wycieczka();
            Wycieczka w2 = new Wycieczka();
            Wycieczka w3 = new Wycieczka();

            w1.ObliczCene();
            w1.kraj = "Polska";

            w2.ObliczCene();
            w2.hotelGwiazdki = 5;

            // Wykonanie metody z przypisaniem wartości do pola wewnątrz metody
            w3.UstawallInclusive(true);
        }
    }
}
