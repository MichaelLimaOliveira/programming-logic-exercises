using System;
using System.Linq;

namespace Atividade_funçoes_cs
{
    class Program
    {
        static void Main(string[] args)
        {
            Impressora impressora = new Impressora();
            Comparador comparador = new Comparador();
            Comparador iguais = new Comparador();
            Calculadora calc = new Calculadora();
            int numero1 = int.Parse(Console.ReadLine());
            int numero2 = int.Parse(Console.ReadLine());

            double valor1 = double.Parse(Console.ReadLine());
            double valor2 = double.Parse(Console.ReadLine());
            double valor3 = double.Parse(Console.ReadLine());


            int maiorNumero = comparador.RetornarOMaiorNumero(numero1, numero2);
            double mediaDosTres = calc.Media(valor1, valor2, valor3);
            bool numerosIguais = iguais.SaoIguas(numero1, numero2);

            impressora.ImpressoraMundial(maiorNumero.ToString());
            impressora.ImpressoraMundial(mediaDosTres.ToString());
            impressora.ImpressoraMundial(numerosIguais.ToString());




            Console.WriteLine();
            Console.WriteLine();

            int[] vetNumbers = Console.ReadLine()
                                      .Split(' ')
                                      .Select(number => int.Parse(number))
                                      .ToArray();

            double mediaDoVetor = calc.MediaDeVetor(vetNumbers);

            
            impressora.ImpressoraMundial(mediaDoVetor.ToString());

        }
    }

    public class Comparador
    {
        public int RetornarOMaiorNumero(int numero1, int numero2)
        {
            int maiorNumero = 0;

            if (numero1 > numero2)
            {
                maiorNumero = numero1;
            }
            else
            {
                maiorNumero = numero2;
            }
            return maiorNumero;
        }

        public bool SaoIguas(int numero1, int numero2)
        {
            return numero1 == numero2;
        }
    }

    public class Calculadora
    {
        public double Media(double valor1, double valor2, double valor3)
        {
            double media;
            media = (valor1 + valor2 + valor3) / 3;

            return media;
        }
        public double MediaDeVetor(int[] vet)
        {
            int countNumber = 0;
            double media, soma = 0;

            foreach (int n in vet)
            {
                countNumber++;
                soma += n;
            }

            media = (soma) / countNumber;
            return media;
        }
    }
    public class Impressora
    {
        public void ImpressoraMundial(string printMe)
        {
            string text = printMe;
            Console.WriteLine(text);
        }
    }
}
