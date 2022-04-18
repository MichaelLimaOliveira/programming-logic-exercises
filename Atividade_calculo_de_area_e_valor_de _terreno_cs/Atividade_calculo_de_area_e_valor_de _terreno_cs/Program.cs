using System;
using System.Globalization;

namespace Atividade_calculo_de_area_e_valor_de__terreno_cs
{
    class Program
    {
        static void Main(string[] args)
        {
            // Entrada de dados
            double width = 10.0;
            double length = 30.0;
            double pricePerSquareMeter = 200.0;

            // Processamento de dados

            double area = width * length;
            double landValue = pricePerSquareMeter * area;

            // saida de dados

            Console.WriteLine("Área = " + area.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Preço = " + landValue.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
