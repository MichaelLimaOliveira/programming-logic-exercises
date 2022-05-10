using System;

namespace AtividadesPropostasMatriz1
{
    class Program
    {
        static void Main(string[] args)
        {
            int L, C;
            string[] aux = Console.ReadLine().Split(' ');
            L = int.Parse(aux[0]);
            C = int.Parse(aux[1]);

            int[,] M = new int[L, C];

            for (int i = 0; i < L; ++i)
            {
                aux = Console.ReadLine().Split(' ');
                for (int j = 0; j<C; ++j)
                {
                    M[i, j] = int.Parse(aux[j]);
                }
            }

            Console.WriteLine("VALORES NEGATIVOS:");

            foreach(int m in M)
            {
                if(m < 0)
                {
                    Console.WriteLine(m);
                }
            }
        }
    }
}
