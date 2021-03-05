using System;

namespace Course5
{
    class Program
    {
        static void Main(string[] args)
        {
            float x = 4.5f;
            double y = x;

            
            
            Console.WriteLine(y);

            double a;
            float b;

            a = 5.1;
            b = (float)a;

            Console.WriteLine(b);

            double n;
            int z;

            n = 5.1;
            z = (int)n;

            Console.WriteLine(z);

            int p = 5;
            int j = 2;

            double resultado = (double) p / j;

            Console.WriteLine(resultado);
        }
    }
}
