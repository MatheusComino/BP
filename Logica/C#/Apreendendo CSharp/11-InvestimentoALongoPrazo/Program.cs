using System;
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 11 - INVESTIMENTO A LONGO PRAZO");

        double fatordeRendimento = 1.005, investimento = 1000;
        for (int anos = 1; anos <= 5; anos++)
        {

            Console.WriteLine("");
            Console.WriteLine("\\-- NO ANO " + anos);
            Console.WriteLine("*******************");
            
            for (int mes = 1; mes <= 12; mes++)
            {
                investimento *= fatordeRendimento;
                Console.WriteLine("No mês " + mes + "R$ " + investimento);

            }
            fatordeRendimento = fatordeRendimento + 0.001;
            
        }
        Console.WriteLine("");
        Console.WriteLine("Depois de 5 anos você terá R$ " + investimento);

        Console.WriteLine("Pressione ENTER para encerrar");
        Console.ReadLine();
    }
}
