using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDeCompras
{
    internal class Cliente
    {
        public string[] nome = new string[2];
        public string[] endereco = new string[2];
        public int[] idade = new int[2];
    }

    internal class Produtos
    {
        public string[,] codigo = new string[2, 2];
        public string[,] descrição = new string[2, 2];
        public int[,] quantidade = new int[2, 2];
        public double[,] preco = new double[2, 2];
    }
}
