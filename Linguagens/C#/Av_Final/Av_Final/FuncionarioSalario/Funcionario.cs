using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuncionarioSalario
{
    internal class Funcionario
    {
        public string Nome;
        public double SalarioBruto;
        public double Imposto;

        //METODO CONTRUTOR PARA PASSAR OS VALORES PARA A CLASSE
        public Funcionario(string nome, double salarioBruto, double imposto)
        {
            Nome = nome;
            SalarioBruto = salarioBruto;
            Imposto = imposto;
        }

        //RETORNA O SALARIO SALARIO BRUNO MENOS O IMPOSTO
        public double CalcularSalarioLiquidos()
        {
            return SalarioBruto - Imposto;
        }

        //RETORNA O SALARIO COM O REAJUSTE EM % JÁ DESCONTADO O IMPOSTO
        public double CalcularAlmentoSalario(double percentual_Almento)
        {
            return SalarioBruto += (SalarioBruto * (percentual_Almento / 100)) - Imposto;
        }

        //SERVE PARA TER UM TEXTO PADRÃO AO CHAMAR SOMENTE A CLASSE FUNCIONARIO
        public override string ToString()
        {
            return "O funcionario " + Nome.ToUpper() + ", recebe R$" + CalcularSalarioLiquidos().ToString("F2") + " de pagamento mensal.";
        }
    }
}
