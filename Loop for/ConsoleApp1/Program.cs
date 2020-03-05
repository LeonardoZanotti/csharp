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

            for (int i = 0; i < 100; i = i + 1)     // i = i + 1 --> i++
                Console.WriteLine(i);

            Console.ReadKey();
        }
    }
}
