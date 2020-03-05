using System;

// Dá pra fazer um Console.ReadLine pedindo o valor de i pra pessoa poder alterar a tabuada
public class taboada2
{
    public static void Main()
    {
        Console.WriteLine("\t\t░░░░░▒▒▒▒▒▒▒▓▓▓ Produced by wiLL ▓▓▓▒▒▒▒▒▒▒░░░░░");

        Console.WriteLine("┌─────────────┐");
        Console.WriteLine("│Tabuada do 2 │");
        Console.WriteLine("└─────────────┘");
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine("2*{0}={1}", i, 2 * i);
        }

        Console.Read();

        Console.WriteLine("+-------------+");
        Console.WriteLine("¦Tabuada do 3 ¦");
        Console.WriteLine("+-------------+");
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine("3*{0}={1}", i, 3 * i);
        }

        Console.Read();
        Console.Read();
    }
}