using System;

// Um simples programa para somar dois nums.

class Hello
{
    static void Main()
    {
        int num1;
        int num2;
        int soma;

        Console.WriteLine("Digite o primeiro numero!");
        num1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite o segundo numero!");
        num2 = int.Parse(Console.ReadLine());
        soma = num1 + num2;
        Console.WriteLine("A soma dos Dois Numeros e de {0}", soma);        // {0} se refere a primeira variável após a vírgula, tipo: "a soma dos {0} é {1} ", alunos, soma
        Console.Write("Thank you ... Developed By wiLL\n");                 // \n é pra pular uma linha
        Console.Read();
    }
}