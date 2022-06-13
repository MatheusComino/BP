using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeEstoque
{
    internal class Produto
    {
        public string nome;
        public double preco;
        public int quantidade;
        

        public double SomaValorTotal()
        {
            return quantidade * preco;
        }

        public void almentarEstoque(int almento)
        {
            quantidade += almento;
        }

        public void reduzirEstoque(int reduzir)
        {
            quantidade -= reduzir;
        }
    }
}
