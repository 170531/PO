using System;

class Program
{
    static void Main()
    {
        Console.Write("Podaj liczbę n: ");
        int n = Convert.ToInt32(Console.ReadLine());

        if (n < 0)
        {
            Console.WriteLine("Silnia nie jest zdefiniowana dla liczb ujemnych.");
        }
        else
        {
            long wynik = ObliczSilnie(n);
            Console.WriteLine($"{n}! = {wynik}");
        }
    }

    static long ObliczSilnie(int liczba)
    {
        if (liczba == 0 || liczba == 1)
        {
            return 1;
        }
        else
        {
            return liczba * ObliczSilnie(liczba - 1);
        }
    }
}
