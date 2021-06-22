using System;

namespace Exercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Digite um valor inteiro: ");

                int valor = int.Parse(Console.ReadLine());

                for (int i = 1; i <= valor; i++)
                {
                    Console.Write($"{i} ");
                    Console.Write($"{i * i} ");
                    Console.WriteLine($"{i * i * i} ");
                }
            }
        }
    }
}
