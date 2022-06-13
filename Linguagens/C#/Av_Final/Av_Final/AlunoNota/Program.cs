using System;
using AlunoNota;

class Program
{
    static void Main()
    {
        //SERVE APRA PERGUNTAR A QUANTIDADE DE AlUNOS
        Console.Write("Quantidade de alunos: ");
        Aluno[] alunos = new Aluno[int.Parse(Console.ReadLine())];

        for (int i = 0; i < alunos.Length; i++)
        {
           //SER PARA PERGUNTAR O NOME DO ALUNO
            Console.Write("Nome do aluno: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Digite as três notas do aluno: ");
            
            //SERVE PARA GUARDAR AS NOTAS EM UM ARRAY
            double[] notas = new double[3];
            for (int j = 0; j < 3; j++)
            {
                Console.Write("Nota " + (j + 1) + ": ");
                notas[j] = double.Parse(Console.ReadLine());
                
                //SERVE PARA VERIFICAR SE A NOTAS DIGITADA É VALIDA
                if (notas[j] > 30 || Double.IsNaN(notas[j]))
                {
                    Console.WriteLine("Digite novamente, a nota precisa ser menor que 30");
                    j--;
                }
                else if (notas[j] >= 35 || notas[j] == null)
                {
                    Console.WriteLine("Digite novamente, a nota precisa ser menor que 35");
                    j--;
                }
            }
            //SERVE PARA PASSAR OS VALORES DIGITADOS PARA A CLASSE
            alunos[i] = new Aluno(nome, notas);
            //SERVE PARA MOSTRAR OS VALORES PARA O USUARIO
            double somaNotas = alunos[i].calculaNota();
            Console.WriteLine("NOTA FINAL = " + somaNotas);
            Console.WriteLine(somaNotas >= 60 ? "||APROVADO||" : "||REPROVADO||\nFALTARAM " + (60 - somaNotas) + " PONTOS");
        }
    }
}