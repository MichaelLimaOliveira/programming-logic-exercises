using System;

namespace Atividade_split_2_cs
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names1, names2;
            names1 = Console.ReadLine().Split(' ');
            names2 = Console.ReadLine().Split(' ');

            string name1 = names1[0];
            string name2 = names2[0];
            double idade1 = double.Parse(names1[1]);
            double idade2 = double.Parse(names2[1]);

            double media = (idade1 + idade2) / 2;
            Console.WriteLine("A idade media de " + name1 + " e " + name2 + " é de " + media + " anos");


        }
    }
}
