using System;
class progran
{
    static void Main()
    {
        int n, contMulheres, contHomens;
        double menorAltura, maiorAltura, soma, media;
        string[] generos = new string[99];
        double[] alturas = new double[99];


        //Serve para perguntar a quantidade de numeros que serão digitados
        Console.Write("Quantas pessoas serão digitadas?");
        n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Console.Write("Altura da " + (i + 1) + "ª pessoa:");
            alturas[i] = double.Parse(Console.ReadLine());
            Console.Write("Genero da " + (i + 1) + "ª pessoa:");
            generos[i] = Console.ReadLine();
        }

        menorAltura = alturas[0];
        maiorAltura = alturas[0];
        for (int i = 0; i < n; i++)
        {
            if (alturas[i] > maiorAltura)
            {
                maiorAltura = alturas[i];
            }

            if (alturas[i] < menorAltura)
            {
                menorAltura = alturas[i];
            }
        }

        Console.WriteLine("Menor altura = " + menorAltura.ToString("F2"));
        Console.WriteLine("Maior altura = " + maiorAltura.ToString("F2"));
        soma = 0;
        contMulheres = 0;
        for (int i = 0; i < n; i++)
        {
            if (generos[i] == "F")
            {
                soma = soma + alturas[i];
                contMulheres = contMulheres + 1;
            }
        }

        if (contMulheres == 0)
        {
            Console.WriteLine("Impossivel calcular a altura media das mulheres");
        }
        else
        {
            media = soma / contMulheres;
            Console.WriteLine("Media das alturas das mulheres = " + media.ToString("F2"));
        }

        contHomens = n - contMulheres;
        Console.WriteLine("numero de homens = " + contHomens);
    }
}