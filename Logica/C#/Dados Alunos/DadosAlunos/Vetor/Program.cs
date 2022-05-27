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

            /*string[] nomeAlunos;
            int quantidadeAlunos;

            Console.WriteLine("Digite a quantidade de Alunos");
            quantidadeAlunos = int.Parse(Console.ReadLine());

            nomeAlunos = new string[quantidadeAlunos];
            for (int i = 0; i < quantidadeAlunos; i++)
            {
                Console.WriteLine("Nome aluno " + (i + 1));
                nomeAlunos[i] = Console.ReadLine();
            }

            Console.WriteLine("-------------------");
            Console.WriteLine("Nome dos Alunos:");
            for (int i = 0; i < quantidadeAlunos; i++)
            {
                Console.WriteLine(nomeAlunos[i]);
            }*/

            string[] nomeDoAluno = new string[16];

            Console.WriteLine("Nome do aluno:");
            nomeDoAluno[0] = Console.ReadLine();
            Console.WriteLine("Nome do aluno:");
            nomeDoAluno[1] = Console.ReadLine();
            Console.WriteLine("Nome do aluno:");
            nomeDoAluno[2] = Console.ReadLine();
            Console.WriteLine("Nome do aluno:");
            nomeDoAluno[3] = Console.ReadLine();
            Console.WriteLine("Nome do aluno:");
            nomeDoAluno[4] = Console.ReadLine();
            Console.WriteLine("Nome do aluno:");
            nomeDoAluno[5] = Console.ReadLine();
            Console.WriteLine("Nome do aluno:");
            nomeDoAluno[6] = Console.ReadLine();
            Console.WriteLine("Nome do aluno:");
            nomeDoAluno[7] = Console.ReadLine();
            Console.WriteLine("Nome do aluno:");
            nomeDoAluno[8] = Console.ReadLine();
            Console.WriteLine("Nome do aluno:");
            nomeDoAluno[9] = Console.ReadLine();
            Console.WriteLine("Nome do aluno:");
            nomeDoAluno[10] = Console.ReadLine();
            Console.WriteLine("Nome do aluno:");
            nomeDoAluno[11] = Console.ReadLine();
            Console.WriteLine("Nome do aluno:");
            nomeDoAluno[12] = Console.ReadLine();
            Console.WriteLine("Nome do aluno:");
            nomeDoAluno[13] = Console.ReadLine();
            Console.WriteLine("Nome do aluno:");
            nomeDoAluno[14] = Console.ReadLine();
            Console.WriteLine("Nome do aluno:");
            nomeDoAluno[15] = Console.ReadLine();

            int numeroDoAluno;
            bool imprimir = true;
            string parar;
            while (imprimir)
            {
                Console.WriteLine("Qual aluno você deseja imprimir?");
                numeroDoAluno = int.Parse(Console.ReadLine());
                Console.WriteLine(nomeDoAluno[numeroDoAluno - 1]);
                Console.WriteLine("Deseja parar S ou N");
                parar = Console.ReadLine();
                if (parar == "S" || parar == "s") imprimir = false;
            }

        }
    }
}
