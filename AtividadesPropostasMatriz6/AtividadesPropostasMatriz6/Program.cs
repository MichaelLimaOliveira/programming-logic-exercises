using System;
using System.Linq;
using System.Globalization;

namespace AtividadesPropostasMatriz6
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double[,] matizSquare = new double[n, n];


            for (int i = 0; i < n; i++)
            {
                string[] aux = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; ++j)
                {
                    matizSquare[i, j] = double.Parse(aux[j], CultureInfo.InvariantCulture);
                }

            }

            int readLine = int.Parse(Console.ReadLine());
            int readColumn = int.Parse(Console.ReadLine());

            double somaPositive = 0.0;

            foreach (double e in matizSquare)
            {
                if (e > 0)
                {
                    somaPositive += e;
                }
            }


            Console.WriteLine("SOMA DOS POSITIVOS: " + somaPositive.ToString("F1", CultureInfo.InvariantCulture));
            Console.Write("LINHA ESCOLHIDA: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(matizSquare[readLine, i].ToString("F1", CultureInfo.InvariantCulture) + " ");


            }
            Console.WriteLine();

            Console.Write("COLUNA ESCOLHIDA: ");
            for (int i = 0; i < n; ++i)
            {
                Console.Write(matizSquare[i, readColumn].ToString("F1", CultureInfo.InvariantCulture) + " ");
            }
            Console.WriteLine();

            Console.Write("DIAGONAL PRINCIPAL: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(matizSquare[i, i].ToString("F1", CultureInfo.InvariantCulture) + " ");
            }
            Console.WriteLine();

            Console.WriteLine("MATRIZ ALTERADA: ");

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; ++j)
                {
                    if (matizSquare[i, j] < 0)
                    {
                        matizSquare[i, j] = Math.Pow(matizSquare[i, j], 2);
                        Console.Write(matizSquare[i, j].ToString("F1", CultureInfo.InvariantCulture) + " ");

                    }
                    else
                    {
                        Console.Write(matizSquare[i, j].ToString("F1", CultureInfo.InvariantCulture) + " ");
                    }
                }
                Console.WriteLine();
            }


        }

    }
}
