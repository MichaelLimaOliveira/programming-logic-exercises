using System;
using System.Globalization;

namespace AtividadeResolvidaVetor3
{
    class Program
    {
        private static NumberStyles cul;

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] names = new string[n];
            int[] age = new int[n];
            double[] heigth = new double[n];

            //leitura dos dados
            for (int i = 0; i < n; i++)
            {
                string[] aux = Console.ReadLine().Split(' ');
                names[i] = aux[0];
                age[i] = int.Parse(aux[1]);
                heigth[i] = double.Parse(aux[2], CultureInfo.InvariantCulture);
            }

            //calculo da altura media das pessoas

            double soma = 0.0;
            for (int i = 0; i < n; i++)
            {
                soma = soma + heigth[i];

            }
            double media = soma / n;
            Console.WriteLine("Altura média: " + media.ToString("F2", CultureInfo.InvariantCulture));

            //porcentagem de pessoas abaixo de 16 anos

            int cont = 0;
            for (int i = 0; i < n; i++)
            {
                if (age[i] < 16)
                {
                    cont++;
                }
            }

            double porcentagem = (double)cont / n * 100.0;
            Console.WriteLine("Pessoas com menos de 16 anos: " + porcentagem.ToString("F1", CultureInfo.InvariantCulture) + "%");

        }
    }
}
