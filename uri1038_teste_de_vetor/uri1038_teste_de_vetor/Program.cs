using System;

namespace uri1038_teste_de_vetor
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] vet = new double[] { 4.00, 4.50, 5.00, 2.00, 1.50 };
            string[] valorDigitado = Console.ReadLine().Split(' ');
            int codigo = int.Parse(valorDigitado[0]);
            int quantidade = int.Parse(valorDigitado[1]);

            double valorPago = vet[codigo - 1] * quantidade;
            Console.WriteLine("Total: R$ " + valorPago.ToString("F2"));
        }
    }
}
