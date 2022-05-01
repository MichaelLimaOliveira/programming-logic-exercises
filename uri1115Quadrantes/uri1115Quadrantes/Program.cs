using System;
using System.Linq;

namespace uri1115Quadrantes
{
    class Program
    {
        static void Main(string[] args)
        {
            string quadrante = " ";

            int[] positions = Console.ReadLine().Split(' ').Select(position => int.Parse(position)).ToArray();

            bool naoSaoNulos = positions[0] == 0 || positions[1] == 0;

            while (!naoSaoNulos)
            {
                bool isQ1 = positions[0] > 0 && positions[1] > 0,
                     isQ2 = positions[0] < 0 && positions[1] > 0,
                     isQ3 = positions[0] < 0 && positions[1] < 0,
                     isQ4 = positions[0] > 0 && positions[1] < 0;

                if (isQ1)
                {
                    quadrante = "primeiro";
                }
                else if (isQ2)
                {
                    quadrante = "segundo";
                }
                else if (isQ3)
                {
                    quadrante = "terceiro";
                }
                else if (isQ4)
                {
                    quadrante = "quarto";
                }
                Console.WriteLine(quadrante);
                positions = Console.ReadLine().Split(' ').Select(position => int.Parse(position)).ToArray();

                naoSaoNulos = positions[0] == 0 || positions[1] == 0;

            }

        }
    }
}
