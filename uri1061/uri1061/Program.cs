using System;

namespace uri1061
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] valores = Console.ReadLine().Split(' ');
            int diaInicial = int.Parse(valores[1]);
            valores = Console.ReadLine().Split(' ');
            int horasInicial = int.Parse(valores[0]);
            int minutosInicial = int.Parse(valores[2]);
            int segundosInicial = int.Parse(valores[4]);
            valores = Console.ReadLine().Split(' ');
            int diaFinal = int.Parse(valores[1]);
            valores = Console.ReadLine().Split(' ');
            int horasFinal = int.Parse(valores[0]);
            int minutosFinal = int.Parse(valores[2]);
            int segundosFinal = int.Parse(valores[4]);

            int inicio = diaInicial * 86400 + horasInicial * 3600 + minutosInicial * 60 + segundosInicial;
            int fim = diaFinal * 86400 + horasFinal * 3600 + minutosFinal * 60 + segundosFinal;

            int duracao = fim - inicio;

            int dias = duracao / 86400;
            int resto = duracao % 86400;
            int horas = resto / 3600;
            resto = resto % 3600;
            int minutos = resto / 60;
            int segundos = resto % 60;

            Console.WriteLine(dias + " dia(s)");
            Console.WriteLine(horas + " hora(s)");
            Console.WriteLine(minutos + " minuto(s)");
            Console.WriteLine(segundos + " segundo(s)");
        }
    }
}
