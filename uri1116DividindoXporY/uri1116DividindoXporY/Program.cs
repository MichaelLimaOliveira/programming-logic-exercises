using System;
using System.Linq;

namespace uri1116DividindoXporY
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double divisao;

            for (int i = 0; i < n; i++)
            {
                divisao = 0;
                double[] numbers = Console.ReadLine()
                                       .Split(' ')
                                       .Select(number => double.Parse(number))
                                       .ToArray();
                if (numbers[1] != 0)
                {
                    divisao = numbers[0]/ numbers[1];
                    Console.WriteLine(divisao.ToString("F1"));
                }
                else
                {
                    Console.WriteLine("divisao impossivel");
                }
                
            }
        }
    }
}
