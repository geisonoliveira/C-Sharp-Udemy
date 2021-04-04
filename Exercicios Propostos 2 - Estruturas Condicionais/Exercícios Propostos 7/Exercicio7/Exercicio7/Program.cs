using System;
using System.Globalization;

namespace Exercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite dois valores (uma casa decimal usando separador '.', caso seja flutuante) e espaço entre eles:  ");

            string[] entrada = Console.ReadLine().Split(' ');

            double x = double.Parse(entrada[0], CultureInfo.InvariantCulture);
            double y = double.Parse(entrada[1], CultureInfo.InvariantCulture);

            if (x > 0 && y > 0)
            {
                Console.WriteLine("Está no quadrante 1");
            }

            else if (x > 0 && y < 0)
            {
                Console.WriteLine("Está no quadrante 4");
            }

            else if (x < 0 && y > 0)
            {
                Console.WriteLine("Está no quadrante 2");
            }

            else if (x < 0 && y < 0)
            {
                Console.WriteLine("Está no quadrante 3");
            }

            else
            {
                Console.WriteLine("Está no quadrante origem");
            }
        }
    }
}
