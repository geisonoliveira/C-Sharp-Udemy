using System;
using System.Globalization;

namespace Exercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um numero, inteiro ou flutuante: ");

            double numero = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (numero < 0 || numero > 100.0)
            {
                Console.WriteLine("O numero está fora de intervalo");
            }

            else if (numero <= 25.0)
            {
                Console.WriteLine("O numero está no intervalo de 0-25");
            }

            else if (numero <= 50)
            {
                Console.WriteLine("O numero está no intervalo de 26-50");
            }

            else if (numero <= 75)
            {
                Console.WriteLine("O numero está no intervalo de 51-75");
            }

            else
            {
                Console.WriteLine("O numero está no intervalo de 76-100");
            }
        }
    }
}
