using System;

namespace uri1078Tabuada
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                int soma = numero * i;
                Console.WriteLine(i + " x " + numero + " = " +soma);
            }
        }
    }
}
