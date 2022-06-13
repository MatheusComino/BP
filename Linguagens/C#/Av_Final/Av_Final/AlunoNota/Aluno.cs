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

        //METODO CONTRUTOR PARA PASSAR OS VALORES PARA AS VARIAVEIS
        public Aluno(string nome, double[] notas)
        {
            this.nome = nome;
            this.notas = notas;
        }
        //SERVE PARA SOMAR AS 3 NOTAS DO ALUNO
        public double calculaNota()
        {
            double somaNotas = 0;
            for (int i = 0; i < notas.Length; i++)
            {
                somaNotas += notas[i];
            }
            return somaNotas;
        }
    }
}
