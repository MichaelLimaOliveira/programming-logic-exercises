using System;
using System.Linq;

namespace ExercicioVogaisExtraterrestres
{
    class Program
    {
        static void Main(string[] args)
        {
            string frasseDeTeste = Console.ReadLine();
            string frase = Console.ReadLine();
            int cont = frase.Where(c => frasseDeTeste.Contains(c)).Count();
            Console.WriteLine(cont);
        }
    }
}
