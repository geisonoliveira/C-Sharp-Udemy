using System;

namespace OperadoresLogicos
{
    class Program
    {
        static void Main(string[] args)
        {
            bool c1 = 2 > 3 || 4 != 5; // && Significa "E", tudo precisa ser true
            bool c2 = 2 > 3 || 4 != 5; // || Significa "OU", basta um ser true que tudo é true
            bool c3 = !(2 > 3) && 4 != 5; // ! Significa "NAO", que nega e altera a condicionante
            
            Console.WriteLine(c1);
            Console.WriteLine(c2);
            Console.WriteLine(c3);
            Console.WriteLine("--------------");

            bool c4 = 10 < 5;
            bool c5 = c1 || c2 && c4; // Ordem de precedencia ! > && > ||

            Console.WriteLine(c5);
        }
    }
}
