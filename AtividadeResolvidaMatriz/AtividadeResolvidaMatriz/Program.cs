using System;

namespace AtividadeResolvidaMatriz
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] linhasColunas = Console.ReadLine().Split(' ');
            int L = int.Parse(linhasColunas[0]);
            int C = int.Parse(linhasColunas[1]);

            int[,] matriz = new int[L, C];

            for (int i = 0; i < L; i++)
            {
                string[] aux = Console.ReadLine().Split(' ');
                for (int j = 0; j<C; ++j)
                {
                    matriz[i, j] = int.Parse(aux[j]);
                }
            }
            Console.WriteLine();

            for(int i = 0; i < L; i++)
            {
                for (int j = 0; j < C; ++j)
                {
                    Console.Write(matriz[i,j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
