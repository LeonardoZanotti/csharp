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
            bool sair = false;
            int idade = 0;

            while (sair == false)
            {

                Console.WriteLine("Digita a tua idade ae meu: ");
                idade = int.Parse(Console.ReadLine());

                if (idade < 18)
                    Console.WriteLine("Tu é mó kid em menor");

                // else if (idade < 65)
                else if (idade >= 18 && idade < 65)
                    Console.WriteLine("tá ficando veião ein kkk");

                else
                    Console.WriteLine("caraio kk ta mó old kkk vai morekk");

                Console.ReadKey();
                Console.Clear();
            }            
        }
    }
}
