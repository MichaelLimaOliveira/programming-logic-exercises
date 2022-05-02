using System;
using System.Globalization;

namespace uri1097Sequencia2
{
    class Program
    {
        static void Main(string[] args)
        {
            int jInicial = 7;

            for (int i = 1; i <= 9; i += 2)
            {
                for (int j = jInicial; j >= (jInicial - 2); j--)
                {
                    Console.WriteLine("I=" + i + " J=" + j);
                }
                jInicial += 2;
            }
        }
    }
}
