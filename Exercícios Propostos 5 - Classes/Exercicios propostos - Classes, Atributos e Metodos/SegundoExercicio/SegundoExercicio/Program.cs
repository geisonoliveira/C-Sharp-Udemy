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
            f.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Imposto: ");
            f.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine($"Funcionário: {f}");

            Console.Write("Digite a porcentagem para aumentar o salario: ");

            double porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            f.AumentarPorcentagem(porcentagem);

            Console.WriteLine($"Dados atualizados: {f}");
        }
    }
}
