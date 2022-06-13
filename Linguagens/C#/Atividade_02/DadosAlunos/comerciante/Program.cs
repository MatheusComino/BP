using System;
class progran
{
    static void Main()
    {
        int n, abaixo, entre, acima;
        double totalCompra, totalVenda, totalLucro, lucro, percentualLucro;
        string[] nomes = new string[99];
        double[] precosComprar = new double[99];
        double[] precosVenda = new double[99];


        //Serve para perguntar a quantidade de numeros que serão digitados
        Console.Write("Serão digitados dados de quantos produtos? ");
        n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Produto " + (i + 1));
            Console.Write("Nome: ");
            nomes[i] = Console.ReadLine()
                ;
            Console.Write("Preço de compra: ");
            precosComprar[i] = double.Parse(Console.ReadLine());

            Console.Write("Preço de venda: ");
            precosVenda[i] = double.Parse(Console.ReadLine());
        }

        abaixo = 0;
        entre = 0;
        acima = 0;
        for (int i = 0; i < n; i++)
        {
            lucro = precosVenda[i] - precosComprar[i];
            percentualLucro = lucro * 100.0 / precosComprar[i];

            if (percentualLucro < 10)
            {
                abaixo = abaixo + 1;
            }
            else
            {
                if (percentualLucro <= 20)
                {
                    entre = entre + 1;
                }
                else
                {
                    acima = acima + 1;
                }
            }
        }
        totalCompra = 0;
        totalVenda = 0;

        for (int i = 0; i < n; i++)
        {
            totalCompra = totalCompra + precosComprar[i];
            totalVenda = totalVenda + precosVenda[i];
        }

        totalLucro = totalVenda - totalCompra;

        Console.WriteLine("RELATORIO:");
        Console.WriteLine("Lucro abaixo de 10%: " + abaixo);
        Console.WriteLine("Lucro entre 10% e 20%: " + entre);
        Console.WriteLine("Lucro acima de 20%: " + acima);
        Console.WriteLine("Valor total de compra: " + totalCompra.ToString("F2"));
        Console.WriteLine("Valor total de venda: " + totalVenda.ToString("F2"));
        Console.WriteLine("Lucro total: " + totalLucro.ToString("F2"));
         
    }
}