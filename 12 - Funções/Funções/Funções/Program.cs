using System;

namespace Funções
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("digite 3 numeros: ");
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());

            int resultado = Maior(n1, n2, n3);
            Console.WriteLine("O maior é " + resultado);
        }

        static int Maior(int a, int b, int c) // primeiro vem static, depois o tipo de saída da função
        {
            int m;
            if (a > b && a > c)
            {
                m = a;
            }

            else if (b > c)
            {
                m = b;
            }

            else
            {
                m = c;
            }
            return m; // no final vem o return para chamar a função para outro escopo que chamar ela

        }
    }
}
