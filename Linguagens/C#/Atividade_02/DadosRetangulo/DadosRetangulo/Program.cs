using System;
using DadosRetangulo;

class program
{
    static void Main()
    {
        Retangulo retangulo = new Retangulo();
        Console.Write("Altura do retangulo: ");
        retangulo.altura = double.Parse(Console.ReadLine());
        Console.Write("Largura do retangulo: ");
        retangulo.largura = double.Parse(Console.ReadLine());

        double area = retangulo.calculaArea();
        double perimetro = retangulo.calculaPerimetro();
        double diagonal = retangulo.calculaDiagonal();

        Console.WriteLine("//Area:" + area + "//Perimetro:" + perimetro + "//diagonal:" + diagonal);
    }
}