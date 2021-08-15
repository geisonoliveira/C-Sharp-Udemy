using System;
using System.Globalization;


namespace PrimeiroExercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            Retangulo R = new Retangulo();
            
            Console.WriteLine("Entre com a altura e largura do retangulo: ");
            R.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            R.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine($"Area = {R.CalcularArea().ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Perimetro = {R.CalcularPerimetro().ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Diagonal = {R.CalcularDiagonal().ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
