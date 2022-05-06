using System;
using System.Linq;

namespace uri1101SequenciaDeNumerosSoma
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] vetNumbers = Console.ReadLine()
                                      .Split(' ')
                                      .Select(number => int.Parse(number))
                                      .ToArray();

            while (vetNumbers[0] > 0 && vetNumbers[1] > 0)
            {         

                int max, min, soma = 0;
                if (vetNumbers[0] > vetNumbers[1])
                {
                    max = vetNumbers[0];
                    min = vetNumbers[1];

                }
                else
                {
                    max = vetNumbers[1];
                    min = vetNumbers[0];
                }

                for (int i = min; i <= max; i++)
                {
                    soma += i;
                    Console.Write(i + " ");
                }
                Console.WriteLine("Sum=" + soma);
                vetNumbers = Console.ReadLine()
                                      .Split(' ')
                                      .Select(number => int.Parse(number))
                                      .ToArray();
            }
        }

    }
}
