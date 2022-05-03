using System;

namespace uri1143QuadradoeCubo
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int incremento;

            for (int i = 1; i <= n; i++)
            {
                incremento = i;
                int total = 1;
                for (int j = 0; j < 3; j++)
                {
                    total = incremento * total;
                    
                    if (j != 2)
                    {
                        Console.Write(total + " ");
                    }
                    else
                    {
                        Console.WriteLine(total);
                    }

                }


            }
        }
    }
}
