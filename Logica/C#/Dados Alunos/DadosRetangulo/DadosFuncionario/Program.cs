using System;
using DadosFuncionario;

class Program
{
    static void Main()
    {

        Funcionario funcionario = new Funcionario();

        Console.Write("Nome:");
        funcionario.nome = Console.ReadLine();
        Console.Write("Salario Bruto: ");
        funcionario.salarioBruto = double.Parse(Console.ReadLine());
        Console.Write("Imposto: ");
        funcionario.imposto = double.Parse(Console.ReadLine());

        double salarioLiquido = funcionario.CalculaSalarioLiquido();
        Console.WriteLine("Salario Liquido: " + salarioLiquido);

        Console.Write("Percentual de almento de salario ");
        salarioLiquido = funcionario.salarioBruto + funcionario.salarioBruto * (double.Parse(Console.ReadLine()) / 100);

        Console.WriteLine("Salario Liquido com almento de " + salarioLiquido);
    }
}