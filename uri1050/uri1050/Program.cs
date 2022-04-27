using System;
using System.Linq;

namespace uri1050
{
    class Program
    {
        static void Main(string[] args)
        {

            int brasilia = 61,
                salvador = 71,
                saoPaulo = 11,
                rioDeJaneiro = 21,
                juizDeFora = 32,
                campinas = 19,
                vitoria = 27,
                beloHorizonte = 31;

            string cidade = " ";

            int ddd = int.Parse(Console.ReadLine());

            if (ddd == brasilia)
            {
                cidade = "Brasilia";
            }
            else if (ddd == salvador)
            {
                cidade = "Salvador";
            }
            else if (ddd == saoPaulo)
            {
                cidade = "Sao Paulo";
            }
            else if (ddd == rioDeJaneiro)
            {
                cidade = "Rio de Janeiro";
            }
            else if (ddd == juizDeFora)
            {
                cidade = "Juiz de Fora";
            }
            else if (ddd == campinas)
            {
                cidade = "Campinas";
            }
            else if (ddd == vitoria)
            {
                cidade = "Vitoria";
            }
            else if (ddd == beloHorizonte)
            {
                cidade = "Belo Horizonte";
            }
            else
            {
                cidade = "DDD nao cadastrado";
            }

            Console.WriteLine(cidade);   
        }
    }
}
