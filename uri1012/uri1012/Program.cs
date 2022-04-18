using System;
using System.Globalization;

namespace uri1012
{
    class Program
    {
        static void Main(string[] args)
        {
            double pi = 3.14159;
            string[] valores = (Console.ReadLine().Split(' '));
            double a = double.Parse(valores[0], CultureInfo.InvariantCulture);
            double b = double.Parse(valores[1], CultureInfo.InvariantCulture);
            double c = double.Parse(valores[2], CultureInfo.InvariantCulture);

            double areaTrianguloRetangulo = (a * c) / 2;
            double areaCirculo = pi * (Math.Pow(c, 2));
            double areaDoTrapezio = ((a + b) * c) / 2;
            double areaDoQuadrado = b * b;
            double areaDoRetangulo = a * b;

            Console.WriteLine("TRIANGULO: " + areaTrianguloRetangulo.ToString("F3"));
            Console.WriteLine("CIRCULO: " + areaCirculo.ToString("F3"));
            Console.WriteLine("TRAPEZIO: " + areaDoTrapezio.ToString("F3"));
            Console.WriteLine("QUADRADO: " + areaDoQuadrado .ToString("F3"));
            Console.WriteLine("RETANGULO: " + areaDoRetangulo.ToString("F3"));
        }
    }
}
