using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 07 - Condicionais");

        int idadeRafael = 17;
        int quantidadePessoas = 2;

        if (idadeRafael >= 18)
        {
            Console.WriteLine("Pode Entrar!");
        }
        else
        {
            if (quantidadePessoas >= 2)
            {
                Console.WriteLine("Pode Entrar!");
            }
            else
            {
                Console.WriteLine("Não pode Entrar");
            }
        }

        Console.WriteLine("Pressione ENTER para fechar");
        Console.ReadLine();
    }
}