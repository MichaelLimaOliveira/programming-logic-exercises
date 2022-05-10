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
            // .Where do linq cria uma nova lista com base na condiçao passada dentro
            int cont = frase.Where(charDentroDaFrase => frasseDeTeste.Contains(charDentroDaFrase)).Count();
            Console.WriteLine(cont);
        }
    }
}
