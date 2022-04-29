using System;
using System.Linq;

namespace AtividadeCorrigidaRepetiçao
{
    class Program
    {
        static void Main(string[] args)
        {
            double media, soma = 0.00;
            int quantidade = 0;
            double numeros = double.Parse(Console.ReadLine());

            while (numeros > 0)
            {
                quantidade++;
                soma += numeros;
                numeros = int.Parse(Console.ReadLine());

            }

            if (quantidade == 0)
            {
                Console.WriteLine("Imposivel calcular");
            }
            else
            {
                media = soma / quantidade;
                Console.WriteLine(media.ToString("F2"));
            }
        }
    }
}
