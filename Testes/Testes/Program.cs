using System;
using System.Linq;

namespace Metodos
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] vet = EntradasDeDados.Teclado();
            int media = CalcMedia.MediaDoVetor(vet);
            Impressora.ImpressoraMundial(media.ToString());
            
        }

    }
}
