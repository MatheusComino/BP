using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 08 - Condicionais2");

        int idadeRafael = 17;
        int quantidadePessoas = 2;
        bool acompanhado = quantidadePessoas > 1;
        bool grupo = false;
        

        if (idadeRafael >= 18 || acompanhado)
        {
            Console.WriteLine("Pode Entrar!");
        }
        else
        {
            Console.WriteLine("Não pode Entrar");
        }

        Console.WriteLine("Pressione ENTER para fechar");
        Console.ReadLine();
    }
}