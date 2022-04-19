using System;

namespace uri1013
{
    class Program
    {
        static void Main(string[] args)
        {
            int ganhouTeste1, ganhouteste2, verificarGanhador;
            string[] vet = Console.ReadLine().Split(' ');

            int maior = 0;
            for (int i = 0; i < vet.Length; i++)
            {
                string v = vet[i];
                int value = int.Parse(v);
                // if ternário
                maior = maior <= value ? value : maior;
                // essta linha de codigo abaixo simboliza oq o if ternario esta fazendo
                // if(maior <= value)
                // {
                //     maior = value;
                // }
                // else
                // {
                //     maior = maior;
                // }

            }
           

            Console.WriteLine(maior + " eh o maior");
        }
    }
}
