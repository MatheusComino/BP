using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 06 - Atribuições de Variaveis");

        int idade = 34;
        int idadeRoberto = idade;

        Console.WriteLine("A idade de roberto é " + idadeRoberto);

        idade = 25;

        Console.WriteLine("Pressione ENTER para fechar");
        Console.ReadLine();
    }
}