using System;

class Program
{
    static void Main()
    {
        Console.Write("Podaj liczbę naturalną n: ");
        int n = Convert.ToInt32(Console.ReadLine());

        int suma = ObliczSumeSzeregu(n);

        Console.WriteLine($"Suma szeregu W({n}) = {suma}");
    }

    static int ObliczSumeSzeregu(int n)
    {
        int suma = 0;
        int znak = 1;

        for (int i = 1; i <= n; i++)
        {
            suma += znak * i;
            znak *= -1; 
        }

        return suma;
    }
}
