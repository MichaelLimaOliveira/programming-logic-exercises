using System;
using System.Linq;

namespace Exemplos_de_bliblioteca_linq_cs
{
    class Program
    {
        static void Main(string[] args)
        {
            int maior = Console.ReadLine()
                               .Split(' ')
                               .Select(e => int.Parse(e))
                               .ToArray()
                               .Max();
            Console.WriteLine(maior + " eh o maior");
        }
    }
}