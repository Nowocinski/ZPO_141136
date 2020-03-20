namespace C4
{
    class Program
    {
        static void Main()
        {
            Konto konto1 = new Konto();
            Konto konto2 = new Konto();
            Konto konto3 = new Konto();

            konto1.RóżnicaWpłątIWypłat();
            konto2.ZmieńSaldoPoczątkowe(20);
            konto3.WczyczyśćWszystkieDane();
        }
    }
}
