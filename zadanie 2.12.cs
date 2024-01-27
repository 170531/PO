using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Wprowadzaj liczby całkowite. Wprowadź 0 (zero), aby zakończyć.");

        int suma = 0;
        int liczba;

        do
        {
            Console.Write("Podaj liczbę: ");
            liczba = Convert.ToInt32(Console.ReadLine());
            suma += liczba;
        } while (liczba != 0);

        Console.WriteLine($"Suma wprowadzonych liczb: {suma}");
    }
}
