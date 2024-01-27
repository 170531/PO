using System;

class Program
{
    static void Main()
    {
        Console.Write("Podaj pierwszą liczbę: ");
        double liczba1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Podaj drugą liczbę: ");
        double liczba2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Podaj trzecią liczbę: ");
        double liczba3 = Convert.ToDouble(Console.ReadLine());

        double najwiekszaLiczba = ZnajdzNajwiekszaLiczbe(liczba1, liczba2, liczba3);

        Console.WriteLine($"Największa liczba to: {najwiekszaLiczba}");
    }

    static double ZnajdzNajwiekszaLiczbe(double a, double b, double c)
    {
        
        return Math.Max(a, Math.Max(b, c));
    }
}
