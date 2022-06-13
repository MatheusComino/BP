using System;
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 12 - ENCADEANDO FOR");

        for (int i = 1; i <= 10; i++)
        {
            Console.Write(i + ".");
            for (int J = 1; J <= i; J++)
            {
                Console.Write("*");
                
            }
            Console.WriteLine("");
        }
        

        Console.WriteLine("Pressione ENTER para encerrar");
        Console.ReadLine();
    }
}
