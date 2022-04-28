using System;
using System.Globalization;

namespace uri1060
{
    class Program
    {
        public static NumberStyles Cul { get; private set; }

        static void Main(string[] args)
        {
            int countPositive = 0;
            double somaPosite = 0,
                   media = 0;
            for (int i = 0; i < 6; i++)
            {
                double numeros = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (numeros > 0)
                {
                    countPositive++;
                    somaPosite = somaPosite + numeros;

                }

            }
            media = somaPosite / countPositive;
            Console.WriteLine(countPositive + " valores positivos");
            Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));
        }
    }
}