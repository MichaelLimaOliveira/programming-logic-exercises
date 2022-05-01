using System;
using System.Globalization;

namespace uri1117ValidacaoDeNotas
{
    class Program
    {
        static void Main(string[] args)
        {
            double soma = 0;
            int validar = 0, quantidadeDeNotas = 0;
            bool notaValida = validar != 2;

            while (notaValida)
            {

                double notas = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                bool rangeDasNotasPermitidas = notas >= 0 && notas <= 10;

                if (rangeDasNotasPermitidas)
                {
                    validar++;
                    soma += notas;
                    quantidadeDeNotas++;
                }
                else
                {
                    Console.WriteLine("nota invalida");
                }

                notaValida = validar != 2;
            }
            double media = soma / quantidadeDeNotas;
            Console.WriteLine("media = " + media.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
