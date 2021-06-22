using System;

namespace ExercicioProposto3
{
    class Program
    {
        static void Main(string[] args)
        {
            int alcool = 0;
            int gasolina = 0;
            int diesel = 0;

            int entrada = 0;

            while (entrada != 4)
            {
                Console.WriteLine("Entre com a opção desejada: ");
                Console.WriteLine("1 - Alcool");
                Console.WriteLine("2 - Gasolina");
                Console.WriteLine("3 - Diesel");
                Console.WriteLine("4 - Sair");

                entrada = int.Parse(Console.ReadLine());

                if (entrada == 1)
                {
                    alcool++;
                }

                else if (entrada == 2)
                {
                    gasolina++;
                }

                else if (entrada == 3)
                {
                    diesel++;
                }
                
            }

            Console.WriteLine("Muito Obrigado!");
            Console.WriteLine($"Alcool: {alcool}");
            Console.WriteLine($"Gasolina: {gasolina}");
            Console.WriteLine($"Diesel: {diesel}");

        }
    }
}
