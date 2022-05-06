using System;
using System.Linq;

namespace uri1160CrescimentoPopulacional
{
    class Program
    {
        static void Main(string[] args)
        {
            int Cities = int.Parse(Console.ReadLine());

            for (int i = 0; i < Cities; i++)
            {
                string[] vetData = Console.ReadLine().Split(' ');
                int pa = int.Parse(vetData[0]);
                int pb = int.Parse(vetData[1]);
                double gA = double.Parse(vetData[2]);
                double gB = double.Parse(vetData[3]);

                double crescimentoPorAnoA = 0;
                double crescimentoPorAnoB = 0;
                int anos = 0;


                while (pa <= pb)
                {
                    crescimentoPorAnoA = pa * gA / 100;
                    pa += (int)crescimentoPorAnoA;
                    crescimentoPorAnoB = pb * gB / 100;
                    pb += (int)crescimentoPorAnoB;

                    anos++;
                }
                if (anos > 100)
                {
                    Console.WriteLine("Mais de 1 seculo.");
                }
                else
                {
                    Console.WriteLine(anos + " anos.");
                }
                
            }
        }
    }
}
