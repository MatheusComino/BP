using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace QuartoAluguel
{
    class Quarto
    {
        //Variaveis para guardar dados do quarto
        public int numero;
        public double tamanho;
        public double precoDiaria;
        public int quantosDias;
        public bool estaAlugado;
        public bool estaPago;
        //serve para ter uma ligação do locatario com o quarto
        public Locatario locatario = new Locatario();

        //Serve para calcular o valor total para alugar o quarto.
        public double CalculaValorParaAlugar()
        {
            return quantosDias * precoDiaria;
        }

        //Metodo contrutor para criar novas intancias da classe;
        public Quarto(int numero, double tamanho, double precoDiaria)
        {
            this.numero = numero;
            this.tamanho = tamanho;
            this.precoDiaria = precoDiaria;
        }

        //Seve para ter um texto padrão ao só chamar quato
        public override string ToString()
        {
            return locatario
                + "\n[QUANTO]"
                + "\nNumero: " + numero
                + "\nTamanho: " + tamanho + "m²"
                + "\nPreço diaria: " + precoDiaria.ToString("C2")
                + "\nDias Alugados: " + quantosDias
                + "\nValor total: " + CalculaValorParaAlugar().ToString("C2");
        }
    }

    class Locatario
    {
        //Serve para guardar os valores do locatario
        public string nome;
        public string cpf;
        public int idade;

        //Serve para mostrar um texto padrão ao só chamar locatario
        public override string ToString()
        {
            return "[LOCATARIO]"
                + "\nNome:" + nome
                + "\nCpf:" + cpf
                + "\nIdade: " + idade;
        }
    }
}
