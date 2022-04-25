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

            if (x > 0.0 && y > 0.00)
            {
                Console.WriteLine("Q1");
            }
            else if (x < 0.00 && y > 0.00)
            {
                Console.WriteLine("Q2");
            }
            else if (x < 0.00 && y < 0.00)
            {
                Console.WriteLine("Q3");
            }
            else if (x > 0.00 && y < 0.00)
            {
                Console.WriteLine("Q4");
            }
            else if (x == 0.00 && y == 0.00)
            {
                Console.WriteLine("Origem");
            }
            else if (x == 0)
            {
                Console.WriteLine("Eixo Y");
            }
            else if (y == 0)
            {
                Console.WriteLine("Eixo X");
            }
        }
    }
}
