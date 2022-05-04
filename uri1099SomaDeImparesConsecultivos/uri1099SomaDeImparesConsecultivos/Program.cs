using System;
using System.Linq;

namespace uri1099SomaDeImparesConsecultivos
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = int.Parse(Console.ReadLine());
            int maior, menor;
            for (int i = 0; i < numero; i++)
            {
                int soma = 0;
                int[] vet = Console.ReadLine().Split(' ').Select(e => int.Parse(e)).ToArray();
                if (vet[0] > vet[1])
                {
                    maior = vet[0];
                    menor = vet[1];
                }
                else
                {
                    maior = vet[1];
                    menor = vet[0];
                }

                for(int j =menor; j< maior; j++)
                {
                    if (j % 2 != 0 && j!=menor)
                    {
                        soma += j;
                    }
                }
                Console.WriteLine(soma);
                
            }

        }
    }
}
