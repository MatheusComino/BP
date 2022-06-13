using System;
using Funcionario2;
using System.IO;

class Principal
{
    static void Main(string[] args)
    {
        Funcionario funcionario = new Funcionario();

        Console.WriteLine("Entre com os dados do Funcionario");
        Console.WriteLine("Nome:");
        funcionario.Nome = Console.ReadLine();
        Console.WriteLine(funcionario.Nome);
        Console.WriteLine("Salario Bruto:");
        funcionario.SalarioBruto = double.Parse(Console.ReadLine());
        Console.WriteLine(funcionario.SalarioBruto.ToString());
        Console.WriteLine("Imposto: ");
        funcionario.Imposto = double.Parse(Console.ReadLine());
        Console.WriteLine(funcionario.Imposto.ToString());
        Console.WriteLine("Salario liquido: " + funcionario.CalcularSalarioLiquidos());

        Console.WriteLine("Percentual de almento: ");
        Console.WriteLine("Salario liquido: " + funcionario.CalcularAlmentoSalario(double.Parse(Console.ReadLine())));

    }
}