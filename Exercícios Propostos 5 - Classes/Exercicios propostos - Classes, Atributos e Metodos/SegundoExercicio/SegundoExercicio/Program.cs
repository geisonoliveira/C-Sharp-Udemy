using System;
using System.Globalization;

namespace SegundoExercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario f = new Funcionario();
            
            Console.WriteLine("Entrar do dados de salario do empregado: ");
            Console.WriteLine();

            Console.Write("Nome: ");
            f.Nome = Console.ReadLine();

            Console.Write("Salario Bruto: ");
            f.SalarioBruto = double.Parse(Console.ReadLine());

            Console.Write("Imposto: ");
            f.Imposto = double.Parse(Console.ReadLine());

            Console.WriteLine(f.SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
