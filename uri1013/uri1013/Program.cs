using System;

namespace uri1013
{
    class Program
    {
        static void Main(string[] args)
        {
            int ganhouTeste1, ganhouteste2, verificarGanhador;
            string[] vet = Console.ReadLine().Split(' ');
            int valor1 = int.Parse(vet[0]);
            int valor2 = int.Parse(vet[1]);
            int valor3 = int.Parse(vet[2]);

            if (valor1 >= valor2)
            {
                ganhouTeste1 = valor1;
                verificarGanhador = valor1;
            }
            else
            {
                ganhouTeste1 = valor2;
                verificarGanhador = valor2;
            }

            if (ganhouTeste1 >= valor3)
            {
                ganhouteste2 = ganhouTeste1;
                verificarGanhador = verificarGanhador;
            }
            else
            {
                ganhouteste2 = valor3;
                verificarGanhador = valor3;
            }

            if (verificarGanhador == valor1)
            {
                Console.WriteLine(valor1 + " eh o maior");
            }
            else if (verificarGanhador == valor2)
            {
                Console.WriteLine(valor2 + " eh o maior");
            }
            else
            {
                Console.WriteLine(valor3 + " eh o maior");
            }


        }
    }
}
