using System;

class Program
{
    static void Main()
    {
        Console.Write("Podaj liczbę n: ");
        int n = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"Liczby doskonałe w przedziale od 1 do {n}:");
        ZnajdzLiczbyDoskonale(n);
    }

    static void ZnajdzLiczbyDoskonale(int n)
    {
        for (int i = 1; i <= n; i++)
        {
            if (CzyDoskonala(i))
            {
                Console.WriteLine(i);
            }
        }
    }

    static bool CzyDoskonala(int liczba)
    {
        int sumaDzielnikow = 0;

        for (int i = 1; i < liczba; i++)
        {
            if (liczba % i == 0)
            {
                sumaDzielnikow += i;
            }
        }

        return sumaDzielnikow == liczba;
    }
}
