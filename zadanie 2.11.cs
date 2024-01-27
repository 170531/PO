using System;

class Program
{
    static void Main()
    {
        int suma = 0;
        int liczba = 1;
        int iloscLiczb = 0;

        while (suma <= 100)
        {
            suma += liczba;
            liczba++;
            iloscLiczb++;
        }

        Console.WriteLine($"Ilość kolejnych liczb dodanych do siebie, aby suma przekroczyła 100: {iloscLiczb}");
    }
}
