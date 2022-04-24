using System;

namespace Atividade_Numero_menor_cs
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vet = Console.ReadLine().Split(' ');

            int x = int.Parse(vet[0]);
            int y = int.Parse(vet[1]);
            int z = int.Parse(vet[2]);

            if (x < y && x < z)
            {
                Console.WriteLine("MENOR = " + x);
            }
            else if (y < z)
            {
                Console.WriteLine("MENOR = " + y);
            }
            else
            {
                Console.WriteLine("MENOR = " + z);
            }
        }
    }
}
