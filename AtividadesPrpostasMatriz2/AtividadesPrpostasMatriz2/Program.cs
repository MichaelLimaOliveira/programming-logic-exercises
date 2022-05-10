using System;

namespace AtividadesPrpostasMatriz2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[,] matriz = new int[n, n];

            int soma;
            for (int i = 0; i < n; ++i)
            {
                string[] aux = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; ++j)
                {
                    matriz[i, j] = int.Parse(aux[j]);
                }
            }


            for (int i = 0; i < n; ++i)
            {
                soma = 0;
                for (int j = 0; j < n; ++j)
                {
                    soma += matriz[i, j];
                }
                Console.WriteLine(soma);
            }
        }

    }
}
