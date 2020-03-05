// Um programa para procurar um aluno dentro de uma turma!  :cheesygrin:
// Custou mas está feito...Já me tinha esquecido da matrizes  :wallbash:

using System;

public class locaturma
{
    public static void Main()
    {

        char op;
        do
        {
            Console.WriteLine("PROGRAMA PARA ACHAR A POSIÇÃO DE ALUNOS DENTRO DE UMA TURMA (array)\n");
            Console.WriteLine("╔══╦══╦══╦══╦══╦══╦══╗");
            Console.WriteLine("║XX║1c│2c║3c│4c║5c│6c║");
            Console.WriteLine("╠══╠══│══╬══│══╬══│══╣");
            Console.WriteLine("║1f║01│02║03│04║05│06║");
            Console.WriteLine("║──║──│──║──│──║──│──║");
            Console.WriteLine("║2f║07│08║09│10║11│12║");
            Console.WriteLine("║──║──│──║──│──║──│──║");
            Console.WriteLine("║3f║13│14║15│16║17│18║");
            Console.WriteLine("║──║──│──║──│──║──│──║");
            Console.WriteLine("║4f║19│20║21│22║23│24║");
            Console.WriteLine("╚══╩══╩══╩══╩══╩══╩══╝");

            int i = 0;
            int j = 0;
            int a = 0;
            int b = 0;
            int num_aluno;

            int[,] turma = new int[,]           // int[,] declara uma matriz
            {
                      {01,02,03,04,05,06},      // linhas da matriz    
                      {07,08,09,10,11,12},
                      {13,14,15,16,17,18},
                      {19,20,21,22,23,24}
            };


            Console.WriteLine("\n\nDigite o número do aluno que quer pesquisar");
            num_aluno = int.Parse(Console.ReadLine());
            bool achei = false;

            if (num_aluno <= 24 & num_aluno >= 01)
            {
                for (i = 0; i <= 3; i++)
                {
                    for (j = 0; j <= 5; j++)
                    {
                        if (num_aluno == turma[i, j])
                        {
                            achei = true;
                            a = i + 1;
                            b = j + 1;
                        }
                    }
                }
            }

            if (achei)
            {              
                Console.WriteLine("\t\t┌──────------------------------------------------┐");
                Console.WriteLine("\t\t│ O Aluno nº {0} esta na fila {1} coluna {2} ", num_aluno, a, b);
                Console.WriteLine("\t\t└------------------------------------------------┘\n");
            }
            else
            {
                Console.WriteLine("\n\t\t\t ☻ Introduza um numero de aluno válido ☻\n");
            }

            Console.WriteLine("Deseja repetir o programa s/n");
            op = char.Parse(Console.ReadLine());
        }
        while (op == 's');
    }
}