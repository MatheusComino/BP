using System;

class Programa
{
    static void Main(string[] args)
    {
        double n1, n2, n3, n4, resultado, media;

        resultado = n1 = n2 = n3 = n4 = 0;

        Console.Write("Digite a note 1: ");
        n1 = double.Parse(Console.ReadLine());

        Console.Write("Digite a note 2: ");
        n2 = double.Parse(Console.ReadLine());

        Console.Write("Digite a note 3: ");
        n3 = double.Parse(Console.ReadLine());

        Console.Write("Digite a note 4: ");
        n4 = double.Parse(Console.ReadLine());

        resultado = n1 + n2 + n3 + n4;
        media = (n1 + n2 + n3 + n4) / 4;
        Console.WriteLine("Soma de todas as notas:" + resultado);
        Console.WriteLine("Media de todas as notas:" + media);

        if (media >= 6)
        {
            Console.WriteLine("Aluno Aprovado");
        }
        else if (media >= 5)
        {
            Console.WriteLine("Aluno de Recuperação");
        }
        else
        {
            Console.WriteLine("Aluno Reprovado");
        }

        Console.WriteLine("Pressione ENTER para fechar");
        Console.ReadLine();
    }
}