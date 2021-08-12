using System;
using System.Globalization;

namespace Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa a, b;
            a = new Pessoa();
            b = new Pessoa();
            
            
            Console.WriteLine("Digite um nome: ");
            a.nome = Console.ReadLine();

            Console.WriteLine("Digite valor do salário: ");
            a.salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Digite um nome: ");
            b.nome = Console.ReadLine();

            Console.WriteLine("Digite valor do salário: ");
            b.salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double media = (a.salario + b.salario) / 2;

            Console.WriteLine($"A média de salário é = {media.ToString("F3", CultureInfo.InvariantCulture)}");

        }
    }
}
