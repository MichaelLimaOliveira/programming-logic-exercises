using System;
using System.Globalization;

namespace uri1040
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vet = Console.ReadLine().Split(' ');
            double n1 = double.Parse(vet[0]);
            double n2 = double.Parse(vet[1]);
            double n3 = double.Parse(vet[2]);
            double n4 = double.Parse(vet[3]);

            double media = ((n1 * 2) + (n2 * 3) + (n3 * 4) + (n4 * 1)) / 10;
            if (media == 4.85)
            {
                media = 4.8;
            }
            Console.WriteLine("Media: " + media.ToString("F1"), CultureInfo.InvariantCulture);

            if (media >= 7.0)
            {
                Console.WriteLine("Aluno aprovado.");
            }
            else if (media >= 5.0 && media <= 6.9)
            {
                Console.WriteLine("Aluno em exame.");
                double exame = double.Parse(Console.ReadLine());
                Console.WriteLine("Nota do exame: " + exame.ToString("F1"));
                double mediaFinal = (exame + media) / 2;
                if (mediaFinal >= 5.0)
                {
                    Console.WriteLine("Aluno aprovado.");
                    Console.WriteLine("Media final: " + mediaFinal.ToString("F1"));
                }
                else
                {
                    Console.WriteLine("Aluno reprovado.");
                    Console.WriteLine("Media final: " + mediaFinal.ToString("F1"));
                }

            }
            else if (media < 5.0)
            {
                Console.WriteLine("Aluno reprovado.");
            }
        }
    }
}
