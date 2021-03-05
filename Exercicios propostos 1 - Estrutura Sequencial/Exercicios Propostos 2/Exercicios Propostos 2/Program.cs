using System;
using System.Globalization;
namespace Exercicios_Propostos_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o raio de um circulo: ");

            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double area = 3.14159 * (raio * raio);

            Console.WriteLine("A area do circulo do raio informado é: ");
            Console.WriteLine(area.ToString("F4", CultureInfo.InvariantCulture));
        }
    }
}
