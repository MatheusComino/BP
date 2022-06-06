using System;
using ControleDeEstoque;
using System.Globalization;

class Program
{
    static void Main()
    {
        Produto produto = new Produto();
        Console.Write("Nome do produto: ");
        produto.nome = Console.ReadLine();

        Console.Write("Quantidade: ");
        produto.quantidade = int.Parse(Console.ReadLine());

        Console.Write("Preço: ");
        produto.preco = Double.Parse(Console.ReadLine());

        double valorTotal = produto.SomaValorTotal();

        Console.WriteLine("\nNome: " + produto.nome + "\nQuantidade: " + produto.quantidade + "\nPreço: " + produto.preco.ToString("C2", CultureInfo.CurrentCulture));
        Console.WriteLine("Valor toal:" + valorTotal.ToString("C2", CultureInfo.CurrentCulture));

        Console.WriteLine("Deseja AUMENTAR o estoque?");
        string isAlmentarEstoque = Console.ReadLine();
        if (isAlmentarEstoque == "S" || isAlmentarEstoque == "s") produto.almentarEstoque(int.Parse(Console.ReadLine()));

        valorTotal = produto.SomaValorTotal();
        Console.WriteLine("Valor toal:" + valorTotal.ToString("C2", CultureInfo.CurrentCulture));

        Console.WriteLine("Deseja REDUZIR o estoque?");
        string isReduzirEstoque = Console.ReadLine();
        if (isReduzirEstoque == "S" || isReduzirEstoque == "s") produto.reduzirEstoque(int.Parse(Console.ReadLine()));

        valorTotal = produto.SomaValorTotal();
        Console.WriteLine("Valor toal:" + valorTotal.ToString("C2", CultureInfo.CurrentCulture));

    }
}