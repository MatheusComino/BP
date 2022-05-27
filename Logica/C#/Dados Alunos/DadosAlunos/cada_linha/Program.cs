using System;
class progran
{
    static void Main()
    {
        int n, maior;
        int[,] vetor = new int[99,99];
        int[,] mat = new int[99,99];


        //Serve para perguntar a quantidade de numeros que serão digitados
        Console.Write("Qual a ordem da matriz?");
        n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write("Elemento [" + i + "," + j + "]: ");
                mat[i,j] = int.Parse(Console.ReadLine());
            }
        }

        Console.WriteLine("MAIOR ELEMENTO DE CADA LINHAS");
        for (int i = 0; i < n; i++)
        {
            maior = mat[i, 0];
            for (int j = 0; j < n; j++)
            {
                if (mat[i,j] > maior)
                {
                    maior = mat[i, j];
                }
            }
            Console.WriteLine(maior);
        }
    }
}