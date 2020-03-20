using System;

namespace B6
{
    class Data
    {
        private int dzień;
        private int miesiąc;
        private int rok;

        public Data()
        {
            this.dzień = DateTime.Now.Day;
            this.miesiąc = DateTime.Now.Month;
            this.rok = DateTime.Now.Year;
        }

        public void UstawDzień(int dzień)
        {
            bool rokPrzestępny = RokPrzestępny(this.rok);

            if (dzień == 0)
            {
                throw new Exception("Dzień nie może mieć wartości zero.");
            }

            if (dzień < 0)
            {
                throw new Exception("Dzień nie może mieć wartości mniejszej od zero.");
            }

            if(dzień > 31)
            {
                throw new Exception("Dzień nie może mieć wartości większej niż 31.");
            }

            if (dzień > 28 && this.miesiąc == 2 && rokPrzestępny == false)
            {
                throw new Exception($"Luty w roku {this.rok} ma 28 dni.");
            }

            this.dzień = dzień;
        }

        public void UstawMiesiąc(int miesiąc)
        {
            if (miesiąc == 0)
            {
                throw new Exception("Miesiąc nie może mieć wartości zero.");
            }

            if (miesiąc < 0)
            {
                throw new Exception("Miesiąc nie może mieć wartości mniejszej od zero.");
            }

            if (miesiąc > 12)
            {
                throw new Exception("Miesiąc nie może mieć wartości większej niż 12.");
            }

            this.miesiąc = miesiąc;
        }

        public void UstawRok(int rok)
        {
            this.rok = rok;
        }

        public string DzieńTygodnia()
        {
            DateTime dzień;
            string dzieńTygodnia = "";

            try
            {
                dzień = new DateTime(this.rok, this.miesiąc, this.dzień);
            }
            catch
            {
                throw new Exception($"Nie można utworzyć daty: {this.dzień}.{this.miesiąc}.{this.rok}");
            }

            switch (dzień.DayOfWeek)
            {
                case DayOfWeek.Monday:
                    dzieńTygodnia = "Poniedziałek";
                    break;
                case DayOfWeek.Tuesday:
                    dzieńTygodnia = "Wtorek";
                    break;
                case DayOfWeek.Wednesday:
                    dzieńTygodnia = "Środa";
                    break;
                case DayOfWeek.Thursday:
                    dzieńTygodnia = "Czwartek";
                    break;
                case DayOfWeek.Friday:
                    dzieńTygodnia = "Piątek";
                    break;
                default:
                    dzieńTygodnia = "Niedziela";
                    break;
            }

            return dzieńTygodnia;
        }

        private static bool RokPrzestępny(int rok)
        {
            return rok % 4 == 0 && rok % 100 != 0 || rok % 400 == 0;
        }
    }
}
