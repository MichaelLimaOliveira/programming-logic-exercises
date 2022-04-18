using System;
using System.Globalization;

namespace Atividade_funçoes_matematicas_cs
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1 = 3.0;
            double n2 = 4.0;
            double n3 = -5.0;
            double A, B, C;

            A = Math.Sqrt(n1);
            B = Math.Sqrt(n2);
            C = Math.Sqrt(25.0);
            Console.WriteLine("A raiz quadrada de " + n1 + " = " + A);
            Console.WriteLine("A raiz quadrada de " + n2 + " = " + B);
            Console.WriteLine("A raiz quadrade de 25 = " + C);

            A = Math.Pow(n1, n2);
            B = Math.Pow(n1, 2.0);
            C = Math.Pow(5.0, 2.0);
            Console.WriteLine(n1 + " elevado a " + n2 + " = " + A);
            Console.WriteLine(n1 + " elevado ao quadrado = " + B);
            Console.WriteLine("5 elevado ao quadrado = " + C);

            A = Math.Abs(n2);
            B = Math.Abs(n3);
            Console.WriteLine("O valor absoluto de " + n2 + " = " + A);
            Console.WriteLine("O valor absoluto de " + n3 + " = " + B);

            double a = 2.0;
            double b = -3.0;
            double c = -5.0;

            double delta = Math.Pow(b, 2.0) - 4 * a * c;
            double x1 = (-b + Math.Sqrt(delta)) / (2.0 * a);
            double x2 = (-b - Math.Sqrt(delta)) / (2.0 * a);

            Console.WriteLine("A equaçao 2x^2+(-3x)+(-5)=0 tem como delta " + delta + " e as raizes de x1 " + x1 + " e x2 " + x2 + " respectivamente");
            Console.ReadLine();
        }
    }
}
