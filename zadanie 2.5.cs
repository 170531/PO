using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Program do obliczania liczby pierwiastków równania kwadratowego (ax^2 + bx + c = 0)");

        Console.Write("Podaj współczynnik a: ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.Write("Podaj współczynnik b: ");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.Write("Podaj współczynnik c: ");
        double c = Convert.ToDouble(Console.ReadLine());

        ObliczPierwiastki(a, b, c);
    }

    static void ObliczPierwiastki(double a, double b, double c)
    {
        double delta = Math.Pow(b, 2) - 4 * a * c;

        if (delta > 0)
        {
            Console.WriteLine("Równanie ma dwa pierwiastki rzeczywiste.");
        }
        else if (delta == 0)
        {
            Console.WriteLine("Równanie ma jeden pierwiastek rzeczywisty.");
        }
        else
        {
            Console.WriteLine("Równanie nie ma pierwiastków rzeczywistych.");
        }
    }
}
