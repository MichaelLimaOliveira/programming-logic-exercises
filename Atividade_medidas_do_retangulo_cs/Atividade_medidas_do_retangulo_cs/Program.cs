using System;
using System.Globalization;

namespace Atividade_medidas_do_retangulo_cs
{
    class Program
    {
        static void Main(string[] args)
        {
            double b, a, area, perimetro, diagonal;
            b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            area = b * a;
            perimetro = (b * 2) + (a * 2);
            diagonal = Math.Sqrt((Math.Pow(b, 2)) + (Math.Pow(a, 2)));

            Console.WriteLine("AREA = " + area.ToString("F4"), CultureInfo.InvariantCulture);
            Console.WriteLine("PERIMETRO = " + perimetro.ToString("F4"), CultureInfo.InvariantCulture);
            Console.WriteLine("DIAGONAL = " + diagonal.ToString("F4"), CultureInfo.InvariantCulture);

        }
    }
}
