using System;

namespace uri1151Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor1 = 0;
            int valor2 = 1;

            int n = int.Parse(Console.ReadLine());
            Console.Write(valor1 + " " + valor2 + " ");
            for (int i = 2; i < n; ++i)
            {
                int valor3 = valor1 + valor2;
                if (i == n - 1)
                {
                    Console.WriteLine(valor3);
                }
                else
                {

                    Console.Write(valor3 + " ");

                }
                valor1 = valor2;
                valor2 = valor3;

            }


        }
    }
}
