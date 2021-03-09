using System;

namespace EstruturasCondicionais
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

            Console.WriteLine("Qual a hora atual?: ");

            int hora = int.Parse(Console.ReadLine());

            if (hora < 12)
            {
                Console.WriteLine("Bom dia!");
            }

            else if (hora < 18)
            {
                Console.WriteLine("Boa Tarde!");
            }

            else
            {
                Console.WriteLine("Boa Noite!");
            }

        }
    }
}
