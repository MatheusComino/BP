using System;

class progran
{
    static void Main()
    {
        int n, cont;
        double soma = 0, media, procentagem;
        double[] altura = new double[99];
        int[] idade = new int[99];
        string[] nomes = new string[99];

        //Serve para perguntar a quantidade de numeros que serão digitados
        Console.Write("Quantos pessoas serão digitadas?");
        n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Dados da " + (i + 1) + "a pessoa: ");
            Console.Write("Nome: ");
            nomes[i] = Console.ReadLine();

            Console.Write("Idade: ");
            idade[i] = int.Parse(Console.ReadLine());

            Console.Write("Altura: ");
            altura[i] = double.Parse(Console.ReadLine());
        }

        soma = 0;
        for (int i = 0; i < n; i++)
        {
            soma = soma + altura[i];
        }

        media = soma / n;
        Console.WriteLine("Altura media: " + media.ToString("F2"));

        cont = 0;
        for (int i = 0; i < n; i++)
        {
            if (idade[i] < 16)
            {
                cont = cont + 1;
            }
        }

        procentagem = cont * 100 / n;
        Console.WriteLine("Pessoas com menos de 16 anos:" + procentagem.ToString("F2") + "%");

        for (int i = 0; i < n; i++)
        {
            if (idade[i] < 16)
            {
                Console.WriteLine(nomes[i]);
            }
        }
    }
}