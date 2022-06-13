using System;
using FuncionarioSalario;
using System.IO;

class Principal
{
    static void Main(string[] args)
    {
        //SERVE APRA PERGUNTAR A QUANTIDADE DE FUNCIONARIOS
        Console.Write("Quantidade de Funcionarios: ");
        Funcionario[] funcionario = new Funcionario[int.Parse(Console.ReadLine())];

        for (int i = 0; i < funcionario.Length; i++)
        {
            //PERGUNTA OS DADOS DO FUNCIONARIO
            Console.WriteLine("\n[Entre com os dados do Funcionario]");
            Console.Write("Nome:");
            string nome = Console.ReadLine();
            Console.Write("Salario Bruto:");
            double salarioBruto = double.Parse(Console.ReadLine());
            Console.Write("Imposto: ");
            double imposto = double.Parse(Console.ReadLine());
            //PASSA OS VALORES PARA A CLASE FUNCIONARIO ATRAVEZ DE UM METODO CONTRUTOR
            funcionario[i] = new Funcionario(nome, salarioBruto, imposto);
            Console.WriteLine("Salario liquido: " + funcionario[i].CalcularSalarioLiquidos());

            //PERGUNTA A QUANTIDADE DE REAJUSTE EM % DO SALARIO E MOSTRA O SALARIO REAJUSTADO 
            Console.Write("Percentual de almento: ");
            Console.WriteLine("Salario liquido: " + funcionario[i].CalcularAlmentoSalario(double.Parse(Console.ReadLine())));
        }
    }
}