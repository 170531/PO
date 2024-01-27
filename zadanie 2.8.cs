using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Program do obliczania stypendium na podstawie średniej ocen");

        Console.Write("Podaj średnią ocen: ");
        double sredniaOcen = Convert.ToDouble(Console.ReadLine());

        double kwotaStypendium = ObliczStypendium(sredniaOcen);

        if (kwotaStypendium > 0)
        {
            Console.WriteLine($"Przysługuje stypendium w wysokości: {kwotaStypendium} zł");
        }
        else
        {
            Console.WriteLine("Nie przysługuje stypendium.");
        }
    }

    static double ObliczStypendium(double sredniaOcen)
    {
        if (sredniaOcen >= 2.00 && sredniaOcen < 4.00)
        {
            return 0.00;
        }
        else if (sredniaOcen >= 4.00 && sredniaOcen < 4.80)
        {
            return 350.00;
        }
        else if (sredniaOcen >= 4.80 && sredniaOcen <= 5.00)
        {
            return 550.00;
        }
        else
        {
            return 0.00;
        }
    }
}
