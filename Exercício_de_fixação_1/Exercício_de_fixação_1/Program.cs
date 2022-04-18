using System;
using System.Globalization;

namespace Exercício_de_fixação_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com seu nome completo; ");
            // nome Alex Green
            string name = Console.ReadLine();
            Console.WriteLine("Quantos quartos tem na sua casa? ");
            // 3 quartos
            int rooms = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o preço de um produto: ");
            // preço 500.50
            double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Entre com seu último nome, idade e altura (mesma linha): ");
            //Green 21 1.73
            string[] v = Console.ReadLine().Split(' ');
            string lastName = v[0];
            int age = int.Parse(v[1]);
            double height = double.Parse(v[2], CultureInfo.InvariantCulture);

            // imprimindo as respostas

            Console.WriteLine();
            Console.WriteLine(name);
            Console.WriteLine(rooms);
            Console.WriteLine(price.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(lastName + "\n" + age + "\n" + height.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
