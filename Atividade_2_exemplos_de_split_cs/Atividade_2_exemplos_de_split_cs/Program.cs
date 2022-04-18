using System;
using System.Globalization;

namespace Atividade_2_exemplos_de_split_cs
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            char sex = char.Parse(Console.ReadLine());
            double number2 = double.Parse(Console.ReadLine(),
                                          CultureInfo.InvariantCulture);

            string[] v = Console.ReadLine().Split(' ');
            string name = v[0];
            char sexo = char.Parse(v[1]);
            int age = int.Parse(v[2]);
            double height = double.Parse(v[3], CultureInfo.InvariantCulture);

            Console.WriteLine("Você digitou:");
            Console.WriteLine(number);
            Console.WriteLine(sex);
            Console.WriteLine(number2.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(name + "\n" + sexo + "\n" + age + "\n" + height.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
