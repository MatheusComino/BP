using System;
using AlunoNota;

class Program
{
    static void Main()
    {
        Aluno aluno = new Aluno();

        Console.Write("Nome do aluno: ");
        aluno.nome = Console.ReadLine();
        Console.WriteLine("Digite as três notas do aluno: ");

        aluno.notass();
        double somaNotas = aluno.calculaNota();
        Console.WriteLine("NOTA FINAL = " + somaNotas);
        Console.WriteLine(somaNotas > 60 ? "||APROVADO||" : "||REPROVADO||\nFALTARAM " + (60 - somaNotas) + " PONTOS");
    }
}