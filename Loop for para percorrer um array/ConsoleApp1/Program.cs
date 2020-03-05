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
            int[] array = { 2, 3, 5, 7, 9, 11, 13, 17, 19, 23, 27, 29, 31, 37, 41 };

            for (int i = 0; i < array.Length; i++)      // x.Length determina o número de elementos de x, nesse caso, do array
                Console.WriteLine(array[i]);

            Console.ReadKey();
        }
    }
}
