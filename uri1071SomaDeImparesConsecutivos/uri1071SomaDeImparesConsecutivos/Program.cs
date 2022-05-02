using System;

namespace uri1071SomaDeImparesConsecutivos
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, max, min, soma = 0;

            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());
            if (x > y)
            {
                max = x;
                min = y;
            }
            else
            {
                min = x;
                max = y;
            }

            for (int i = min; i < max; i++)
            {
                if (i % 2 != 0 && i!=min)
                {
                    soma += i;
                }
            }
            Console.WriteLine(soma);

        }
    }
}
