using System;
using System.Globalization;

namespace uri1014
{
    class Program
    {
        static void Main(string[] args)
        {
            int distancia;
            double combustivelGasto;
            distancia = int.Parse(Console.ReadLine());
            combustivelGasto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double comsumoMedio = distancia / combustivelGasto;
            Console.WriteLine(comsumoMedio.ToString("F3") + " km/l");
        }
    }
}
