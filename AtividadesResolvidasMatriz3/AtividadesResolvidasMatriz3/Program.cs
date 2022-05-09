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


            int[] vetSoma = new int[L];
            for (int i = 0; i < L; i++)
            {

                s = Console.ReadLine().Split(' ');
                for (int j = 0; j < C; ++j)
                {
                    matriz[i, j] = int.Parse(s[j]);

                    vetSoma[i] = vetSoma[i] + matriz[i, j];
                }

            }
            Console.WriteLine(vetSoma[0]);
            Console.WriteLine(vetSoma[1]);
        }
    }
}
