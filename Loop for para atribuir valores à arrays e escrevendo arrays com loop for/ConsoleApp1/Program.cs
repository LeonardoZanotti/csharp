using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Loop --> Operação realizada um determinado número de veze; Loop infinito --> Operação realizada infinitas vezes
            // Loop for --> Expressão com início, condição e incremento
            // for (início, condição, incremento)
            // i++ é um pós incremento

            for (int i = 0; i < 100; i++)
                Console.Write(i + " ");

            Console.WriteLine("");

            for (int a = 0; a > 100; a++)       // a nunca chega a ser maior que 100, por isso, a nunca é escrito
                Console.WriteLine(a);

            Console.WriteLine("");

            for (int b = 0; b >= 100; b++)      // b nunca chega a ser maior ou igual a 100, por isso, b nunca é escrito
                Console.Write(b + " ");

            Console.WriteLine("");

            for (int c = 0; c <= 100; c++)
                Console.Write(c + " ");

            // Loop For para dar valores a um array
            Console.WriteLine("");
            Console.WriteLine("");

            int[] array = new int[1000];
            for (int d = 0; d < 1000; d++)
                array[d] = d * d;

            for (int j = 0; j < 1000; j++)
                Console.Write(j + ": " + array[j] + " ");

            Console.WriteLine();

            for (int e = 0; e < 1000; e++)
                Console.WriteLine("{0} x {1} = {2}", e, e, array[e]);

            // ----------------------------
            Console.ReadKey();
        }
    }
}
