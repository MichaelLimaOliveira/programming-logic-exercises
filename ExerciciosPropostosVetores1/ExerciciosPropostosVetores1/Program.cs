using System;
using System.Globalization;
using System.Linq;

namespace ExerciciosPropostosVetores1
{
    class Program
    {
        public static NumberStyles Cult { get; private set; }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double higherNumber;
            double higherNumberPosition = 0.0;
            int maxPosition = 0;
            double[] numberInVet = Console.ReadLine()
                                          .Split(' ')
                                          .Select(n => double.Parse(n,CultureInfo.InvariantCulture))
                                          .ToArray();
            
            
            higherNumber = numberInVet.Max();

            for (int i = 0; i < n; i++)
            {
               
                if (numberInVet[i] > higherNumberPosition)
                {
                    maxPosition = i;
                    higherNumberPosition = numberInVet[i];
                }
            }
            higherNumber = numberInVet.Max();

            Console.WriteLine(higherNumber.ToString("F1"),CultureInfo.InvariantCulture);
            Console.WriteLine(maxPosition);
        }
    }
}
