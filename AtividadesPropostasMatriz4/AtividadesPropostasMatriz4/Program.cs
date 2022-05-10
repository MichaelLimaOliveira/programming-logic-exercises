using System;

namespace AtividadesPropostasMatriz4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[,] matrizSquare = new int[n, n];

            for (int i = 0; i < n; ++i)
            {
                string[] aux = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; ++j)
                {
                    matrizSquare[i, j] = int.Parse(aux[j]);
                }
            }

            int sumDiagonal = 0;

            for (int i = 0; i < n; ++i)
            {
                sumDiagonal += matrizSquare[i, i];
            }
            Console.WriteLine(sumDiagonal);

        }
    }
}
