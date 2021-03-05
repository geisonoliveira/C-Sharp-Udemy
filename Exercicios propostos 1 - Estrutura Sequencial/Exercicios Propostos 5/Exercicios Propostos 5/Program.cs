using System;
using System.Globalization;
namespace Exercicios_Propostos_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o código da peça, a quantidade de peças e o valor unitario usando divisor ponto: ");
            string[] entrada1 = (Console.ReadLine().Split(' '));

            int codigo1 = int.Parse(entrada1[0]);
            int quantidade1 = int.Parse(entrada1[1]);
            double valor1 = double.Parse(entrada1[2], CultureInfo.InvariantCulture);

            Console.WriteLine("Agora digite a segunda entrada com: código da peça, quantidade de peças e o valor unitário usando divisor ponto: ");
            string[] entrada2 = (Console.ReadLine().Split(' '));

            int codigo2 = int.Parse(entrada2[0]);
            int quantidade2 = int.Parse(entrada2[1]);
            double valor2 = double.Parse(entrada2[2], CultureInfo.InvariantCulture);

            double total = (quantidade1 * valor1) + (quantidade2 * valor2);

            Console.Write("O valor total é: R$ ");
            Console.WriteLine(total.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
