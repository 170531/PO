using System;

class Program
{
    static void Main()
    {
        int[] tab1 = { 3, -5, 8, -2, 1, 0, -4, 7, -1, 6 };
        int[] tab2 = new int[10];

        KopiujDodatnie(tab1, tab2);

        Console.WriteLine("Tablica tab1:");
        WyswietlTablice(tab1);

        Console.WriteLine("\nTablica tab2 (wartości dodatnie z tab1):");
        WyswietlTablice(tab2);
    }

    static void KopiujDodatnie(int[] tablicaWejsciowa, int[] tablicaWyjsciowa)
    {
        for (int i = 0; i < tablicaWejsciowa.Length; i++)
        {
            if (tablicaWejsciowa[i] > 0)
            {
                tablicaWyjsciowa[i] = tablicaWejsciowa[i];
            }
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
