using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Metodos
{
    class EntradasDeDados
    {

        public static int[] Teclado()
        {
            return Console.ReadLine().Split(' ').Select(v => int.Parse(v)).ToArray();
        }
    }
}
