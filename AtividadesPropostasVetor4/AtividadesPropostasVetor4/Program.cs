using System;
using System.Globalization;
using System.Linq;

namespace AtividadesPropostasVetor4
{
    class Program
    {
        private static NumberStyles culr;

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double[] Numbers = Console.ReadLine().Split(' ').Select(n => double.Parse(n, CultureInfo.InvariantCulture)).ToArray();

            double media = Numbers.Sum() / n;
            Console.WriteLine(media.ToString("F3", CultureInfo.InvariantCulture));

            foreach(double number in Numbers)
            {
                if(number < media)
                {
                    Console.WriteLine(number.ToString("F1", CultureInfo.InvariantCulture));
                }
            }
        }
    }
}
