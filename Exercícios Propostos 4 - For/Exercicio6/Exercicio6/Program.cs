using System;

namespace Exercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Digite um valor inteiro ");

                double valor = double.Parse(Console.ReadLine());

                double resultado;

                for (double i = valor; i > 1; i--)
                {
                    if (valor % i == 0)
                    {
                        resultado = valor / i;
                        Console.WriteLine(resultado);
                    }
                }
            }
        }
    }
}
