using System;

class Program
{
    static void Main()
    {
        Console.Write("Podaj pierwszą liczbę całkowitą: ");
        int liczba1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Podaj drugą liczbę całkowitą: ");
        int liczba2 = Convert.ToInt32(Console.ReadLine());

        if (CzyJestDzielnikiem(liczba1, liczba2))
        {
            Console.WriteLine($"{liczba2} jest dzielnikiem {liczba1}.");
        }
        else
        {
            Console.WriteLine($"{liczba2} nie jest dzielnikiem {liczba1}.");
        }
    }

    static bool CzyJestDzielnikiem(int liczba1, int liczba2)
    {
        
        return liczba1 % liczba2 == 0;
    }
}

