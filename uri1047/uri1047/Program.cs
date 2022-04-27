using System;
using System.Linq;

namespace uri1047
{
    class Program
    {
        static void Main(string[] args)
        {
            int horaInicial, minutoInicial, horaFinal, minutoFinal, horasTotal, minutosTotal;
            int[] entrada = Console.ReadLine().Split(' ').Select(e => int.Parse(e)).ToArray();
            horaInicial = entrada[0];
            minutoInicial = entrada[1];
            horaFinal = entrada[2];
            minutoFinal = entrada[3];

            int tempoInicial = (horaInicial * 60) + minutoInicial;
            int tempoFinal = (horaFinal * 60) + minutoFinal;
            int duracao;

            if (tempoInicial < tempoFinal)
            {
                duracao = tempoFinal - tempoInicial;
            }
            else
            {
                duracao = (24 * 60 - tempoInicial) + tempoFinal;
            }

            horasTotal = duracao / 60;
            minutosTotal = duracao % 60;

            Console.WriteLine("O JOGO DUROU " + horasTotal + " HORA(S) E " + minutosTotal + " MINUTO(S)");

        }
    }
}
