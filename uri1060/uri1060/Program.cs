using System;

namespace uri1060
{
    class Program
    {
        static void Main(string[] args)
        {
            int countPositive = 0;
            for (int i = 0; i < 6; i++)
            {
                double numeros = double.Parse(Console.ReadLine());
                
                if ( numeros > 0)
                {
                    countPositive ++;
                }
                
            }

            Console.WriteLine(countPositive + " valores positivos");
        }
    }
}