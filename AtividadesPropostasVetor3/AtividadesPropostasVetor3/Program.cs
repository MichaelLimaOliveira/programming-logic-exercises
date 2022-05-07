using System;

namespace AtividadesPropostasVetor3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A;
            int[] B;
            int[] C;

            int n = int.Parse(Console.ReadLine());

            A = new int[n];
            B = new int[n];
            C = new int[n];

            string[] auxA = Console.ReadLine().Split(' ');
            string[] auxB = Console.ReadLine().Split(' ');

            for (int i = 0; i < n; i++)
            {
                A[i] = int.Parse(auxA[i]);
                B[i] = int.Parse(auxB[i]);
                C[i] = A[i] + B[i];

                Console.Write(C[i] + " ");
            }

        }
    }
}