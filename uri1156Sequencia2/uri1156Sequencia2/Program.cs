using System;

namespace uri1156Sequencia2
{
    class Program
    {
        static void Main(string[] args)
        {
            double s = 1.0;
            double divisor= 2.0;
            for (int i=3; i<=39; i +=2)
            {
                //S = 1 + 3/2 + 5/4 + 7/8 + ... + 39/?
                s = s + i / (divisor);
                divisor = divisor * 2.0;
            }
            Console.WriteLine(s.ToString("f2"));
        }
    }
}
