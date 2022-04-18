using System;

namespace Atividade_Soma_simples_cs
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B, soma;
            A = int.Parse(Console.ReadLine());
            B = int.Parse(Console.ReadLine());
            soma = A + B;
            Console.WriteLine("SOMA = " + soma);

        }
    }
}
