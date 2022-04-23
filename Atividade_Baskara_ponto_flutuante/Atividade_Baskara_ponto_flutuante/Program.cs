using System;
using System.Globalization;

namespace Atividade_Baskara_ponto_flutuante
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vet = Console.ReadLine().Split(' ');
            double a = double.Parse(vet[0], CultureInfo.InvariantCulture);
            double b = double.Parse(vet[1], CultureInfo.InvariantCulture);
            double c = double.Parse(vet[2], CultureInfo.InvariantCulture);

            double delta = (Math.Pow(b, 2) - 4 * a * c);

            double r1 = ((-b) + Math.Sqrt(delta)) / (2 * a);
            double r2 = ((-b) - Math.Sqrt(delta)) / (2 * a);

            if (a == 0 || delta < 0)
            {
                Console.WriteLine("Impossivel calcular");
            }
            else
            {
                Console.WriteLine("R1 = " + r1.ToString("F5"), CultureInfo.InvariantCulture);
                Console.WriteLine("R2 = " + r2.ToString("F5"), CultureInfo.InvariantCulture);
            }




        }
    }
}
