using System;

namespace Exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá, digite horario inicial e horario final com separador espaço, apenas numero inteiro: ");

            string[] horario = Console.ReadLine().Split(' ');

            int horarioinicial = int.Parse(horario[0]);
            int horariofinal = int.Parse(horario[1]);

            int resultado;

            if (horarioinicial < horariofinal)
            {
                resultado = horariofinal - horarioinicial;
            }

            else
            {
                resultado = (24 - horarioinicial + horariofinal);
            }

            Console.WriteLine($"Foram passadas {resultado}hs após inicio do programa");
        }
    }
}
