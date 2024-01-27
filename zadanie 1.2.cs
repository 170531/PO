using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Podaj współczynniki równania kwadratowego ax^2 + bx + c = 0");

        Console.Write("Podaj a: ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.Write("Podaj b: ");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.Write("Podaj c: ");
        double c = Convert.ToDouble(Console.ReadLine());

        double delta = ObliczDelte(a, b, c);

        Console.WriteLine($"Delta równania kwadratowego to: {delta}");
    }

    static double ObliczDelte(double a, double b, double c)
    {
        return Math.Pow(b, 2) - 4 * a * c;
    }
}
