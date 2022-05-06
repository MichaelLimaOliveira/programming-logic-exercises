using System;

namespace ExemploDeVetor
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double[] vet = new double[n];

            for (int i = 0; i < n; i++)
            {
                vet[i] = double.Parse(Console.ReadLine());
            }

            for (int i=0; i < n; i++)
            {
                Console.WriteLine(vet[i]);
            }

        }
    }
}
