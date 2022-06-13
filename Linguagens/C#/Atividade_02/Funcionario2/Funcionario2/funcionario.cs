using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funcionario2
{
    public class Funcionario
    {
        public string Nome;
        public double SalarioBruto;
        public double Imposto;

        public double CalcularSalarioLiquidos()
        {
            return SalarioBruto - Imposto;
        }

        public double CalcularAlmentoSalario(double percentual_Almento)
        {
            return SalarioBruto = (SalarioBruto - Imposto) + (SalarioBruto - Imposto) * (percentual_Almento / 100);
        }

        public override string ToString()
        {
            return "O funcionario " + Nome.ToUpper() + ", recebe R$" + CalcularSalarioLiquidos().ToString("F2") + " de pagamento mensal.";
        }
    }
}
