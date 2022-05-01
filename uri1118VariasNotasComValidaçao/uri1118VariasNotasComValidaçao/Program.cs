using System;

namespace uri1118VariasNotasComValidaçao
{
    class Program
    {
        static void Main(string[] args)
        {
            int novoCalculo = 1;

            while (novoCalculo == 1)
            {
                int quantidadeDeNotas = 0;
                double media = 0.00,
                       somaDasNotas = 0.00;

                while (quantidadeDeNotas < 2)
                {
                    double notas = double.Parse(Console.ReadLine());
                    if (notas >= 0 && notas <= 10)
                    {
                        somaDasNotas += notas;
                        quantidadeDeNotas++;
                    }
                    else
                    {
                        Console.WriteLine("nota invalida");
                    }

                }
                media = somaDasNotas / 2;
                Console.WriteLine("media = " + media.ToString("F2"));

                do
                {


                    Console.WriteLine("novo calculo (1-sim 2-nao)");
                    novoCalculo = int.Parse(Console.ReadLine());
                } while (novoCalculo != 1 && novoCalculo != 2);
            }
        }
    }
}
