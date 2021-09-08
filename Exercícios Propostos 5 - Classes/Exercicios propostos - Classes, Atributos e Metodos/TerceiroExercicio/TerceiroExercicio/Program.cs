using System;
using System.Globalization;

namespace TerceiroExercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno a = new Aluno();
            
            Console.Write("Nome do aluno: ");
            a.Nome = Console.ReadLine();

            Console.WriteLine("Digite as três notas do aluno: ");
            a.Nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            a.Nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            a.Nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine($"Nota Final: {a.NotaFinal().ToString("F2", CultureInfo.InvariantCulture)}");
            a.Aprovacao();

            Console.WriteLine(a.Situacao);

            a.Restante();
            if (a.Situacao == "REPROVADO")
            {
                Console.WriteLine("Nota restante " + a.NotaRestante.ToString("F2", CultureInfo.InvariantCulture));
            }
            
        }
    }
}
