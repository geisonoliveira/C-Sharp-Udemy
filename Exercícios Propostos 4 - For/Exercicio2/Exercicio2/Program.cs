using System;

namespace Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um numero: "); // pra calcular quantas vezes vai pedir entrada de numeros

            int repeticao = int.Parse(Console.ReadLine());

            int numero = 0;
            int entre = 0;
            int fora = 0;

            for (int i = repeticao; i >= 1; i--) 
            {
                numero = int.Parse(Console.ReadLine());
                if (numero >= 10 && numero <= 20)
                {
                    entre++;
                }

                else
                {
                    fora++;
                }
            }

            Console.WriteLine($"In: {entre}");
            Console.WriteLine($"Out: {fora}");

        }
    }
}
