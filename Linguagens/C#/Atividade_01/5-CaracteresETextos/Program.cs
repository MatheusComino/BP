using System;
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 05 - Caracteres e Textos");
        char letra = 'a';
        letra = (char)77;
        Console.WriteLine(letra);
        letra = (char)65;
        Console.WriteLine(letra);
        letra = (char)84;
        Console.WriteLine(letra);
        letra = (char)72;
        Console.WriteLine(letra);
        letra = (char)69;
        Console.WriteLine(letra);
        letra = (char)85;
        Console.WriteLine(letra);
        letra = (char)83;
        Console.WriteLine(letra);

        letra = (char)77;
        Console.Write(letra);
        letra = (char)65;
        Console.Write(letra);
        letra = (char)84;
        Console.Write(letra);
        letra = (char)72;
        Console.Write(letra);
        letra = (char)69;
        Console.Write(letra);
        letra = (char)85;
        Console.Write(letra);
        letra = (char)83;
        Console.WriteLine(letra);

        letra = (char)(65 + 1);
        Console.WriteLine(letra);

        string primeiraFrase = "SENAI - Cursos de Tecnologia ";
        Console.WriteLine(primeiraFrase + 2022);

        string vazia = "";
        Console.WriteLine(vazia);

        letra = ' ';

        string cursos = 
@"Cursos disponiveis:
-C
-C++  
-HTML  
-Csharp";
        Console.WriteLine(cursos);
        


        Console.WriteLine("Pressione ENTER para encerrar");
        Console.ReadLine();
    }
}