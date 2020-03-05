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
            //              0, 1, 2, 3, 4, 5, ... 
            int[] array = { 2, 3, 5, 7, 9, 11, 13, 17, 19, 23, 27, 29, 31, 37, 41 };

            // foreach() --> função criada para percorrer listas/arrays ou gerar números
            foreach (int item in array)        // Para cada item no array faça 
                Console.WriteLine(item);
            Console.ReadKey();
        }
    }
}
