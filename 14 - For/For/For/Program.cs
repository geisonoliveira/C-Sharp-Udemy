using System;

namespace For
{
    class Program
    {
        static void Main(string[] args)
        {
            int senha = 3294;
            
            Console.Write("Quantos numeros inteiros você vai digitar ");
            int N = int.Parse(Console.ReadLine());

            int soma = 0;
            for (int i = 1; i <= N; i++)
            {
                Console.Write($"Valor #{i}: ");
                int valor = int.Parse(Console.ReadLine());

                soma += valor;
            }

            Console.WriteLine($"Soma= {soma}");

        }
    }
}
