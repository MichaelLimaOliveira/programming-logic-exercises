using System;

namespace uri1015
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] ponto1 = (Console.ReadLine().Split(' '));
            string[] ponto2 = (Console.ReadLine().Split(' '));

            double x1 = double.Parse(ponto1[0]);
            double y1 = double.Parse(ponto1[1]);
            double x2 = double.Parse(ponto2[0]);
            double y2 = double.Parse(ponto2[1]);

            double distancia = Math.Sqrt((Math.Pow((x2 - x1), 2)) + (Math.Pow((y2 - y1), 2)));
            Console.WriteLine(distancia.ToString("F4"));

        }
    }
}
