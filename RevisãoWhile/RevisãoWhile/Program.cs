using System;
using System.Globalization;

namespace RevisãoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um numero: ");

            double numero = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine(Math.Sqrt(numero).ToString("F3", CultureInfo.InvariantCulture));

            while (numero > 0)
            {
                Console.WriteLine("Digite outro numero: ");
                numero = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine(Math.Sqrt(numero).ToString("F3", CultureInfo.InvariantCulture));
            }

            Console.WriteLine("Numero negativo!");
        }
    }
}
