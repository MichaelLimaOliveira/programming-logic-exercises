using System;
using System.Linq;
using System.Globalization;

namespace AtividadesPropostasVetor9
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string[] produtos = new string[n];
            double[] precoDeCompra = new double[n];
            double[] precoDeVenda = new double[n];

            for (int i = 0; i < n; i++)
            {
                string[] aux = Console.ReadLine().Split(' ');
                produtos[i] = aux[0];
                precoDeCompra[i] = double.Parse(aux[1], CultureInfo.InvariantCulture);
                precoDeVenda[i] = double.Parse(aux[2], CultureInfo.InvariantCulture);

            }
            double dezPorcento;
            double vintePorcento;

            int contAbaixoDeDez = 0;
            int contAbaixoDeVinteAcimaDeDez = 0;
            int contAcimaDeVinte = 0;

            for (int i = 0; i < n; i++)
            {
                dezPorcento = (precoDeCompra[i] * 0.10) + precoDeCompra[i];
                vintePorcento = (precoDeCompra[i] * 0.20) + precoDeCompra[i];

                if (dezPorcento > precoDeVenda[i])
                {
                    contAbaixoDeDez++;
                }
                else if (precoDeVenda[i] >= dezPorcento && precoDeVenda[i] <= vintePorcento)
                {
                    contAbaixoDeVinteAcimaDeDez++;
                }
                else if (precoDeVenda[i] > vintePorcento)
                {
                    contAcimaDeVinte++;
                }

            }

            double totalDeCompra = precoDeCompra.Sum();
            double totalDeVenda = precoDeVenda.Sum();

            double lucroTotal = totalDeVenda - totalDeCompra;


            Console.WriteLine("Lucro abaixo de 10%: " + contAbaixoDeDez);
            Console.WriteLine("Lucro entre 10% e 20%: " + contAbaixoDeVinteAcimaDeDez);
            Console.WriteLine("Lucro acima de 20%: " + contAcimaDeVinte);
            Console.WriteLine("Valor total de compra: " + totalDeCompra.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor total de venda: " + totalDeVenda.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Lucro total: " + lucroTotal.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
