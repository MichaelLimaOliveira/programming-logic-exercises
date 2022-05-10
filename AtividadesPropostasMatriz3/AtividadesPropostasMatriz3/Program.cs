using System;
using System.Linq;

namespace AtividadesPropostasMatriz3
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
            int maior;
            for (int i = 0; i < n; ++i)
            {
                maior = 0;
                for (int j = 0; j < n; ++j)
                {
                    if (matrizSquare[i, j] > maior)
                    {
                        maior = matrizSquare[i, j];
                    }
                    
                }
                Console.WriteLine(maior);

            }
        }
    }
}
