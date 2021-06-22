using System;

namespace Exercicio1
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

            for (int i = 0; i <= repeticao, )
            {
                numero = Console.ReadLine();
                if (numero >= 10 && numero <= 20)
                {
                    entre++
                }

                else
                {
                    fora++
                }
            }

            Console.WriteLine(entre);
            Console.WriteLine(fora);

        }
    }
}
