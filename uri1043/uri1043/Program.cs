using System;
using System.Linq;

namespace uri1043
{
    class Program
    {
        static void Main(string[] args)
        {
            //Leia 3 valores reais (A, B e C) e verifique se eles formam ou não um triângulo.
            //Em caso positivo, calcule o perímetro do triângulo e apresente a mensagem: Perimetro = XX.X
            //Em caso negativo, calcule a área do trapézio que tem A e B como base e C como altura, mostrando a mensagem: Area = XX.X
            double a,
                   b, 
                   c, 
                   perimetro, 
                   area;

            double[] lados = Console.ReadLine()
                                    .Split(' ')
                                    .Select(lado => double.Parse(lado))
                                    .ToArray();

            a = lados[0];
            b = lados[1];
            c = lados[2];

            bool isTriangle = a + b > c && a + c > b && b + c > a;

            if (isTriangle)
            {
                //perimetro do triangulo
                perimetro = a + b + c;
                Console.WriteLine("Perimetro = " + perimetro.ToString("F1"));
            }
            else
            {
                //area do trapezio
                area = ((a + b) * c) / 2;
                Console.WriteLine("Area = " + area.ToString("F1"));
            }
        }
    }
}
