using System;
using System.Linq;

namespace AtividadePropostasVetor6
{
    class Program
    {
        static void Main(string[] args)
        {
            int contPerson = int.Parse(Console.ReadLine());
            string[] names = new string[contPerson];
            int[] ages = new int[contPerson];
            int maxAge = 0;
            string nameMaxAge = "";

            for (int i = 0; i < contPerson; i++)
            {
                string[] aux = Console.ReadLine().Split(' ');
                names[i] = aux[0];
                ages[i] = int.Parse(aux[1]);

                if (ages[i] > maxAge)
                {
                    maxAge = ages[i];
                    nameMaxAge = names[i];
                }
            }



            Console.WriteLine("Pessoa mais velha: " + nameMaxAge);

        }
    }
}
