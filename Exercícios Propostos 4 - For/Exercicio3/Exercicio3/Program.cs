using System;
using System.Globalization;

namespace Exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com quantidade que quer repetir as analises de media ponderada");

            int repeticao = int.Parse(Console.ReadLine());

            double numero1, numero2, numero3, media;

            for (int i = repeticao; i >= 1; i--)
            {
                Console.WriteLine("Entre com 3 valores com 1 casa decimal e espaço entre eles: ");

                string[] numeros = Console.ReadLine().Split(' ');

                numero1 = double.Parse(numeros[0], CultureInfo.InvariantCulture);
                numero2 = double.Parse(numeros[1], CultureInfo.InvariantCulture);
                numero3 = double.Parse(numeros[2], CultureInfo.InvariantCulture);

                media = ((numero1 * 2) + (numero2 * 3) + (numero3 * 5)) / 10;

                Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));
            }
        }
    }
}
