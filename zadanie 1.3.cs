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



        static double ObliczBMI(double waga, double wzrost)
        {

            return waga / (wzrost * wzrost);
        }


    }
}

