using System;

namespace uri1165Primos
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                int number = int.Parse(Console.ReadLine());
                bool tentativa = false;
                for (int j = 2; j < number; j++)
                {
                    if (number % j == 0)
                    {
                        tentativa = true;
                    }

                }
                if (tentativa == true)
                {
                    Console.WriteLine(number + " nao eh primo");
                }
                else
                {
                    Console.WriteLine(number + " eh primo");
                }
            }
        }
    }
}
