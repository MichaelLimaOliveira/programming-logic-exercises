using System;

namespace AtividadesResolvidasMatriz3
{
    class Program
    {
        static void Main(string[] args)
        {
            int L, C;
            string[] s = Console.ReadLine().Split(' ');
            L = int.Parse(s[0]);
            C = int.Parse(s[1]);

            int[,] matriz = new int[L, C];

            int soma;

            for (int i = 0; i < L; i++)
            {
                soma = 0;
                s = Console.ReadLine().Split(' ');
                for (int j = 0; j < C; ++j)
                {
                    matriz[i, j] = int.Parse(s[j]);

                    soma += matriz[i,j];
                }
                Console.WriteLine(soma);
            }
        }
    }
}
