using System;

namespace uri1080MaiorNumeroPosicao
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxValue = 0,
                queuePosition = 0,
                number = 0;
            for (int i = 1; i <= 100; i++)
            {
                number = int.Parse(Console.ReadLine());
                if (number > maxValue)
                {
                    maxValue = number;
                    queuePosition = i;
                }
            }
            Console.WriteLine(maxValue);
            Console.WriteLine(queuePosition);
        }
    }
}
