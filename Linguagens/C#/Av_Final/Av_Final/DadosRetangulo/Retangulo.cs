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

        //METODO CONTRUTOR PARA PREENCHER AS VARIAVEIS
        public Retangulo(double altura, double largura)
        {
            this.altura = altura;
            this.largura = largura;
        }

        //SERVE PARA CALCULAR A AREA DO RETANGULO
        public double calculaArea()
        {
            return altura * largura;
        }
        
        //SERVE PARA CALCULAR O PERIMETRO DO RETANGULO
        public double calculaPerimetro()
        {
            return (2 * altura) + (2 * largura);
        }

        //SERVE PARA CALCULAR A DIAGONAL DO RETANGULO
        public double calculaDiagonal()
        {
            return Math.Sqrt((altura * altura) + (largura * largura));
        }
    }
}