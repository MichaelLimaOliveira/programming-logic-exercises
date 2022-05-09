using System;

namespace AtividadesResolvidasMatriz2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[,] matrizQuadrada = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                string[] aux = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; ++j)
                {
                    matrizQuadrada[i, j] = int.Parse(aux[j]);
                }
            }
            Console.WriteLine("Diagonal principal: ");
            for (int i = 0; i < n; ++i)
            {
                Console.Write(matrizQuadrada[i,i] + " ");
            }
            Console.WriteLine();
            int cont = 0;
            for(int i = 0; i<n; i++)
            {
                for(int j = 0; j<n; ++j)
                {
                    if(matrizQuadrada[i,j] < 0)
                    {
                        cont++;
                    }
                }
            }

            Console.WriteLine("Quantidade de negativos = " + cont);
        }
    }
}
