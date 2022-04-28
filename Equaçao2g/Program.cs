using System;

namespace Equaçao2g
{
    class Program
    {
        static void Main(string[] args)
        {
            Double a, b, c, delta, x1, x2;

            Console.Write("Digite O Valor De A: ");
            a = double.Parse(Console.ReadLine());
            Console.Write("Digite O Valor De B: ");
            b = double.Parse(Console.ReadLine());
            Console.Write("Digite O Valor De C: ");
            c = double.Parse(Console.ReadLine());

            delta = Math.Pow(b, 2) - 4 * a * c;
            Console.WriteLine("\n\nO Valor De Delta é: " + delta);

            x1 = (-b + Math.Sqrt(delta)) / 2 * a;
            x2 = (-b - Math.Sqrt(delta)) / 2 * a;

            if(delta > 0)
            {
                Console.WriteLine("\n\nExistem Duas Raízes Reais Diferentes. X1:" + x1 + " e X2:" + x2);

            }
            else if(delta == 0)
            {
                Console.WriteLine("\n\nExistem Duas Raízes Reais Iguais. X1:" + x1 + " e X2:" + x2);


            }
            else
            {
                Console.WriteLine("\n\nNão Existem Raízes Reais!");

            }



            Console.ReadKey();


            //Console.WriteLine(delta);
        }
    }
}
