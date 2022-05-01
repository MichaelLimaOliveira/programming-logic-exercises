using System;
using System.Linq;

namespace uri1131Grenais
{
    class Program
    {
        static void Main(string[] args)
        {
            int novoGrenal = 1;
            int inter = 0, gremio = 0, empate = 0;
            int grenais = 0;
            string venceuMais;

            while (novoGrenal == 1)
            {


                int[] placar = Console.ReadLine()
                                       .Split(' ')
                                       .Select(e => int.Parse(e))
                                       .ToArray();

                if (placar[0] > placar[1])
                {
                    inter++;
                }
                else if (placar[0] < placar[1])
                {
                    gremio++;
                }
                else
                {
                    empate++;
                }


                do
                {


                    Console.WriteLine("Novo grenal (1-sim 2-nao)");
                    novoGrenal = int.Parse(Console.ReadLine());

                } while (novoGrenal != 1 && novoGrenal != 2);
                grenais++;

            }
            Console.WriteLine(grenais + " grenais");
            Console.WriteLine("Inter:" + inter);
            Console.WriteLine("Gremio:" + gremio);
            Console.WriteLine("Empates:" + empate);

            if (inter > gremio)
            {
                venceuMais = "Inter";
            }
            else if (inter < gremio)
            {
                venceuMais = "Gremio";

            }
            else
            {
                venceuMais = "Nao houve vencedor";
            }
            Console.WriteLine(venceuMais + " venceu mais");




        }
    }
}
