using System;

namespace Vector
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("  SENAI SP - VOTUPORANGA - MDS TEC.  EM DESENVOLVIMENTO DE SISTEMAS - 2022");
            Console.WriteLine("==========================================================================");
            Console.WriteLine("Projeto Vetor/Array - Armazenamento dos Nomes dos Alunos da Turma MDS 2022");
            Console.WriteLine("==========================================================================");

            string[] nomeAlunos;
            int quantidadeAlunos;
            string imprimir;

            Console.WriteLine("Digite a quantidade de Alunos");
            quantidadeAlunos = int.Parse(Console.ReadLine());

            nomeAlunos = new string[quantidadeAlunos];
            for (int i = 0; i < quantidadeAlunos; i++)
            {
                Console.WriteLine("Nome aluno " + (i + 1));
                nomeAlunos[i] = Console.ReadLine();
            }

            Console.WriteLine("Deseja imprimir todos os alunos? S ou N");
            imprimir = Console.ReadLine();
            if (imprimir == "S" || imprimir == "s")
            {
                Console.WriteLine("-------------------");
                Console.WriteLine("Nome dos Alunos:");
                for (int i = 0; i < quantidadeAlunos; i++)
                {
                    Console.WriteLine(nomeAlunos[i].ToUpper());
                }
            }
        }
    }
}
