using System;

namespace FormulaDeBaskara
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 1.0, b = -3.0, c = -4.0;

            double delta = b * b - 4.0 * a * c; //também poderia ser Math.Pow(b, 2.0)

            double x1 = (-b + Math.Sqrt(delta)) / (2.0 * a);
            double x2 = (-b - Math.Sqrt(delta)) / (2.0 * a);

            Console.WriteLine(delta);
            Console.WriteLine(x1);
            Console.WriteLine(x2);
        }
    }
}
