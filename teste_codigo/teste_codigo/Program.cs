using System;

namespace Uri1041
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vet = Console.ReadLine().Split(' ');
            double x = double.Parse(vet[0]);
            double y = double.Parse(vet[1]);

            if(x == 0 && y == 0)
            {
                Console.WriteLine("ORIGEM");
            }

            if(x == 0)
            {
                Console.WriteLine("EIXO Y");
            }

            if (y == 0)
            {
                Console.WriteLine("EIXO Y");
            }

            if(x > 0)
            {
                if(y > 0)
                {
                    Console.WriteLine("Q1");
                }
                else
                {
                    Console.WriteLine("Q2");
                }
            }
            else
            {
                if (x > 0)
                {
                    Console.WriteLine("Q4");
                }
                else
                {
                    Console.WriteLine("Q4");
                }
            }
        }
    }
}