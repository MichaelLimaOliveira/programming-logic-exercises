using System;
using System.Globalization;

namespace Atividade_Area_Do_Circulo_cs
{
    class Program
    {
        static void Main(string[] args)
        {
            double pi = 3.14159;
            double radius = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            double area = pi * (Math.Pow(radius, 2));
            Console.WriteLine("A=" + area.ToString("F4",CultureInfo.InvariantCulture));
        }
    }
}
