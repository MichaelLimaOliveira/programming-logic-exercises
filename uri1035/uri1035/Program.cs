using System;

namespace uri1035
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vet = Console.ReadLine().Split(' ');
            int a = int.Parse(vet[0]); // 2 3 2 6
            int b = int.Parse(vet[1]);
            int c = int.Parse(vet[2]);
            int d = int.Parse(vet[3]);

            int somaCeD = c + d;
            int somaAeB = a + b;
            int par = a % 2;

            if (b > c && d > a && somaCeD > somaAeB && c > 0 && d > 0 && par == 0)
            {

                Console.WriteLine("Valores aceitos");

            }
            else
            {
                Console.WriteLine("Valores nao aceitos");
            }
        }
    }
}
