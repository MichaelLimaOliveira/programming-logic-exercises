using System;

namespace uri1020
{
    class Program
    {
        static void Main(string[] args)
        {
            int anos, mes, dias, resto;
            int diasDigitado = int.Parse(Console.ReadLine());

            anos = diasDigitado / 365;
            resto = diasDigitado % 365;
            mes = resto / 30;
            dias = resto % 30;

            Console.WriteLine(anos + " ano(s)");
            Console.WriteLine(mes + " mes(es)");
            Console.WriteLine(dias + " dia(s)");
        }
    }
}
