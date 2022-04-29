using System;
using System.Linq;

namespace AtividadeDeWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vet = Console.ReadLine().Split(' ').Select(v => int.Parse(v)).ToArray();

            
            
            while(vet[0] != vet[1])
            {
                string mensagem;
                bool isCrescente = Comparador.IsCrescente(vet) == true;
                mensagem = isCrescente ? "Crescente" : "Decrescente";
                Impressora.ImpressoraMundial(mensagem);
                vet = Console.ReadLine().Split(' ').Select(v => int.Parse(v)).ToArray();


            }
            

        }
    }
}
