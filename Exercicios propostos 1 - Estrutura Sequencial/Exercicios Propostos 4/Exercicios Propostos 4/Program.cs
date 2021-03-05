using System;
using System.Globalization;
namespace Exercicios_Propostos_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o numero do funcionário: ");

            int numero = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite quantas horas foram trabalhadas com separador ponto: ");

            double horas = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Agora digite o valor por hora do funcinoário com separador ponto: ");

            double valorhora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double salario = horas * valorhora;

            Console.Write("Number = ");
            Console.WriteLine(numero);

            Console.Write("Salary = U$ ");
            Console.WriteLine(salario.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
