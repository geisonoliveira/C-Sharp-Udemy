using System;

namespace Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá, digite um numero inteiro: ");

            int numero = int.Parse(Console.ReadLine()); 

            if (numero % 2 == 0)
            {
                Console.WriteLine("O numero digitado é PAR");
            }
            
            else
            {
                Console.WriteLine("O numero digitado é IMPAR");
            }
        }
    }
}
