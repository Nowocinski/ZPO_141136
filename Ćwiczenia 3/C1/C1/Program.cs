namespace C1
{
    class Program
    {
        static void Main()
        {
            Car car = new Car();

            // Stwórz obiekt typuCar, czy masz dostęp do jego pól? czy możesz zmienić wartości? (nie zmieniaj pólklasy na publiczne).
            // Odpowiedź: Nie ma dostępu do pól obiektu Car. Nie można przypisać wartości do pól.
            // car.pojemonoscSilnika;
            // car.marka;

            Car car2 = new Car(125d, "Fiat");

            // Zmień modyfikatory dostępu konstruktorów na private.
            // Czy jest możliwe utworzenie nowego obiektutej klasy? Odpowiedź: Nie jest możliwe tworzenie obiektu dla prywatnych konstruktorów
            // Co się stało z konstruktorem domyślnym? Odpowiedź: Konstruktor domyślny zostanie przesłonięty konstruktorami prywatnymi

            // Następnie stwórz statyczny konstruktor ustawiający wartość tego pola na 4.
            // Jak możesz odwołać się do pola? Odpowiedź: Car.iloscKol o ile iloscKol nie jest polem prywatnym
            // Czy możesz go zmodyfikować? Odpowiedź: np. Car.iloscKol = 10
            // Co się stanie jak dodasz readonly? Odpowiedź: Przypisanie wartości do ilosc Kol jest możliwe tylko w konstruktorze statycznym

            Car.iloscKol = 2;
            Car.iloscKol = 4;

            // Dodaj w klasieCarstałe pole iloscDrzwi i ustaw mu wartość 4.
            // Jak możesz się do niego odnieść? Odpowiedź: Car.iloscDrzwi
            // Czymożesz go zmodyfikować? Odpowiedź: Nie
        }
    }
}
