using System;
using System.Globalization;

namespace uri1021
{
    class Program
    {
        static void Main(string[] args)
        {
            int resto, cem, cinquenta, vinte, dez, cinco, dois, um, cinquentaCentavos,
                vinteCincoCentavos, dezCentavos, cincoCentavos, umCentavo;

            string[] valorDigitado = (Console.ReadLine().Split('.'));
            int parteInteira = int.Parse(valorDigitado[0]);
            int parteDecimal = int.Parse(valorDigitado[1]);

            cem = parteInteira / 100;
            resto = parteInteira % 100;
            Console.WriteLine("NOTAS:");
            Console.WriteLine(cem + " nota(s) de R$ 100.00");
            cinquenta = resto / 50;
            resto = resto % 50;
            Console.WriteLine(cinquenta + " nota(s) de R$ 50.00");
            vinte = resto / 20;
            resto = resto % 20;
            Console.WriteLine(vinte + " nota(s) de R$ 20.00");
            dez = resto / 10;
            resto = resto % 10;
            Console.WriteLine(dez + " nota(s) de R$ 10.00");
            cinco = resto / 5;
            resto = resto % 5;
            Console.WriteLine(cinco + " nota(s) de R$ 5.00");
            dois = resto / 2;
            resto = resto % 2;
            Console.WriteLine(dois + " nota(s) de R$ 2.00");
            um = resto / 1;
            Console.WriteLine("MOEDAS:");
            Console.WriteLine(um + " moeda(s) de R$ 1.00");
            cinquentaCentavos = parteDecimal / 50;
            resto = parteDecimal % 50;
            Console.WriteLine(cinquentaCentavos + " moeda(s) de R$ 0.50");
            vinteCincoCentavos = resto / 25;
            resto = resto % 25;
            Console.WriteLine(vinteCincoCentavos + " moeda(s) de R$ 0.25");
            dezCentavos = resto / 10;
            resto = resto % 10;
            Console.WriteLine(dezCentavos + " moeda(s) de R$ 0.10");
            cincoCentavos = resto / 5;
            umCentavo = resto % 5;
            Console.WriteLine(cincoCentavos + " moeda(s) de R$ 0.05");
            Console.WriteLine(umCentavo + " moeda(s) de R$ 0.01");



        }
    }
}
