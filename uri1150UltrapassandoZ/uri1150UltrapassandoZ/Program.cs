using System;

namespace uri1150UltrapassandoZ
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int z, count = 1;

            do
            {
                z = int.Parse(Console.ReadLine());
            } while (z <= x);


            for (int i = x; i < z; i++)
            {
                int soma = i + (x + 1);
                i = soma;
                count++;
            }
            Console.WriteLine(count);
        }
    }
}
