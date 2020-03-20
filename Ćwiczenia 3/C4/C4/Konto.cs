namespace C4
{
    class Konto
    {
        public int saldoPoczątkowe;
        public int saldoKońcowe;
        public int przelewMiedzyKontami;
        public int przelewZewnętrzny;
        public int wplata;
        public int wyplat;

        public Konto()
        {
            
        }

        public Konto(int saldoPoczątkowe, int saldoKońcowe, int przelewMiedzyKontami, int przelewZewnętrzny, int wplata, int wyplat)
        {
            this.saldoPoczątkowe = saldoPoczątkowe;
            this.saldoKońcowe = saldoKońcowe;
            this.przelewMiedzyKontami = przelewMiedzyKontami;
            this.przelewZewnętrzny = przelewZewnętrzny;
            this.wplata = wplata;
            this.wyplat = wyplat;
        }

        public int RóżnicaWpłątIWypłat()
        {
            int różnica = wplata - wyplat;
            if (różnica > 0)
            {
                return różnica;
            }

            return -różnica;
        }

        public void ZmieńSaldoPoczątkowe(int saldoPoczątkowe)
        {
            this.saldoPoczątkowe = saldoPoczątkowe;
        }

        public void WczyczyśćWszystkieDane()
        {
            this.saldoPoczątkowe = 0;
            this.saldoKońcowe = 0;
            this.przelewMiedzyKontami = 0;
            this.przelewZewnętrzny = 0;
            this.wplata = 0;
            this.wyplat = 0;
        }
    }
}
