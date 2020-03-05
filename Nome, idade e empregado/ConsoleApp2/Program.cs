using System;
using System.Collections.Generic;       
using System.Text;

// Os comandos tipo .MostraInformacao() ou .setidade foram criados abaixo desse código principal, tá lá embaixo 

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, r = 1;
            string nome, aux;

            Empregado E = new Empregado("Sara", 23);
            E.MostraInformacao();


            Empregado Ep;

            Ep = new Empregado();
            Ep.setnome("tofas");
            Ep.setidade(7);
            Console.WriteLine("\t O empregado {0} tem {1} anos\n", Ep.getnome(), Ep.getidade());


            while (r == 1) // ciclo para ir pedindo info dos empregados
            {

                Console.WriteLine("\t Introduza um nome\n");
                nome = Console.ReadLine();

                Console.WriteLine(" \tIntroduza a idade\n");
                num = int.Parse(Console.ReadLine());

                Empregado Eexemplo = new Empregado(nome, num);
                Eexemplo.MostraInformacao();


                Console.WriteLine("\tDeseja sair (press F)? Para continuar qualquer tecla. \n");
                aux = Console.ReadLine();

                if (aux == "F" || aux == "f")
                {
                    r = 0;
                    Console.WriteLine("\ttabao vose ser gay\n ");
                    Console.ReadLine();
                }


            }
        }
    }

    class Empregado
    {
        private string Nome; // Nome da pessoa
        private int Idade; // Idade da pessoa

        public Empregado() { }
        // Construtor: inicializa os elementos internos de um objecto
        public Empregado(string nomeDaPessoa, int idadeDaPessoa)
        {
            Nome = nomeDaPessoa;
            Idade = idadeDaPessoa;
        }

        // recebe o nome
        public void setnome(String nomep)
        {
            Nome = nomep;
        }

        // devolve o nome
        public String getnome()
        {
            return Nome;
        }

        // recebe a idade
        public void setidade(int idadep)
        {
            Idade = idadep;
        }

        // devolve a idade
        public int getidade()
        {
            return Idade;
        }



        // Mostra a informação sobre a pessoa
        public void MostraInformacao()
        {
            Console.WriteLine("\t O empregado {0} tem {1} anos", Nome, Idade);
        }
    }
}