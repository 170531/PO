using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Prosty kalkulator");

        Console.Write("Podaj pierwszą liczbę: ");
        double liczba1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Podaj znak operacji (+, -, *, /): ");
        char operacja = Convert.ToChar(Console.ReadLine());

        Console.Write("Podaj drugą liczbę: ");
        double liczba2 = Convert.ToDouble(Console.ReadLine());

        double wynik = WykonajOperacje(liczba1, operacja, liczba2);

        Console.WriteLine($"Wynik operacji: {wynik}");
    }

    static double WykonajOperacje(double a, char operacja, double b)
    {
        double wynik = 0;

        switch (operacja)
        {
            case '+':
                wynik = a + b;
                break;
            case '-':
                wynik = a - b;
                break;
            case '*':
                wynik = a * b;
                break;
            case '/':
                if (b != 0)
                {
                    wynik = a / b;
                }
                else
                {
                    Console.WriteLine("Błąd: Nie można dzielić przez zero.");
                }
                break;
            default:
                Console.WriteLine("Błąd: Nieprawidłowy znak operacji.");
                break;
        }

        return wynik;
    }
}
