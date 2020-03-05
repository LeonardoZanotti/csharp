using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            // arrays, vetores, listas --> listas de itens do mesmo tipo
            // arrays tanto de itens com tipos (string, inteiro, float, double, decimal, char, etc) quanto para classes
            int[] array = new int[5];       // Nova lista array com 5 itens
            array[0] = 5;
            Console.WriteLine(array[0]);

            int[] lista = new int[]
            {
                1, 2, 3, 4, 5, 6, 7,
            };
            Console.WriteLine(lista[2]);

            Console.ReadKey();
        }
    }
}
