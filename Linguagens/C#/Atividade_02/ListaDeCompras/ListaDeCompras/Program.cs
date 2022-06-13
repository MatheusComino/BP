using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDeCompras
{
    class Program
    {
        static void Main()
        {
            Produtos produtos = new Produtos();
            Cliente cliente = new Cliente();

            //Preencher dados
            for (int i = 0; i < 2; i++)
            {
                //Cliente
                Console.WriteLine("Nome:");
                cliente.nome[i] = Console.ReadLine();

                Console.WriteLine("Endereço:");
                cliente.endereco[i] = Console.ReadLine();

                Console.WriteLine("Idade:");
                cliente.idade[i] = int.Parse(Console.ReadLine());

                for (int j = 0; j < 2; j++)
                {
                    //Produtos
                    Console.WriteLine("Codigo do produto:");
                    produtos.codigo[i, j] = Console.ReadLine();

                    Console.WriteLine("Descrição:");
                    produtos.descrição[i, j] = Console.ReadLine();

                    Console.WriteLine("Quantidade:");
                    produtos.quantidade[i, j] = int.Parse(Console.ReadLine());

                    Console.WriteLine("Preço:");
                    produtos.preco[i, j] = int.Parse(Console.ReadLine());
                }

            }

            for (int i = 0; i < 2; i++)
            {
                double somaPrecos = 0;
                Console.WriteLine("//Nome: " + cliente.nome[i] + " //Endereço: " + cliente.endereco[i] + " //Idade: " + cliente.idade[i]);
                for (int j = 0; j < 2; j++)
                {
                    Console.WriteLine("//Descrição: " + produtos.descrição[i, j] + " //Quantidade: " + produtos.quantidade[i, j] + " //Preço unitario: " + produtos.preco[i, j] + " //Preço somados " + (produtos.preco[i, j] * produtos.quantidade[i, j]));
                    somaPrecos += produtos.preco[i, j] * produtos.quantidade[i, j];
                }
                Console.WriteLine("//Preço Total: " + somaPrecos);
            }
        }
    }
}
