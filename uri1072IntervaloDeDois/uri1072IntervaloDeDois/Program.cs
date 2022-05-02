using System;

namespace uri1072IntervaloDeDois
{
    class Program
    {
        static void Main(string[] args)
        {
            int countNumbers = int.Parse(Console.ReadLine());
            int inside = 0,
                outside = 0;
            for (int i = 0; i < countNumbers; i++)
            {
                int numbers = int.Parse(Console.ReadLine());
                if (numbers >= 10 && numbers <= 20)
                {
                    inside++;
                }
                else
                {
                    outside++;
                }
            }
            Console.WriteLine(inside + " in");
            Console.WriteLine(outside + " out");

        }
    }
}
