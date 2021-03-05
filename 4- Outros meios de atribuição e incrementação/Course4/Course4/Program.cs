using System;

namespace Course4
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            Console.WriteLine(a);

            a += 2;
            Console.WriteLine(a);

            a *= 3;
            Console.WriteLine(a);

            string s = "ABC";
            Console.WriteLine(s);

            s += "DEF";
            Console.WriteLine(s);

            int x = 10;
            x++;

            Console.WriteLine(x);

            x--;
            Console.WriteLine(x);

            int y = 10;
            int n = ++y;
            Console.WriteLine(y);
            Console.WriteLine(n);
        }
    }
}
