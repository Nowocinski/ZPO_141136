namespace C3
{
    class Program
    {
        static void Main()
        {
            OpiszTyp();
            OpiszTyp(2);
            OpiszTyp("Test");
            OpiszTyp(2, 5);
        }

        static string OpiszTyp()
        {
            return "Metoda bez argumentów";
        }

        static string OpiszTyp(int x)
        {
            return "Liczba całkowita";
        }

        static string OpiszTyp(string x)
        {
            return "Łańcuch znaków";
        }

        static string OpiszTyp(int x, int y)
        {
            return "Dwie liczby calkowite";
        }
    }
}
