using System;

class Program
{
    static void Main()
    {
        Console.Write("Podaj rok do sprawdzenia: ");
        int rok = Convert.ToInt32(Console.ReadLine());

        if (CzyPrzestepny(rok))
        {
            Console.WriteLine($"{rok} to rok przestępny.");
        }
        else
        {
            Console.WriteLine($"{rok} nie jest rokiem przestępnym.");
        }
    }

    static bool CzyPrzestepny(int rok)
    {
        
        return (rok % 4 == 0 && rok % 100 != 0) || (rok % 400 == 0);
    }
}
