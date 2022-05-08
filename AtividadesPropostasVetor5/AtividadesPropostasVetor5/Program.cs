using System;
using System.Globalization;
using System.Linq;

namespace AtividadesPropostasVetor5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] numberInVet = Console.ReadLine().Split(' ').Select(number => int.Parse(number)).ToArray();
            int soma = numberInVet.Sum();
            double media = (double)soma / n;

            Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));
        }
    }
}
