using System;

class Program
{
    static void Main()
    {
        Console.Write("Podaj liczbę elementów tablicy: ");
        int n = Convert.ToInt32(Console.ReadLine());

        int[] tablica = new int[n];

        WypelnijTablice(tablica);

        Console.WriteLine("Tablica po wypełnieniu:");
        WyswietlTablice(tablica);
    }

    static void WypelnijTablice(int[] tablica)
    {
        for (int i = 0; i < tablica.Length; i++)
        {
            Console.Write($"Podaj wartość dla elementu {i + 1}: ");
            tablica[i] = Convert.ToInt32(Console.ReadLine());
        }
    }

    static void WyswietlTablice(int[] tablica)
    {
        foreach (var element in tablica)
        {
            Console.Write($"{element} ");
        }
        Console.WriteLine();
    }
}
