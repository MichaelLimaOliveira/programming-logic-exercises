using System;
using System.Linq;

Random numAleatorio = new Random();



int valorInteiro = numAleatorio.Next(1, 10);
int numeroReal = 0;

while (numeroReal != valorInteiro)
{
    Console.WriteLine("Digite Um Numero Aleatorio Entre 1 e 10: ");
    string valorDigitado = (Console.ReadLine());

    Int32.TryParse(valorDigitado, out numeroReal);



    while (!(numeroReal >= 1 && numeroReal <= 10))
    {
        Console.WriteLine("Valor digitado nao e um Numero Inteiro Entre 1 e 10 Digite Novamente: ");
        valorDigitado = (Console.ReadLine());
        Int32.TryParse(valorDigitado, out numeroReal);

    }
    if(numeroReal < valorInteiro)
    {
        Console.WriteLine("O numero digitado e Menor!");
    }else if(numeroReal > valorInteiro)
    {
        Console.WriteLine("O Numero Digitado e Maior!");
    }
}
Console.WriteLine("Parabens Voce Acertou!!!!");
Console.WriteLine(valorInteiro);
Console.ReadKey();
