using System;
using System.Globalization;

namespace AtividadesPropostosVetor7
{
    class Program
    {
        private static NumberStyles cul;

        static void Main(string[] args)
        {
            int persons = int.Parse(Console.ReadLine());

            string[] names = new string[persons];
            double[] nota1 = new double[persons];
            double[] nota2 = new double[persons];



            for (int i = 0; i < persons; i++)
            {
                string[] aux = Console.ReadLine().Split(' ');
                names[i] = aux[0];
                nota1[i] = double.Parse(aux[1],CultureInfo.InvariantCulture);
                nota2[i] = double.Parse(aux[2],CultureInfo.InvariantCulture);

            }
            Console.WriteLine("Alunos aprovados");
            for (int i = 0; i < persons; i++)
            {
                double media = (nota1[i] + nota2[i]) / 2;


                if (media >= 6)
                {
                    Console.WriteLine(names[i]);
                }
            }
        }
    }

}
