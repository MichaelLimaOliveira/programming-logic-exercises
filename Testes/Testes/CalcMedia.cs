using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Metodos
{
    class CalcMedia
    {
        public static int MediaDoVetor(int[] vet)
        {
            int media;
            media = vet.Sum() / vet.Length;

            return media;
        }
    }
}
