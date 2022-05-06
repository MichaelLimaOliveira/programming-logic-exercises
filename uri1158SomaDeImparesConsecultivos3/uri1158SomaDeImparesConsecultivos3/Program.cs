using System;
using System.Linq;

namespace uri1158SomaDeImparesConsecultivos3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            
            for (int i = 0; i < n; i++)
            {
                int soma = 0;
                int h = 0;
                int[] vetDados = Console.ReadLine().Split(' ').Select(e => int.Parse(e)).ToArray();

                int valor = vetDados[0];
                while (h != vetDados[1])
                {
                    if (valor % 2 != 0)
                    {
                        soma += valor;
                        h++;
                    }
                    valor++;
                }
                Console.WriteLine(soma);
            }
        }
    }
}
