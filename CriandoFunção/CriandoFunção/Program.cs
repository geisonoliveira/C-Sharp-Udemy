using System;
using System.Globalization;

namespace CriandoFunção
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite 3 valores separados por espaço");
            string[] vetor = Console.ReadLine().Split(' ');

            double numero1 = double.Parse(vetor[0], CultureInfo.InvariantCulture);
            double numero2 = double.Parse(vetor[1], CultureInfo.InvariantCulture);
            double numero3 = double.Parse(vetor[2], CultureInfo.InvariantCulture);

            double resultado = Maior(numero1, numero2, numero3);

            Console.WriteLine(resultado.ToString("F2", CultureInfo.InvariantCulture));
        }

        static double Maior(double a, double b, double c)
        {
            double m;
            
            if (a > b && a > c) {
                m = a;
            }

            else if (b > c)
            {
                m = b;
            }

            else
            {
                m = c;
            }

            return m;
        }
    }
}
