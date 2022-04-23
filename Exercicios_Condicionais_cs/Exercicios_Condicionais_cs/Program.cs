using System;
using System.Globalization;

namespace Exercicios_Condicionais_cs
{
    class Program
    {
        static void Main(string[] args)
        {
            double nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double nota2 = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            double notaFinal = nota1 + nota2;

            Console.WriteLine("NOTA FINAL = " + notaFinal.ToString("F1"),CultureInfo.InvariantCulture);
            if(notaFinal < 60.00)
            {
                Console.WriteLine("REPROVADO");
            }
        }
    }
}
