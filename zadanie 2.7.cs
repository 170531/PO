using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Program do obliczania stypendium na podstawie średniej ocen");

        Console.Write("Podaj średnią ocen: ");
        double sredniaOcen = Convert.ToDouble(Console.ReadLine());

        double kwotaStypendium = ObliczStypendium(sredniaOcen);

        switch (kwotaStypendium)
        {
            case 0.00:
                Console.WriteLine("Nie przysługuje stypendium.");
                break;
            case 350.00:
                Console.WriteLine($"Przysługuje stypendium w wysokości: {kwotaStypendium} zł");
                break;
            case 550.00:
                Console.WriteLine($"Przysługuje stypendium w wysokości: {kwotaStypendium} zł");
                break;
            default:
                Console.WriteLine("Nieprawidłowa wartość stypendium.");
                break;
        }
    }

    static double ObliczStypendium(double sredniaOcen)
    {
        double kwotaStypendium = 0.00;

        switch (sredniaOcen)
        {
            case double ocena when ocena >= 2.00 && ocena < 4.00:
                kwotaStypendium = 0.00;
                break;
            case double ocena when ocena >= 4.00 && ocena < 4.80:
                kwotaStypendium = 350.00;
                break;
            case double ocena when ocena >= 4.80 && ocena <= 5.00:
                kwotaStypendium = 550.00;
                break;
            default:
                kwotaStypendium = 0.00;
                break;
        }

        return kwotaStypendium;
    }
}
