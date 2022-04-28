using System;

namespace uri1065
{
    class Program
    {
        static void Main(string[] args)
        {
            int isPar = 0, countPar = 0;
            for (int i = 0; i < 5; i++)
            {
                int numbers = int.Parse(Console.ReadLine());
                isPar = numbers % 2;

                if (isPar == 0)
                {
                    countPar++;
                    
                }

            }
            Console.WriteLine(countPar + " valores pares");
        }
    }
}
