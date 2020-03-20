namespace B4
{
    class Liczba
    {
        public int wartosc = 0;

        public void Dodaj(int wartosc)
        {
            this.wartosc = this.wartosc + wartosc;
        }

        public void Odejmij(int wartosc)
        {
            this.wartosc = this.wartosc - wartosc;
        }
    }
}
