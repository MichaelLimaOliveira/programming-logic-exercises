using System;

namespace TestePraticoAtividadeDeMesa
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] v, w;
            v = new int[6];
            w = new int[6];
            v[0] = 2;

            for (int d = 1; d < 4; d++)
            {
                v[d] = v[d - 1] * 2;
            }
            for(int d =0; d<4; d++)
            {
                w[d] = v[d] * 10;
            }
        }
    }
}
