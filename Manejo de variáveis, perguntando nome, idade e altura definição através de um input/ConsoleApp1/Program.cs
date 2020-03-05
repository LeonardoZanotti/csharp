using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            string nome;
            int idade;
            float height;

            Console.WriteLine("Digita teu nome ae meu: ");
            nome = Console.ReadLine();      // Lê a próxima linha digitada

            Console.WriteLine("bls mas agr digita a tua idade: ");
            idade = int.Parse(Console.ReadLine());      // Parse converte a variável, nesse caso, converte de string (Console.ReadLine) para inteiro (int)

            Console.WriteLine("okkk man kkk tua altura é quanto msm? kkj: ");
            height = float.Parse(Console.ReadLine());       // Parse converte a variável, nesse caso, converte de string (Console.ReadLine) para float (float)  

            Console.WriteLine("");

            Console.WriteLine("Mano, seguinte, teu nome é " + nome);
            Console.WriteLine("Tua idade é: " + idade);
            Console.WriteLine("E tua altura é: " + height);

            Console.ReadKey();
        }
    }
}
