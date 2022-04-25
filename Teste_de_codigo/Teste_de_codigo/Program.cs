using System;

namespace uri1046
{
    class Program
    {
        static void Main(string[] args)
        {
            int b = 97;
            int c = 123;

            Console.WriteLine($"B é {b.ToString()} C é {c}");

            //Digite a logica
            b = c + b;
            c = b - c;
            b = b - c;

            Console.WriteLine($"B é {b.ToString()} C é {c}");

        }
    }
}