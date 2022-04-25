using System;

namespace uri1046
{
    class Program
    {
        static void Main(string[] args)
        {
            int resultado;
            string[] vet = Console.ReadLine().Split(' ');
            int horaInicial = int.Parse(vet[0]);
            int horaFinal = int.Parse(vet[1]);

            if (horaInicial > horaFinal)
            {
                resultado = (24 - horaInicial) + horaFinal;
                Console.WriteLine("O JOGO DUROU " + resultado + " HORA(S)");
            }
            else if (horaInicial < horaFinal)
            {
                resultado = horaFinal - horaInicial;
                Console.WriteLine("O JOGO DUROU " + resultado + " HORA(S)");
            }
            else
            {
                resultado = 24;
                Console.WriteLine("O JOGO DUROU " + resultado + " HORA(S)");
            }
        }
    }
}
