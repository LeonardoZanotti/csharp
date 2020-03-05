using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
        // bool sair = false;

        // while (sair == false) { 

        inicio:

            int num1, num2, res = 0;    // Número 1, Número 2 e Resultado
            string op, snum1, snum2;          // Operação, Número 1 string e Número 2 string

            Console.WriteLine("Digite o número 1: ");
            snum1 = Console.ReadLine();
            num1 = int.Parse(snum1);

            Console.WriteLine("");
            Console.WriteLine(snum1);
            Console.WriteLine("");

            Console.WriteLine("\tQual operação deseja fazer? [+, -, x, /, %]\n");
            op = Console.ReadLine();

            Console.WriteLine("");
            Console.WriteLine(snum1 + " " + op);
            Console.WriteLine("");

            Console.WriteLine("Digite o Número 2:");
            snum2 = Console.ReadLine();
            num2 = int.Parse(snum2);

            Console.WriteLine("");
            Console.WriteLine(snum1 + " " + op + " " + snum2);
            Console.WriteLine("");

            switch (op)           // interruptor
            {
                case "+":
                    res = num1 + num2;
                    break;

                case "-":
                    res = num1 - num2;
                    break;

                case "x":
                    res = num1 * num2;
                    break;

                case "/":
                    res = num1 / num2;
                    break;

                case "%":
                    res = num1 % num2;
                    break;

                default:
                    Console.WriteLine("CARALHO TU É BURRO PORRA FAZ ISSO DIREITO");
                    break;
            }

                    Console.WriteLine(num1 + " " + op + " " + num2 + " = " + res);

            Console.ReadKey();
            Console.Clear();        // limpa a tela

        goto inicio;                // vai para o inicio:
            // }         
        }
    }
}
