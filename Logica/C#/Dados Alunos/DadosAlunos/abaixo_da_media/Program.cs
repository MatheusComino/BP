using System;

class progran
{

    static void Main()
    {
        int n;
        double soma = 0, media;
        double[] vet = new double[99];

        //Serve para perguntar a quantidade de numeros que serão digitados
        Console.Write("Quantos elementos vai ter o vetor?");
        n = int.Parse(Console.ReadLine());
    
        //Serve para somar todos os numeros digitados e fazer a media deles
        for (int i = 0; i < n; i++)
        {
            Console.Write("Digite um numero: ");
            vet[i] = double.Parse(Console.ReadLine());

            soma += vet[i];
        }
        media = soma / n;
        Console.WriteLine("MEDIA DO VETOR = " + media.ToString("F2"));
        Console.WriteLine("ELEMENTOS ABAIXO DA MEDIA");

        //Serve para mostrar o numeros que estão abaixa da media de todos os numeros somados
        for (int i = 0; i < n; i++)
        {
            if (vet[i] < media)
            {
                Console.WriteLine(vet[i].ToString("F2"));
            }
        }
    }
}