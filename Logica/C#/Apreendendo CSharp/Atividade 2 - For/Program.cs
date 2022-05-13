using System;
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Atividade 2 - For");

        double investimento = 1000;

        for (int i = 1; i <= 12; i++)
        {
            investimento = investimento + investimento * 0.005;
            Console.WriteLine("No mês " + i + " Você tem R$ " + investimento);
        }
        
        Console.WriteLine("Pressione ENTER para encerrar");
        Console.ReadLine();
    }
}