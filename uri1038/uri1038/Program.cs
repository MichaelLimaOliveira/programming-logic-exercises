using System;
using System.Globalization;

namespace uri1038
{
    class Program
    {
        static void Main(string[] args)
        {
            double cachorroQuente = 4.00,
                   xSalada = 4.50,
                   xBacon = 5.00,
                   torradaSimples = 2.0,
                   refrigerante = 1.50,
                   valor;
            string[] vet = Console.ReadLine().Split(' ');
            int codigo = int.Parse(vet[0]);
            int quantidade = int.Parse(vet[1]);
            switch (codigo)
            {
                case 1:
                    valor = cachorroQuente * quantidade;
                    Console.WriteLine("Total: R$ " + valor.ToString("F2"));
                    break;
                case 2:
                    valor = xSalada * quantidade;
                    Console.WriteLine("Total: R$ " + valor.ToString("F2"));
                    break;
                case 3:
                    valor = xBacon * quantidade;
                    Console.WriteLine("Total: R$ " + valor.ToString("F2"));
                    break;
                case 4:
                    valor = torradaSimples * quantidade;
                    Console.WriteLine("Total: R$ " + valor.ToString("F2"));
                    break;
                case 5:
                    valor = refrigerante * quantidade;
                    Console.WriteLine("Total: R$ " + valor.ToString("F2"));
                    break;
                default:
                    break;

            }


        }
    }
}
