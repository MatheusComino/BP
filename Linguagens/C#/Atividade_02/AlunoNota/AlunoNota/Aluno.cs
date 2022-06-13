using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace AlunoNota
{
    internal class Aluno
    {
        public string nome;
        public double[] notas = new double[3];

        public double calculaNota()
        {
            double somaNotas = 0;
            for (int i = 0; i < notas.Length; i++)
            {
                somaNotas += notas[i];
            }
            return somaNotas;
        }
        public void notass()
        {
            for (int i = 0; i < 3; i++)
            {
                notas[i] = double.Parse(Console.ReadLine());
                Console.WriteLine(notas[1]);

                if (notas[0] > 30 || double.IsNaN(notas[0]))
                {
                    Console.WriteLine("Digite novamente, a nota precisa ser menor que 30");
                    i--;
                }
                else if (notas[i] >= 35 || notas[0] == null)
                {
                    Console.WriteLine("Digite novamente, a nota precisa ser menor que 35");
                    i--;
                }
            }
        }
    }
}
