using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Program do obliczania wskaźnika masy ciała (BMI)");

        Console.Write("Podaj wagę (w kilogramach): ");
        double waga = Convert.ToDouble(Console.ReadLine());

        Console.Write("Podaj wzrost (w metrach): ");
        double wzrost = Convert.ToDouble(Console.ReadLine());

        double bmi = ObliczBMI(waga, wzrost);

        Console.WriteLine($"Twoje BMI wynosi: {bmi}");

        WyswietlInformacjeBMI(bmi);
    }

    static double ObliczBMI(double waga, double wzrost)
    {
        
        return waga / (wzrost * wzrost)*10000;
    }

    static void WyswietlInformacjeBMI(double bmi)
    {
        Console.Write("Interpretacja BMI: ");

        if (bmi < 18.5)
        {
            Console.WriteLine("Niedowaga");
        }
        else if (bmi >= 18.5 && bmi <= 24.99)
        {
            Console.WriteLine("Wartość prawidłowa");
        }
        else
        {
            Console.WriteLine("Nadwaga");
        }
    }
}
