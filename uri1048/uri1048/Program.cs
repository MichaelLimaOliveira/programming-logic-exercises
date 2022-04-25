using System;
using System.Globalization;

namespace uri1048
{
    class Program
    {
        static void Main(string[] args)
        {

            double novoSalario, valorDeReajuste;
            double salario = double.Parse(Console.ReadLine());

            if (salario >= 0.00 && salario <= 400.00)
            {
                valorDeReajuste = 15 * salario / 100;
                novoSalario = salario + valorDeReajuste;
                Console.WriteLine("Novo salario: " + novoSalario.ToString("F2"));
                Console.WriteLine("Reajuste ganho: " + valorDeReajuste.ToString("F2"));
                Console.WriteLine("Em percentual: 15 %");
            }
            else if (salario >= 400.01 && salario <= 800.00)
            {
                valorDeReajuste = 12 * salario / 100;
                novoSalario = salario + valorDeReajuste;
                Console.WriteLine("Novo salario: " + novoSalario.ToString("F2"));
                Console.WriteLine("Reajuste ganho: " + valorDeReajuste.ToString("F2"));
                Console.WriteLine("Em percentual: 12 %");
            }
            else if (salario >= 800.01 && salario <= 1200.00)
            {
                valorDeReajuste = 10 * salario / 100;
                novoSalario = salario + valorDeReajuste;
                Console.WriteLine("Novo salario: " + novoSalario.ToString("F2"));
                Console.WriteLine("Reajuste ganho: " + valorDeReajuste.ToString("F2"));
                Console.WriteLine("Em percentual: 10 %");

            }
            else if (salario >= 1200.01 && salario <= 2000.00)
            {
                valorDeReajuste = 7 * salario / 100;
                novoSalario = salario + valorDeReajuste;
                Console.WriteLine("Novo salario: " + novoSalario.ToString("F2"));
                Console.WriteLine("Reajuste ganho: " + valorDeReajuste.ToString("F2"));
                Console.WriteLine("Em percentual: 7 %");

            }
            else if (salario >= 2000.01)
            {
                valorDeReajuste = 4 * salario / 100;
                novoSalario = salario + valorDeReajuste;
                Console.WriteLine("Novo salario: " + novoSalario.ToString("F2"));
                Console.WriteLine("Reajuste ganho: " + valorDeReajuste.ToString("F2"));
                Console.WriteLine("Em percentual: 4 %");
            }


        }
    }
}
