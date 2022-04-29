using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AtividadeDeWhile
{
    class Comparador
    {
        public static bool IsCrescente(int[] vet)
        {

            bool isCrescente;

            if (vet[0] < vet[1])
            {
                isCrescente = true;
            }
            else
            {
                isCrescente = false;
            }

            return isCrescente;
        }
    }
}
