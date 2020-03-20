using System;

namespace C2
{
    class Matematyka
    {
        public static double pi = 3.14;

        public static double ObliczPoleKoła(double r)
        {
            if (r < 0)
            {
                throw new Exception("Promień koła nie może mieć wartości ujemnej.");
            }

            return pi * r * r;
        }

        public static double ObliczObwódKoła(double r)
        {
            if (r < 0)
            {
                throw new Exception("Promień koła nie może mieć wartości ujemnej.");
            }

            return 2 * pi * r;
        }
    }
}
