using System;

namespace uri1153FatorialSimples
{
    class Program
    {
        static void Main(string[] args)
        {

            int numero = int.Parse(Console.ReadLine());
            int fatorial = numero;
            for (int i = numero - 1; i >= 1; --i)
            {
                fatorial *= i;
            }
            Console.WriteLine(fatorial);
        }
    }
}
