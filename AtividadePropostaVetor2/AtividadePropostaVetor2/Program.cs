using System;
using System.Linq;

namespace AtividadePropostaVetor2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] numberInVet = Console.ReadLine()
                                       .Split(' ')
                                       .Select(n => int.Parse(n))
                                       .OrderByDescending(n => n) //serve para ordenar do maior pro menor
                                       .ToArray();

            int cont = 0;

            foreach (int number in numberInVet)
            {
                if (number % 2 == 0)
                {
                    Console.Write(number + " ");
                    cont++;
                }
            }
            Console.WriteLine();
            Console.WriteLine(cont);
        }
    }
}
