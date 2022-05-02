using System;

namespace uri1132
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            int maior, 
                menor, 
                soma = 0;

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

            for(int i = menor; i<=maior; i++)
            {
                if(i % 13 != 0)
                {
                    soma += i;
                }
            }
            Console.WriteLine(soma);
        }
    }
}
