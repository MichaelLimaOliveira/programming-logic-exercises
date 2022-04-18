using System;

namespace uri1012
{
    class Program
    {
        static void Main(string[] args)
        {
            double pi = 3.14159;
            string[] valores = (Console.ReadLine().Split(' '));
            double a = double.Parse(valores[0]);
            double b = double.Parse(valores[1]);
            double c = double.Parse(valores[2]);

            double areaTrianguloRetangulo = (a * c) / 2;
            double areaCirculo = pi * (Math.Pow(c, 2));
            double areaDoTrapezio = ((a + b) * c) / 2;
            double areaDoQuadrado = b * b;
            double areaDoRetangulo = a * b;

            Console.WriteLine("TRIANGULO: ");



        }
    }
}
