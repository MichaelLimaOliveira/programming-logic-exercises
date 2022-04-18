using System;

namespace uri1017
{
    class Program
    {
        static void Main(string[] args)
        {
            int tempoGasto, velocidadeMedia;
            double distanciaPercorrida;
            tempoGasto = int.Parse(Console.ReadLine());
            velocidadeMedia = int.Parse(Console.ReadLine());

            distanciaPercorrida = tempoGasto * velocidadeMedia;
            double consumo = distanciaPercorrida / 12;
            Console.WriteLine(consumo.ToString("F3"));

        }
    }
}
