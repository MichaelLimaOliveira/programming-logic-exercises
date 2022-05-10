using System;
using System.Collections.Generic;
using System.Linq;

namespace AtividadesPropostasMatriz5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine().Split(' ').Select(e => int.Parse(e)).ToArray();

            int[,] matriz = new int[size[0], size[1]];

            int cont = 0;

            do
            {

                for (int i = 0; i < size[0]; ++i)
                {
                    string[] aux = Console.ReadLine().Split(' ');
                    for (int j = 0; j < size[1]; ++j)
                    {
                        matriz[i, j] = matriz[i, j] + int.Parse(aux[j]);
                    }
                }

                cont++;

            } while (cont != 2);

            int brokenLine = 0; 

            foreach (int e in matriz)
            {               
                if (brokenLine == size[1] -1)
                {
                    Console.WriteLine(e +" ");
                    brokenLine = 0;
                }
                else
                {
                    Console.Write(e + " ");
                    brokenLine++;
                }    
            }
        }
    }
}


//List<List<int>> matriz1 = new List<List<int>>();
//for (int i = 0; i < size[0]; i++)
//{
//    var entrada = Console.ReadLine().Split(' ').Select(e => int.Parse(e)).ToList();
//    matriz1.Add(entrada);
//}

//List<List<int>> matriz2 = new List<List<int>>();
//for (int i = 0; i < size[0]; i++)
//{
//    var entrada = Console.ReadLine().Split(' ').Select(e => int.Parse(e)).ToList();
//    matriz2.Add(entrada);
//}

//for (int i = 0; i < size[0]; i++)
//{
//    string somas = "";
//    for (int j = 0; j < matriz1[i].Count; j++)
//    {
//        somas += $"{matriz1[i][j] + matriz2[i][j]} ";
//    }
//    Console.WriteLine(somas);
//}