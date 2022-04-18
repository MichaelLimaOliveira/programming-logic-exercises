using System;

namespace Atividade_de_Split_CS
{
    class Program
    {
        static void Main(string[] args)
        {
            string frase = Console.ReadLine();

            Console.WriteLine();

            string c1 = Console.ReadLine();
            string c2 = Console.ReadLine();
            string c3 = Console.ReadLine();

            Console.WriteLine();

            string[] colorSplit = Console.ReadLine().Split(' ');
            string cs1 = colorSplit[0];
            string cs2 = colorSplit[1];
            string cs3 = colorSplit[2];

            Console.WriteLine("Você digitou: ");
            Console.WriteLine(frase);
            Console.WriteLine(c1);
            Console.WriteLine(c2);
            Console.WriteLine(c3);
            Console.WriteLine(cs1);
            Console.WriteLine(cs2);
            Console.WriteLine(cs3);

        }
    }
}
