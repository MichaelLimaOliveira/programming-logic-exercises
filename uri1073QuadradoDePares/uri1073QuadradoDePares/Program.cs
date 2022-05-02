using System;

namespace uri1073QuadradoDePares
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    int potenciaAtual = i;
                    potenciaAtual = (int)Math.Pow(i, 2);
                    Console.WriteLine(i + "^2 = " + potenciaAtual);
                }
            }
        }
    }
}
