using System;
using AreaDoisTriangulos;
class Program
{
    static void Main()
    {
        Triangulo X, Y;
        X = new Triangulo();
        Y = new Triangulo();

        double[,] areaTriangulso = new double[2, 2];

        Console.WriteLine("Digite valor os lados do Triangulo 1");
        Console.Write("Lado A:");
        X.A = double.Parse(Console.ReadLine());
        Console.Write("Lado B:");
        X.B = double.Parse(Console.ReadLine());
        Console.Write("Lado C:");
        X.C = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite valor os lados do Triangulo 2");
        Console.Write("Lado A:");
        Y.A = double.Parse(Console.ReadLine());
        Console.Write("Lado B:");
        Y.B = double.Parse(Console.ReadLine());
        Console.Write("Lado C:");
        Y.C = double.Parse(Console.ReadLine());

        double p = (X.A + X.B + X.C) / 2;
        areaTriangulso[1, 0] = Math.Sqrt(p * (p - X.A) * (p - X.B) * (p - X.C));

        p = (Y.A + Y.B + Y.C) / 2;
        areaTriangulso[0, 1] = Math.Sqrt(p * (p - Y.A) * (p - Y.B) * (p - Y.C));

        Console.WriteLine("Area primeiro triangulo: " + areaTriangulso[1, 0]);
        Console.WriteLine("Area segundo triangulo: " + areaTriangulso[0, 1]);

        if (areaTriangulso[1, 0] > areaTriangulso[0, 1])
        {
            Console.WriteLine("O primeiro Triangulo é maior");
        }
        else
        {
            Console.WriteLine("O segundo Triangulo é maior");
        }
    }
}