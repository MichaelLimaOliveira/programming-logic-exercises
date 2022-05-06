using System;
using System.Linq;

namespace uri1149SomandoInteiroConsecultivos
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] VetNumber = Console.ReadLine().Split(' ').Select(n => int.Parse(n)).ToArray();
            int soma = 0;
            for(int i = 0; i< VetNumber.Last(); i++)
            {
                soma += (i+VetNumber[0]);
            }
            Console.WriteLine(soma);
        }
    }
}
