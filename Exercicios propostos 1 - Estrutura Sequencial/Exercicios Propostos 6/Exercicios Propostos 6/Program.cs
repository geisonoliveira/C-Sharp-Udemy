using System;
using System.Globalization;

namespace Exercicios_Propostos_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insina 3 numeros com ponto flutuante cmo separador ponto: ");
            

            string[] medidas = Console.ReadLine().Split(' ');

            double A = double.Parse(medidas[0], CultureInfo.InvariantCulture);
            double B = double.Parse(medidas[1], CultureInfo.InvariantCulture);
            double C = double.Parse(medidas[2], CultureInfo.InvariantCulture);

            double triangulo = (A * C / 2);

            double circulo = 3.14159 * (C * C);

            double trapezio = ((A + B) * C) / 2;

            double quadrado = B * B;

            double retangulo = (A * B);

            Console.WriteLine("Triangulo = " + triangulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("Circulo = " + circulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("Trapezio = " + trapezio.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("Quadrado = " + quadrado.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("Retangulo = " + retangulo.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}
