using System;
using System.Linq;

namespace uri1094Experiencias
{
    class Program
    {
        static void Main(string[] args)
        {
            int countTest = int.Parse(Console.ReadLine());
            int totalDeCobaias = 0,
                totalDeCoelhos = 0,
                totalDeRatos = 0,
                totalDeSapos = 0;
            for (int i = 0; i < countTest; i++)
            {
                string[] entrada = Console.ReadLine().Split(' ').ToArray();
                int entradaAtual = int.Parse(entrada[0]);
                totalDeCobaias += entradaAtual;
                if (entrada[1] == "C")
                {
                    totalDeCoelhos += entradaAtual;
                }
                else if (entrada[1] == "R")
                {
                    totalDeRatos += entradaAtual;
                }
                else if (entrada[1] == "S")
                {
                    totalDeSapos += entradaAtual;
                }
            }
            double PercentualDeCoelhos = totalDeCoelhos * 100.00 / totalDeCobaias;
            double PercentualDeRatos = totalDeRatos * 100.00 / totalDeCobaias;
            double PercentualDeSapos = totalDeSapos * 100.00 / totalDeCobaias;
            Console.WriteLine("Total: " + totalDeCobaias + " cobaias");
            Console.WriteLine("Total de coelhos: " + totalDeCoelhos);
            Console.WriteLine("Total de ratos: " + totalDeRatos);
            Console.WriteLine("Total de sapos: " + totalDeSapos);
            Console.WriteLine("Percentual de coelhos: " + PercentualDeCoelhos.ToString("F2") + " %");
            Console.WriteLine("Percentual de ratos: " + PercentualDeRatos.ToString("F2") + " %");
            Console.WriteLine("Percentual de sapos: " + PercentualDeSapos.ToString("F2") + " %");
        }
    }
}
