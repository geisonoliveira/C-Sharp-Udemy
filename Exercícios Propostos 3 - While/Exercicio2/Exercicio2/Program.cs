using System;

namespace Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite dois numeros de um plano cartesiano, caso seja uma das coordenadas seja nula o programa irá fechar, use como separador o espaço: ");

            string[] entrada = Console.ReadLine().Split(' ');

            int x = int.Parse(entrada[0]);
            int y = int.Parse(entrada[1]);

            while (x != 0 && y != 0)
            {


                if (x > 0 && y > 0)
                {
                    Console.WriteLine("Primeiro");
                }

                else if (x < 0 && y > 0)
                {
                    Console.WriteLine("Segundo");
                }

                else if (x < 0 && y < 0)
                {
                    Console.WriteLine("Terceiro");
                }

                else
                {
                    Console.WriteLine("Quarto");
                }

                entrada = Console.ReadLine().Split(' ');
                x = int.Parse(entrada[0]);
                y = int.Parse(entrada[1]);
            }

        }
    }
}
