using System;

namespace uri1154AtividadeDeMediaDeIdades
{
    class Program
    {
        static void Main(string[] args)
        {

            //Faça um algoritmo para ler um número indeterminado de dados, contendo cada um, a idade de um indivíduo.
            //O último dado, que não entrará nos cálculos, contém o valor de idade negativa.
            //Calcular e imprimir a idade média deste grupo de indivíduos.
            //A entrada contém um número indeterminado de inteiros.
            //A entrada será encerrada quando um valor negativo for lido.
            //A saída contém um valor correspondente à média de idade dos indivíduos.
            //A média deve ser impressa com dois dígitos após o ponto decimal.

            int idades = 0;
            double soma = 0;
            int countAge = 0;
            bool positiveAges = idades >= 0;

            while (positiveAges)
            {
                idades = int.Parse(Console.ReadLine());
                if (idades > 0)
                {
                    soma += idades;
                    countAge++;

                }
                positiveAges = idades >= 0;
            }

            double media = soma / countAge;
            Console.WriteLine(media.ToString("F2"));
        }
    }
}
