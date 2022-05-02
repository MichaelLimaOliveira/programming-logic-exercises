using System;
using System.Linq;

namespace uri1079MediasPonderadas
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                double[] numbersVet = Console.ReadLine()
                                             .Split(' ')
                                             .Select(number => double.Parse(number))
                                             .ToArray();
                double mediaPonderada = 0;

                mediaPonderada = ((numbersVet[0] * 2) + (numbersVet[1] * 3) + (numbersVet[2] * 5)) / 10;
                Console.WriteLine(mediaPonderada.ToString("F1"));
            }
        }
    }
}
