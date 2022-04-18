using System;
using System.Globalization;

namespace uri1008
{
    class Program
    {
        static void Main(string[] args)
        {
            int id, hoursWorked;
            double hourlyWage;

            id = int.Parse(Console.ReadLine());
            hoursWorked = int.Parse(Console.ReadLine());
            hourlyWage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double wage = hoursWorked * hourlyWage;

            Console.WriteLine("NUMBER = " + id);
            Console.WriteLine("SALARY = U$ " + wage.ToString("F2"),CultureInfo.InvariantCulture);

        }
    }
}
