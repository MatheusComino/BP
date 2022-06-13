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
            double[,,] notaAlunos;
            double[,] mediaAlunos;
            string[] nomeMaterias;
            string[] numeroOrdinarios = { "Primeiro" ,  "Segundo" ,  "Terceiro" ,  "Quarto" };
            int quantidadeAlunos;
            int quantidadeMaterias;
            string imprimirNomes;
            string imprimirNotas;
            string imprimirMedia;
            double media = 0;

            Console.WriteLine("----------||SUMARIO||----------");
            Console.Write("Digite a quantidade de Alunos: ");
            quantidadeAlunos = int.Parse(Console.ReadLine());
            Console.Write("Digite a quantidade de materias: ");
            quantidadeMaterias = int.Parse(Console.ReadLine());
            nomeMaterias = new string[quantidadeMaterias];

            for (int i = 0; i < quantidadeMaterias; i++)
            {
                Console.Write("Digite a materia " + (i + 1) + ": ");
                nomeMaterias[i] = Console.ReadLine();
            }
            nomeAlunos = new string[quantidadeAlunos];
            notaAlunos = new double[quantidadeAlunos , quantidadeMaterias,4];
            mediaAlunos = new double[quantidadeAlunos , 4];

            Console.WriteLine("");
            Console.WriteLine("----------||ALUNOS||----------");
            for (int i = 0; i < quantidadeAlunos; i++)
            {
                Console.WriteLine("[ALUNO " + (i + 1) + "]");
                Console.Write("Nome aluno: ");
                nomeAlunos[i] = Console.ReadLine();
                Console.Write("");

                for (int j = 0; j < quantidadeMaterias; j++)
                {
                    Console.WriteLine("[NOTAS DE " + nomeMaterias[j].ToUpper() + "] ");
                    media = 0;
                    for (int k = 0; k < 4; k++)
                    {
                        Console.Write(numeroOrdinarios[k] + " Trimestre de " + nomeMaterias[j] + ": ");
                        notaAlunos[i, j,k] = double.Parse(Console.ReadLine());
                        media += notaAlunos[i, j, k];
                    }
                    mediaAlunos[i, j] = media;
                }
            }

            Console.WriteLine("");
            Console.WriteLine("----------||TRATAMENTO DOS DADOS||----------");
            Console.Write("Deseja imprimir todos os nomes dos alunos? S ou N: ");
            imprimirNomes = Console.ReadLine();
            if (imprimirNomes == "S" || imprimirNomes == "s")
            {
                Console.Write("Deseja imprimir todos as notas dos alunos? S ou N: ");
                imprimirNotas = Console.ReadLine();
                if (imprimirNotas == "S" || imprimirNotas == "s")
                {
                    Console.Write("Deseja imprimir as medias do alunos? S ou N: ");
                    imprimirMedia = Console.ReadLine();
                    Console.WriteLine("");
                    Console.WriteLine("----------||INFORMAÇÕES||----------");
                    if (imprimirMedia == "S" || imprimirMedia == "s")
                    {
                        for (int i = 0; i < quantidadeAlunos; i++)
                        {
                            Console.WriteLine(nomeAlunos[i].ToUpper());

                            for (int j = 0; j < quantidadeMaterias; j++)
                            {
                                for (int k = 0; k < 4; k++)
                                {
                                    Console.WriteLine(numeroOrdinarios[k] + " Trimestre de " + nomeMaterias[j] + ": " + notaAlunos[i, j, k]);
                                }
                                Console.WriteLine("MEDIA DE " + nomeMaterias[j] + mediaAlunos[i, j] / 4);

                                if (mediaAlunos[i, j] / 4 > 6)
                                {
                                    Console.WriteLine("APROVADO");
                                }
                                else
                                {
                                    Console.WriteLine("REPROVADO");
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
