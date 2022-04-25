using System;
using System.Linq;

namespace uri1045
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;
            string[] vet = Console.ReadLine().Split(' ');

            double[] numeros = vet.ToList().Select(e => double.Parse(e)).OrderByDescending(e => e).ToArray();
            a = numeros[0];
            b = numeros[1];
            c = numeros[2];

            if (a >= b + c)
            {
                Console.WriteLine("NAO FORMA TRIANGULO");
            }
            else
            {
                if (Math.Pow(a, 2) == (Math.Pow(b, 2) + Math.Pow(c, 2)))
                {
                    Console.WriteLine("TRIANGULO RETANGULO");
                }
                if (Math.Pow(a, 2) > (Math.Pow(b, 2) + Math.Pow(c, 2)))
                {
                    Console.WriteLine("TRIANGULO OBTUSANGULO");
                }
                if (Math.Pow(a, 2) < (Math.Pow(b, 2) + Math.Pow(c, 2)))
                {
                    Console.WriteLine("TRIANGULO ACUTANGULO");
                }
                if (a == b && a == c)
                {
                    Console.WriteLine("TRIANGULO EQUILATERO");
                }
                else if (a == b || a == c || b == c)
                {
                    Console.WriteLine("TRIANGULO ISOSCELES");
                }
            }
        }
    }
}
