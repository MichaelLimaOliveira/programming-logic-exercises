using System;
using System.Globalization;

namespace ExercicioResolvidoVetor2
{
    class Program
    {
        static void Main(string[] args)
        {
            int tamanhoDoVetor;
            tamanhoDoVetor = int.Parse(Console.ReadLine());

            double[] vetDeNumeros;
            vetDeNumeros = new double[tamanhoDoVetor];

            string[] vetDeStrings = Console.ReadLine().Split(' ');

            for (int i = 0; i < tamanhoDoVetor; i++)
            {
                vetDeNumeros[i] = double.Parse(vetDeStrings[i], CultureInfo.InvariantCulture);
            }
            for (int i = 0; i < tamanhoDoVetor; i++)
            {
                Console.Write(vetDeNumeros[i].ToString("F1", CultureInfo.InvariantCulture) + " ");
            }
            double soma = 0.0;
            for (int i = 0; i < tamanhoDoVetor; i++)
            {
                soma += vetDeNumeros[i];
            }
            double media = soma / tamanhoDoVetor;
            Console.WriteLine();
            Console.WriteLine(soma.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(media.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
