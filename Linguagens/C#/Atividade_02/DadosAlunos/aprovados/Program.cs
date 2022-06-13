using System;

class progran
{

    static void Main()
    {
        int n;
        double media;
        string[] nome = new string[99];
        double[] nota1 = new double[99];
        double[] nota2 = new double[99];

        //Serve para perguntar quantas alunos existem
        Console.Write("Quantos alunos serao digitados?");
        n = int.Parse(Console.ReadLine());

        //Serve para perguntar nome, primeira e segunda nota
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Digite nome, primeira e segunda nota do " + (i+1) + " o aluno:");
            nome[i] = Console.ReadLine();
            nota1[i] = double.Parse(Console.ReadLine());
            nota2[i] = double.Parse(Console.ReadLine());
        }

        //Serve para mostrar os nomes dos alunos que tem media maior que 6
        Console.WriteLine("Alunos aprovados");
        for (int i = 0; i < n; i++)
        {
            media = (nota1[i] + nota2[i]) / 2;
            if (media > 6)
            {
                Console.WriteLine(nome[i]);
            }
        }
    }
}