using System;
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Atividade 3 - múltiplos de 3 (for)");

        Console.WriteLine("");
        Console.WriteLine("Primeira Forma");
        for (int i = 0; i < 34; i++)
        {
            Console.WriteLine(i + " X 3 = " + i * 3);
        }

        Console.WriteLine("");
        Console.WriteLine("Segunda Forma");
        
        for (int i = 0; i < 100; i++)
        {
            if (i % 3 == 0)
            {
                Console.WriteLine(i);
            }
        }

        Console.WriteLine("");
        Console.WriteLine("Terceira Forma");

        for (int i = 0; i < 100; i+= 3)
        {
            Console.WriteLine(i);
        }

        Console.WriteLine("Pressione ENTER para encerrar");
        Console.ReadLine();
    }
}