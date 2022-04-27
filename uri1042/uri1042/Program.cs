using System;
using System.Linq;

namespace uri1042
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberInOrder1,
                numberInOrder2, 
                numberInOrder3,
                number1,
                number2,
                number3;
            int[] numbers = Console.ReadLine().Split(' ')
                                              .Select(number => int.Parse(number))
                                              .ToArray();

            int[] numerosOrdenados = numbers.OrderBy(number => number)
                                            .ToArray();

            numberInOrder1 = numerosOrdenados[0];
            numberInOrder2 = numerosOrdenados[1];
            numberInOrder3 = numerosOrdenados[2];

            number1 = numbers[0];
            number2 = numbers[1];
            number3 = numbers[2];


            

            
            Console.WriteLine(numberInOrder1);
            Console.WriteLine(numberInOrder2);
            Console.WriteLine(numberInOrder3);
            Console.WriteLine();
            Console.WriteLine(number1);
            Console.WriteLine(number2);
            Console.WriteLine(number3);


        }
    }
}
