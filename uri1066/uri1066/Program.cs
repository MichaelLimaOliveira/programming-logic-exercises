using System;

namespace uri1066
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbers,
                positiveCount = 0,
                negativeCount = 0,
                countPar = 0,
                countImpar = 0;

            for (int i = 0; i < 5; i++)
            {
                numbers = int.Parse(Console.ReadLine());

                bool isPar = (numbers % 2) == 0;
                
                countPar += Convert.ToInt32(isPar);
                countImpar += Convert.ToInt32(!isPar);

                if (numbers == 0) continue;

                bool isPositive = numbers > 0;
                positiveCount += Convert.ToInt32(isPositive);
                negativeCount += Convert.ToInt32(!isPositive);
            }


            Console.WriteLine(countPar + " valor(es) par(es)");
            Console.WriteLine(countImpar + " valor(es) impar(es)");
            Console.WriteLine(positiveCount + " valor(es) positivo(s)");
            Console.WriteLine(negativeCount + " valor(es) negativo(s)");

        }
    }
}
