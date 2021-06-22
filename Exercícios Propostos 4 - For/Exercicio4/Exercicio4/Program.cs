using System;
using System.Globalization;

namespace Exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite quantas vezes quer repetir o calculo de divisão: ");

            int repeticao = int.Parse(Console.ReadLine());

            double numero1, numero2;

            for (int i = repeticao; i >= 1; i--)
            {
                Console.WriteLine("Digite dois numeros com espaço entre eles para dividi-los entre si: ");

                string[] numeros = Console.ReadLine().Split(' ');

                numero1 = int.Parse(numeros[0]);
                numero2 = int.Parse(numeros[1]);

                if (numero2 != 0)
                {
                    double resultado = numero1 / numero2;

                    Console.WriteLine(resultado.ToString("F1", CultureInfo.InvariantCulture));

                }
                
                else
                {
                    Console.WriteLine("Divisao Impossível!");
                }

            }
        }
    }
}
