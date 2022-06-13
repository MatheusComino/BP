using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DadosRetangulo
{
    internal class Retangulo 
    {
        public double altura, largura;

        public double calculaArea()
        {
            return altura * largura;
        }

        public double calculaPerimetro()
        {
            return 2 * (altura + altura);
        }

        public double calculaDiagonal()
        {
            return Math.Sqrt((altura * altura) + (altura * largura));
        }
    }
}
