﻿using System;
using System.Globalization;

namespace PrimeiroExercicio
{
    class Program
    {
        static double Pi = 3.14;

        static void Main(string[] args)

        {
            Console.WriteLine("Entre com valor do raio: ");

            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double circ = Circunferencia(raio);
            double vol = Volume(raio);

            Console.WriteLine("Circunferencia: " + circ.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Volume: " + vol.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor de Pi: " + Pi.ToString("F2", CultureInfo.InvariantCulture));

        }

        static double Circunferencia (double r)
        {
            return 2.0 * Pi * r;
        }

        static double Volume (double r)
        {
            return 4.0 / 3.0 * Pi * Math.Pow(r, 3.0);
        }
    }
}
