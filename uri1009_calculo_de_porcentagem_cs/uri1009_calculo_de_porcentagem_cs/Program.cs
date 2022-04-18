using System;
using System.Globalization;

namespace uri1009_calculo_de_porcentagem_cs
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            double salary, salesPerMonth;

            name = Console.ReadLine();
            salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            salesPerMonth = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            double commission = (salesPerMonth * 15) / 100;
            double salaryMax = commission + salary;

            Console.WriteLine("TOTAL = R$ " + salaryMax.ToString("F2"), CultureInfo.InvariantCulture);


        }
    }
}
