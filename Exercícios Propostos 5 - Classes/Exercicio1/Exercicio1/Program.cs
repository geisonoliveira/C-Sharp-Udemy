using System;

namespace Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa a, b;

            a = new Pessoa();
            b = new Pessoa();

            Console.WriteLine("Digite o nome: ");
            a.nome = Console.ReadLine();

            Console.WriteLine("Digite a idade: ");
            a.idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o nome: ");
            b.nome = Console.ReadLine();

            Console.WriteLine("Digite a idade: ");
            b.idade = int.Parse(Console.ReadLine());


            Console.WriteLine("Dados da primeira pessoa: ");
            Console.WriteLine($"Nome: {a.nome}");
            Console.WriteLine($"Idade: {a.idade}");

            Console.WriteLine("Dados da segunda pessoa: ");
            Console.WriteLine($"Nome: {b.nome}");
            Console.WriteLine($"Idade: {b.idade}");

            if (a.idade > b.idade)
            {
                Console.WriteLine($"Pessoa mais velha: {a.nome}");
            }

            else
            {
                Console.WriteLine($"Pessoa mais velha: {b.nome}");
            }
        }
    }
}
