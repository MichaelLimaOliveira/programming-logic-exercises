using System;

namespace uri1044
{
    class Program
    {
        static void Main(string[] args)
        {
            int valorMaior, valorMenor;
            string[] vet = Console.ReadLine().Split(' ');
            int a = int.Parse(vet[0]);
            int b = int.Parse(vet[1]);

            if (a > b)
            {
                valorMaior = a;
                valorMenor = b;
            }
            else
            {
                valorMaior = b;
                valorMenor = a;
            }
            int resto = valorMaior % valorMenor;

            switch (resto)
            {
                case 0:
                    Console.WriteLine("Sao Multiplos");
                    break;
                default:
                    Console.WriteLine("Nao sao Multiplos");
                    break;
            }
        }
    }
}
