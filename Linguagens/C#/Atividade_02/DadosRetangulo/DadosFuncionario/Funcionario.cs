using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DadosFuncionario
{
    internal class Funcionario
    {
        public string nome;
        public double salarioBruto;
        public double imposto;

        public double CalculaSalarioLiquido()
        {
            return salarioBruto - imposto;
        }
    }
}
