using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Wszystkie możliwe kombinacje monet do wypłacenia 10 zł:");

        WypelnijKombinacje(10, new int[] { 5, 2, 1 }, new int[3], 0);
    }

    static void WypelnijKombinacje(int pozostalaKwota, int[] dostepneNominaly, int[] aktualnaKombinacja, int indeksNominalu)
    {
        if (pozostalaKwota == 0)
        {
            WyswietlKombinacje(aktualnaKombinacja);
            return;
        }

        if (pozostalaKwota < 0 || indeksNominalu == dostepneNominaly.Length)
        {
            return;
        }

        
        for (int ilosc = 0; ilosc <= pozostalaKwota / dostepneNominaly[indeksNominalu]; ilosc++)
        {
            aktualnaKombinacja[indeksNominalu] = ilosc;
            int nowaPozostalaKwota = pozostalaKwota - ilosc * dostepneNominaly[indeksNominalu];

            
            WypelnijKombinacje(nowaPozostalaKwota, dostepneNominaly, aktualnaKombinacja, indeksNominalu + 1);
        }
    }

    static void WyswietlKombinacje(int[] kombinacja)
    {
        for (int i = 0; i < kombinacja.Length; i++)
        {
            for (int j = 0; j < kombinacja[i]; j++)
            {
                Console.Write($"{(i == 0 ? "5" : (i == 1 ? "2" : "1"))} zł ");
            }
        }
        Console.WriteLine();
    }
}
