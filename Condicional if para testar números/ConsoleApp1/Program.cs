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
            // int num1 = 0, num2 = 0;
            // Console.WriteLine("\tDigite o Primeiro número\n");
            // num1 = int.Parse(Console.ReadLine());
            // Console.WriteLine("\tDigite o segundo número\n"));
            // num2 = int.Parse(Console.ReadLine());

            int num1 = 10, num2 = 15;

            if (num1 < num2)
            {
                Console.WriteLine("num1 < num2");
                Console.WriteLine(num1 + " < " + num2);
            }

            if (num1 > num2)
            {
                Console.WriteLine("num1 > num2");
                Console.WriteLine("{0} > {1}", num1, num2);
            }

            if (num1 != num2)           // != --> diferente
            {
                Console.WriteLine("num1 != num2");
                Console.WriteLine("{0} != {1}", num1, num2);
            }

            if (num1 == num2)           // == --> igual
            {
                Console.WriteLine("num1 = num2");
                Console.WriteLine("{0} = {1}", num1, num2);
            }

            if (num1 <= num2)
            {
                Console.WriteLine("num1 <= num2");
                Console.WriteLine(num1 + " <= " + num2);
            }

            if (num1 >= num2)
            {
                Console.WriteLine("num1 >= num2");
                Console.WriteLine("{0} >= {1}", num1, num2);
            }

            Console.WriteLine(5 < 4);
            Console.WriteLine(5 > 4);
            Console.WriteLine(5 == 4);
            Console.WriteLine(5 <= 4);
            Console.WriteLine(5 >= 4);
            Console.WriteLine((5 * 4) >= 20);
            Console.WriteLine((5 / 4) <= 1);         // Isso dá true por que ele considera apenas a parte inteira
            Console.WriteLine((5.0 / 4.0) <= 1.0);   // Agora dá false pois considera float

            Console.ReadKey();
        }
    }
}
