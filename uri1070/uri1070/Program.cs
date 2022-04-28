using System;

namespace uri1070
{
    class Program
    {
        static void Main(string[] args)
        {

            int number = int.Parse(Console.ReadLine());
            bool isPar = (number % 2) == 0;
            bool isImpar = (number % 2) != 0;
            int nextNumber;

            if (isPar)
            {
                nextNumber = number + 1;
                for (int i = 0; i < 6; i++)
                {
                    Console.WriteLine(nextNumber);
                    nextNumber += 2;

                }
            }

            if (isImpar)
            {
                Console.WriteLine(number);
                nextNumber = number + 2;
                for(int i = 0; i < 5; i++)
                {
                    Console.WriteLine(nextNumber);
                    nextNumber += 2;
                }
            }
        }
    }
}
