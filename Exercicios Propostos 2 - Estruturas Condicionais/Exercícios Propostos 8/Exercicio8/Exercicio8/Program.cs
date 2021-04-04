using System;
using System.Globalization;

namespace Exercicio8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite valor salario para calculo imposto renda, valor com duas casas decimais e divisor ponto");

            double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (salario <= 2000.00)
            {
                Console.WriteLine("Você está isento.");
            }

            else if (salario <= 3000)
            {
                salario = (salario - 2000.00) * 0.08;
                Console.WriteLine($"O valor do imposto é de R$ {salario.ToString("F2", CultureInfo.InvariantCulture)}");
            }

            else if (salario <= 4500.00 )
            {
                salario = (salario - 3000.00) * 0.18 + 1000.00 * 0.08;
                Console.WriteLine($"O valor do imposto é de R$ {salario.ToString("F2", CultureInfo.InvariantCulture)}");
            }

            else
            {
                salario = (salario - 4500.00) * 0.28 + 1500.00 * 0.18 + 1000.00 * 0.08;
                Console.WriteLine($"O valor do imposto é de R$ {salario.ToString("F2", CultureInfo.InvariantCulture)}");
            }

        }
    }
}
