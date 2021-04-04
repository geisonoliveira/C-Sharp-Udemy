using System;

namespace For
{
    class Program
    {
        static void Main(string[] args)
        {
            int senha = 3294;
            
            Console.WriteLine("Para entrar digite a senha de quatro numeros: ");

            int entrada = int.Parse(Console.ReadLine());

            while (entrada != senha)
            {
                Console.WriteLine("Senha inválida, tente novamente");
                entrada = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Bem vindo Senhor Stark");
        }
    }
}
