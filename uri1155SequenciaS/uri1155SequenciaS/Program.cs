using System;

namespace uri1155SequenciaS
{
    class Program
    {
        static void Main(string[] args)
        {
            double s= 0;

            
            for (int i = 1; i <= 100; i++)
            {
                //1 + 1/2 + 1/3 + … + 1/100
                s = s + 1.0 /i;

            }
            Console.WriteLine(s.ToString("F2"));
        }
    }
}
