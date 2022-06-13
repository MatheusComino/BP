using System;
using DadosRetangulo;

class program
{
    static void Main()
    {
        //SERVE APRA PERGUNTAR A QUANTIDADE DE QUADRADOS
        Console.Write("Quantidade de quadrados: ");
        Retangulo[] retangulos = new Retangulo[int.Parse(Console.ReadLine())];

        for (int i = 0; i < retangulos.Length; i++)
        {
            //SERVE PARA PEGUNTAR OS VALORES DE ALTURA E LARGURA
            Console.Write("Altura do retangulo: ");
            double altura = double.Parse(Console.ReadLine());
            Console.Write("Largura do retangulo: ");
            double largura = double.Parse(Console.ReadLine());
            retangulos[i] = new Retangulo(altura, largura);

            //SERVE PARA CALCULAR A AREA, PERIMETO E DIAGONAL
            double area = retangulos[i].calculaArea();
            double perimetro = retangulos[i].calculaPerimetro();
            double diagonal = retangulos[i].calculaDiagonal();

            //SERVE PARA MOSTRAR OS VALORES DE AREA, PERIMETRO E DIAGONAL PARA O USUARIO.
            Console.WriteLine("//Area:" + area + "//Perimetro:" + perimetro + "//diagonal:" + diagonal.ToString("F3"));
        }
    }
}