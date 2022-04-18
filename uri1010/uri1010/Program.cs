using System;
using System.Globalization;

namespace uri1010
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] peace1 = Console.ReadLine().Split(' ');
            string[] peace2 = Console.ReadLine().Split(' ');

            int id1 = int.Parse(peace1[0]);
            int id2 = int.Parse(peace2[0]);
            int quantidade1 = int.Parse(peace1[1]);
            int quantidade2 = int.Parse(peace2[1]);
            double valor1 = double.Parse(peace1[2], CultureInfo.InvariantCulture);
            double valor2 = double.Parse(peace2[2], CultureInfo.InvariantCulture);

            double valorTotalPago = (quantidade1 * valor1) + (quantidade2 * valor2);
            Console.WriteLine("VALOR A PAGAR: R$ "+valorTotalPago.ToString("F2",CultureInfo.InvariantCulture));
        }
    }
}
