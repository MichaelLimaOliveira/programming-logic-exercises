using System;

namespace uri1114EstruturaDeRepetiçao
{
    class Program
    {
        static void Main(string[] args)
        {
            int correctCode = 2002;
            int code = int.Parse(Console.ReadLine());

            while (code != correctCode)
            {

                Console.WriteLine("Senha Invalida");
                code = int.Parse(Console.ReadLine());

            }
            Console.WriteLine("Acesso Permitido");
        }
    }
}
