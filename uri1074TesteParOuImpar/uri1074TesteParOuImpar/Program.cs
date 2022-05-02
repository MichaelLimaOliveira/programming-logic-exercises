using System;

namespace uri1074TesteParOuImpar
{
    class Program
    {
        static void Main(string[] args)
        {
            // declaro quantos numeros vou testar
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                //recebo o numero testado 
                int numeros = int.Parse(Console.ReadLine());
                //aki verifico se ele e positivo
                if (numeros > 0)
                {
                    //aki testo se o numero positivo e par
                    if (numeros % 2 == 0)
                    {
                        Console.WriteLine("EVEN POSITIVE");
                    }
                    // se nao for par so pode ser impar 
                    else
                    {
                        Console.WriteLine("ODD POSITIVE");
                    }
                }
                //aki verifico se ele e negativo
                else if (numeros < 0)
                {
                    // aki verifico se o numero  negativo e par
                    if(numeros % 2 == 0)
                    {
                        Console.WriteLine("EVEN NEGATIVE");
                    }
                    // se nao for par so pode ser impar
                    else
                    {
                        Console.WriteLine("ODD NEGATIVE");
                    }
                }
                // se ele nao for nem positivo nem negativo ele e nullo (0)
                else
                {
                    Console.WriteLine("NULL");
                }
            }
        }
    }
}
