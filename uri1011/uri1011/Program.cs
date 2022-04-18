using System;

namespace uri1011
{
    class Program
    {
        static void Main(string[] args)
        {
            double pi = 3.14159, raio;
            raio = double.Parse(Console.ReadLine());

            double volume = (4.0 / 3.0) * pi * Math.Pow(raio, 3);

            Console.WriteLine("VOLUME = " +volume.ToString("F3"));

        }
    }
}
