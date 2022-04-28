using System;


int numero;
double fatorial= 1;
numero = 0;


while (numero <= 0)
{
    
    Console.WriteLine("Digite Um Numero Inteiro e Positivo a Ser Fatoriado: ");
    string numeroDigitado = Console.ReadLine();
    bool isInt = int.TryParse(numeroDigitado, out numero);
    
    if (!isInt)
    {
        Console.WriteLine("Você não digitou um número inteiro! ");
    }

    if (numero < 0)
    {
        Console.WriteLine("Número precisa ser positivo! ");
    }
}

while (numero > 1)
{
    fatorial = fatorial * numero;
    numero = numero - 1;
    Console.WriteLine(numero);
}


Console.WriteLine("O resultado e: "+fatorial);
