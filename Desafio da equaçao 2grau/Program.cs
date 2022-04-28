using System;
using System.IO;
public class Equaçao
    {
    public static void Main()
        {
        int a;
        int b;
        int c;
        int delta;
        double x1;
        double x2;

        


        Console.Write("Digite O valor de a: ");
        a = int.Parse(Console.ReadLine());
        Console.Write("Digite O Valor de b: ");
        b = int.Parse(Console.ReadLine());
        Console.Write("Digite O Valor De c: ");
        c = int.Parse(Console.ReadLine());

        delta = (b * b) - 4 * a * c;

        x1 = ((- b) + (Math.Sqrt(delta))) / (2 * a);
        x2 = ((- b) - (Math.Sqrt(delta))) / (2 * a);
        Console.WriteLine("O valor De X' e: " + x1);
        Console.WriteLine("O Valor De X'' e: " + x2);



        //Console.WriteLine(delta);

        }
    }





