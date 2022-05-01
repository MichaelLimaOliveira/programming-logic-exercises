using System;

namespace uri1159AtividadeSomaDePares
{
    class Program
    {
        static void Main(string[] args)
        {
            //O programa deve ler um valor inteiro X indefinidas vezes.
            //(O programa irá parar quando o valor de X for igual a 0).
            //Para cada X lido, imprima a soma dos 5 pares consecutivos a partir de X, inclusive o X , se for par.
            //Se o valor de entrada for 4, por exemplo, a saída deve ser 40, que é o resultado da operação: 4+6+8+10+12,
            //enquanto que se o valor de entrada for 11, por exempo, a saída deve ser 80, que é a soma de 12+14+16+18+20.
            int numbers = int.Parse(Console.ReadLine());
               int soma,
                   somaTotal = 0;

            bool isPar, isImpar;

            while (numbers != 0)
            {

                somaTotal = 0;
                soma = 0;
                isPar = numbers % 2 == 0 && numbers != 0;
                isImpar = numbers % 2 != 0 && numbers != 0;

                if (isPar)
                {
                    soma = numbers;
                    for (int i = 0; i < 4; i++)
                    {
                        soma = soma + 2;
                        somaTotal = soma + somaTotal;
                    }
                    somaTotal += numbers;
                    Console.WriteLine(somaTotal);
                }
                else if (isImpar)
                {
                    soma = numbers + 1;
                    for (int i = 0; i < 4; i++)
                    {
                        soma = soma + 2;
                        somaTotal = soma + somaTotal;
                    }
                    somaTotal += numbers + 1;
                    Console.WriteLine(somaTotal);
                }
                numbers = int.Parse(Console.ReadLine());

            }


        }
    }
}