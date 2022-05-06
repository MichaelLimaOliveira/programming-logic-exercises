using System;
using System.Linq;

namespace uri1145SequenciaLogica2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vetDados = Console.ReadLine()
                                    .Split(' ')
                                    .Select(e => int.Parse(e))
                                    .ToArray();
            
            int countLinha = 1;
            for (int i = 1; i <= vetDados[1]; i++)
            {
                if (countLinha == vetDados[0])
                {
                    Console.WriteLine(i);
                    countLinha = 1;
                }
                else
                {
                    Console.Write(i + " ");
                    countLinha++;
                }
                
            }
        }
    }
}
