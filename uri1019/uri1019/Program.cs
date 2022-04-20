using System;

namespace uri1019
{
    class Program
    {
        static void Main(string[] args)
        {
            int horas, minutos, segundos, resto;
            int n = int.Parse(Console.ReadLine());

            horas = n / 3600;
            resto = n % 3600;
            minutos = resto / 60;
            segundos = resto % 60;

            Console.WriteLine(horas + ":" + minutos + ":" + segundos);


        }
    }
}
