using System;
using System.Collections.Generic;
using System.Text;

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
            Ep.Nome = "Tofas";
            Ep.Idade = 23;
            Console.WriteLine("\t O empregado {0} tem {1} anos\n", Ep.Nome, Ep.Idade);


            while (r == 1) // ciclo para ir pedindo info dos empregados
            {

                Console.WriteLine("\t Introduza um nome\n");
                nome = Console.ReadLine();

                Console.WriteLine(" \tIntroduza a idade\n");
                num = int.Parse(Console.ReadLine());

                Empregado Eexemplo = new Empregado(nome, num);
                Eexemplo.MostraInformacao();


                Console.WriteLine("\tDeseja sair(s)? Para continuar qualquer tecla. \n");
                aux = Console.ReadLine();

                if (aux == "s" || aux == "S")
                {
                    r = 0;
                    Console.WriteLine("\tXau....Prima enter\n ");
                    Console.ReadLine();
                }


            }
        }
    }

    class Empregado
    {
        private string nome; // Nome da pessoa____Alterei o nome destes atributos para lowercase. Assim as propriedades ficam com nomes mais decentes.
        private int idade; // Idade da pessoa

        public Empregado() { }
        // Construtor: inicializa os elementos internos de um objecto
        public Empregado(string nomeDaPessoa, int idadeDaPessoa)
        {
            Nome = nomeDaPessoa;
            Idade = idadeDaPessoa;
        }

        // Propriedade que altera ou retorna o atributo Nome
        public string Nome
        {
            get { return this.nome; }
            set { this.nome = value; }
        }

        // Propriedade que altera ou retorna o atributo Idade
        public int Idade
        {
            get { return this.idade; }
            set { this.idade = value; }
        }


        // Mostra a informação sobre a pessoa
        public void MostraInformacao()
        {
            Console.WriteLine("\t O empregado {0} tem {1} anos", Nome, Idade);
        }
    }
}