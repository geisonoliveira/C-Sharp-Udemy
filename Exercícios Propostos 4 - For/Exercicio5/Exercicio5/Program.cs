using System;

namespace Exercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Digite um numero inteiro para saber seu fatorial: ");

                int fatorial = int.Parse(Console.ReadLine());

                if (fatorial == 0 || fatorial == 1)
                {
                    Console.WriteLine("1");
                    continue;
                }

                int resultado = fatorial;

                for (int i = (fatorial - 1); i >= 1; i--)
                {
                    resultado *= i;
                }

                Console.WriteLine(resultado);
            }
        }
    }
}
