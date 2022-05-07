using System;

namespace AtividadesResolvidasVetor4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string[] vet = new string[n];

            for (int i = 0; i < n; i++)
            {
                vet[i] = Console.ReadLine();

            }
            foreach (string elemento in vet)
            {
                Console.WriteLine(elemento);

            }
        }
    }
}
