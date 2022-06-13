using System;
using System.Globalization;

namespace VetorNomeAlunos
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, soma;
            int[,] mat = new int[99, 99];

            Console.Write("Qual a ordem da matriz?");
            n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.WriteLine("[" + i + "," + j + "]: ");
                    mat[i,j] = int.Parse(Console.ReadLine());
                }
            }

            soma = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    soma += mat[i, j];
                }
            }
            Console.WriteLine("SOMA DOS ELEMENTOS ACIMA DA DIAGONAL PRINCIPAL = " + soma);
        }
    }
}