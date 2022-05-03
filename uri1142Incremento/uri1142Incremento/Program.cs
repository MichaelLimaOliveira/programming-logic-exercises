using System;

namespace uri1142Incremento
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int incremento = 1;

            for (int i = 0; i < n; i++)
            {

                for (int j = incremento; j <= (incremento + 2); j++)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine("PUM");
                incremento += 4;
            }
        }
    }
}
