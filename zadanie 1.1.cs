using System;

class Program
{
    static void Main()
    {
        Console.Write("Podaj temperaturę w stopniach Celsjusza: ");
        double temperaturaCelsjusza = Convert.ToDouble(Console.ReadLine());

        double temperaturaFahrenheita = PrzeliczNaFahrenheita(temperaturaCelsjusza);

        Console.WriteLine($"Temperatura w stopniach Fahrenheita: {temperaturaFahrenheita} °F");
    }

    static double PrzeliczNaFahrenheita(double temperaturaCelsjusza)
    {
        return (temperaturaCelsjusza * 9 / 5) + 32;
    }
}
