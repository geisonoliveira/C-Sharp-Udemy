using System;
using System.Globalization;

namespace Exercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com o código e quantidade: ");

            string[] entrada = Console.ReadLine().Split(' ');

            int codigo = int.Parse(entrada[0]);
            int quantidade = int.Parse(entrada[1]);

            double total;

            if (codigo == 1)
            {
                total = quantidade * 4.0;
            }

            else if (codigo == 2)
            {
                total = quantidade * 4.5;
            }

            else if (codigo == 3)
            {
                total = quantidade * 5.0;
            }

            else if (codigo == 4)
            {
                total = quantidade * 2.0;
            }

            else
            {
                total = quantidade * 1.50;
            }

            Console.WriteLine("O valor total é R$ " + total.ToString("F2", CultureInfo.InvariantCulture) + " aproveite seu lanche!");
        }
    }
}
