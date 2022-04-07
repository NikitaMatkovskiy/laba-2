using System;
namespace laba2
{
    class Program
    {
        static void Main()
        {
            double a, b, c;
            Console.WriteLine("a=");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("b=");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("c=");
            c = Convert.ToDouble(Console.ReadLine());
            if ((a < b && a > c) || (a > b && a < c))
                Console.WriteLine(a);
            if ((b > a && b < c) || (b < a && b > c))
                Console.WriteLine(b);
            if ((c < a && c > b) || (c > a && c < b))
                Console.WriteLine(c);

            Console.ReadLine();

        }
    }
}
