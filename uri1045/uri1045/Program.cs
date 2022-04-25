using System;

namespace uri1045
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;
            string[] vet = Console.ReadLine().Split(' ');
            double n1 = double.Parse(vet[0]);
            double n2 = double.Parse(vet[1]);
            double n3 = double.Parse(vet[2]);

            if (n1 > n2 && n1 > n3)
            {
                a = n1;
                if (n2 > n3)
                {
                    b = n2;
                    c = n3;
                }
                else
                {
                    b = n3;
                    c = n2;
                }
            }
            else if (n2 > n1 && n2 > n3)
            {
                a = n2;
                if (n1 > n3)
                {
                    b = n1;
                    c = n3;
                }
                else
                {
                    b = n3;
                    c = n1;
                }
            }
            else
            {
                a = n3;
                if (n2 > n1)
                {
                    b = n2;
                    c = n1;
                }
                else
                {
                    b = n1;
                    c = n2;
                }
            }

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
