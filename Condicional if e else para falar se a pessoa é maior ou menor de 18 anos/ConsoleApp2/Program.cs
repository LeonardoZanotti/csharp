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
            int idade = 0;

            Console.WriteLine("Digite sua idade: ");
            idade = int.Parse(Console.ReadLine());

            if (idade >= 18)
                Console.WriteLine("Parabéns, vocÊ já pode ser preso por ter mais de 18 anos!");
            else
                Console.WriteLine("Caralho porra tu é mó kid caraio some daq meu, some daq menor do caralho, só volta se tiver 18");
            Console.ReadKey();

            /*
                comentário
            */
        }
    }
}
