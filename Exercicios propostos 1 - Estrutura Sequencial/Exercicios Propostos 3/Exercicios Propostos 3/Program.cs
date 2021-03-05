using System;

namespace Exercicios_Propostos_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());
            int C = int.Parse(Console.ReadLine());
            int D = int.Parse(Console.ReadLine());

            int diferenca = A * B - C * D;
 
            Console.Write($"DIFERENÇA = {diferenca}");
            
        }
    }
}
