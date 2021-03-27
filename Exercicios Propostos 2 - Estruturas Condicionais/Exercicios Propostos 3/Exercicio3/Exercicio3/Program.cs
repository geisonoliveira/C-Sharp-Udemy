using System;

namespace Exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá, digite dois numeros para saber se eles são multiplos entre si: ");

            string[] numeros = Console.ReadLine().Split(' ');

            int numero1 = int.Parse(numeros[0]);
            int numero2 = int.Parse(numeros[1]);

            if ((numero1 % numero2 == 0) || (numero2 % numero1 == 0))
            {
                Console.WriteLine("São múltiplos");
            }

            else
            {
                Console.WriteLine("Não são múltiplos");
            }
        }
    }
}
