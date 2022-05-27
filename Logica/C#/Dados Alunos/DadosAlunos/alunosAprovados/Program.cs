using System;

class progran
{

    static void Main()
    {
        int n;
        double media;
        string[] nome = new string[99];
        double[,] notas = new double[99,99];

        //Serve para perguntar quantas alunos existem
        Console.Write("Quantos alunos serao digitados?");
        n = int.Parse(Console.ReadLine());

        //Serve para perguntar nome, primeira e segunda nota
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Digite nome, primeira e segunda nota do " + (i + 1) + " o aluno:");
            nome[i] = Console.ReadLine();
            notas[i, 0] = double.Parse(Console.ReadLine());
            notas[i, 1] = double.Parse(Console.ReadLine());

        }

        //Serve para mostrar os nomes dos alunos que tem media maior que 6
        Console.WriteLine("Alunos aprovados");
        for (int i = 0; i < n; i++)
        {
            media = (notas[i, 0] + notas[i, 1]) / 2;
            if (media > 7.5)
            {
                Console.WriteLine(nome[i]);
            }
        }
    }
}