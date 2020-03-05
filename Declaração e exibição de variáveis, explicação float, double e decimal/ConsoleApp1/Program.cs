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
            // Variável (Variable) --> Algo que varia --> informação, dados

            // Declarando uma variável

            int age = 17;               // Variável inteira 'age' = 0
            float weight = 60.5f;       // Variável do tipo float 'weight' = 60.5 (o 'f' depois do 5 é para identificar como float)
            string name = "Leonardo";   // Variável do tipo string 'name' = "Leonardo"; Atenção: variável do tipo string se declara usando aspas duplas ""
            char caractere = 'L';       // Variável do tipo char 'caractere' = 'L'; Atenção: variável do tipo char se declara usando aspas simples ''
            double height = 1.764;      // Variável do tipo double 'height' = 1.764
            decimal ira = 87.789m;      // Variável do tipo decimal 'ira' = 87.789 (o 'm' depois do 9 é para identificar como decimal)
            char ch = 'A';              // Variável do tipo char 'caractere' = 'A'; Atenção: variável do tipo char se declara usando aspas simples '' 
            byte red = 255;             // Variável do tipo byte 'red' = 255; Variáveis do tipo byte podem representar números de 0 até 255    
            bool imgay = true;          // Variável do tipo bool (booleano) 'imgay' = true

            // Variáveis também podem ser declaradas sem definir um valor, por exemplo: string nome;
            // Sendo necessário fazer um comando que pergunte o nome da pessoa, ou algo assim

            // Escrevendo todas as variáveis na tela
            Console.WriteLine("Nome: " + name);
            Console.WriteLine("Quantas vezes deu a bundinha: " + age);
            Console.WriteLine(weight);
            Console.WriteLine(caractere);
            Console.WriteLine(height);
            Console.WriteLine(ira);
            Console.WriteLine(ch);
            Console.WriteLine(red);
            Console.WriteLine(imgay);


            // Explicando a 'diferença' entre variáveis do tipo float, double e decimal
            float flo = 1.111111111111111111111111111111111111111111111111111111111111111111111111f;
            double dou = 1.111111111111111111111111111111111111111111111111111111111111111111111111;
            decimal dec = 1.111111111111111111111111111111111111111111111111111111111111111111111111m;

            Console.WriteLine(flo);
            Console.WriteLine(dou);
            Console.WriteLine(dec);

            // Float --> até 6 dígitos após a vírgula --> baixa precisão
            // double --> até 14 dígitos após a vírgula --> média precisão
            // decimal --> até 28 dígitos após a vírgula --> alta precisão

            Console.ReadKey();
        }
    }
}
