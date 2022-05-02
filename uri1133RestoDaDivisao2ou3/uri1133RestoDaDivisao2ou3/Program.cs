using System;

namespace uri1133RestoDaDivisao2ou3
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());

            int maior, menor;
            if (number1 > number2)
            {
                maior = number1;
                menor = number2;
            }
            else
            {
                maior = number2;
                menor = number1;
            }


            for (int i = menor + 1; i < maior; i++)
            {

                if (i % 5 == 2)
                {
                    Console.WriteLine(i);
                }
                else if (i % 5 == 3)
                {
                    Console.WriteLine(i);
                }

            }
        }
    }
}
