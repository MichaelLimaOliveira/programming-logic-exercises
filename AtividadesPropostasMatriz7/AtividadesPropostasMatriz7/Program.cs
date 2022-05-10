using System;

namespace AtividadesPropostasMatriz7
{
    class Program
    {
        static void Main(string[] args)
        {
            int L = int.Parse(Console.ReadLine());
            int C = int.Parse(Console.ReadLine());

            int[,] soldiers = new int[L, C];

            for (int i = 0; i < L; i++)
            {
                string[] aux = Console.ReadLine().Split(' ');
                for (int j = 0; j < C; j++)
                {
                    soldiers[i, j] = int.Parse(aux[j]);
                }
            }

            int spinLine = int.Parse(Console.ReadLine());
            int[] selectLine = new int[C];

            for (int i = 0; i < C; i++)
            {
                if (i == 0)
                {
                    selectLine[i] = soldiers[spinLine - 1, C - 1];
                }
                else
                {
                    selectLine[i] = soldiers[spinLine - 1, i - 1];
                }


            }
            for (int i = 0; i < C; i++)
            {
                soldiers[spinLine - 1, i] = selectLine[i];

            }

            for (int i = 0; i < L; i++)
            {
                for (int j = 0; j < C; j++)
                {
                    Console.Write(soldiers[i, j] + " ");
                }
                Console.WriteLine();
            }


        }
    }
}
