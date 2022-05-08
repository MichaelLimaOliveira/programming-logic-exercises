using System;
using System.Linq;
using System.Globalization;

namespace AtividadesPropostasVetor8
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double[] heights = new double[n];
            char[] sex = new char[n];

            double minHeight = 0.0;
            double maxHeight = 0.0;

            double soma = 0.0;
            int contF = 0;
            int contM = 0;

            for (int i = 0; i < n; i++)
            {
                string[] aux = Console.ReadLine().Split(' ');
                heights[i] = double.Parse(aux[0], CultureInfo.InvariantCulture);
                sex[i] = char.Parse(aux[1]);

                if (sex[i] == 'F')
                {
                    soma += heights[i];
                    contF++;
                }

                if (sex[i] == 'M')
                {
                    contM++;
                }
            }

            minHeight = heights.Min();
            maxHeight = heights.Max();

            double media = soma / contF;



            Console.WriteLine("Menor altura = " + minHeight.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Maior altura = " + maxHeight.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Media das alturas das mulheres = " + media.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Numero de homens = " + contM);


        }
    }
}
