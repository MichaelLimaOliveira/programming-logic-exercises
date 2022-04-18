using System;
using System.Globalization;

namespace Primeiro
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaraçao das variaveis

            int age = 28;
            double x = 10.35784;
            string name = "Shopia";
            char sex = 'F';

            //Imprimindo os valores

            Console.WriteLine("Hello World!");
            Console.WriteLine("Good Morning");
            Console.WriteLine("See you later");
            Console.WriteLine();

            Console.WriteLine(x);
            Console.WriteLine(x.ToString("F2"));
            Console.WriteLine(x.ToString("F4"));

            Console.WriteLine(x.ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine();
            Console.WriteLine("Resultado = " + x);
            Console.WriteLine("O valor do troco é " + x + " reais");
            Console.WriteLine("O valor do troco é " + x.ToString("F2") + " reais");


            Console.WriteLine();
            Console.WriteLine("A paciente " + name + " tem " + age + " anos e seu sexo é: " + sex);

        }
    }
}
