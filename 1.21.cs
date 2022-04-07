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
            if (a < b && a < c)
                Console.WriteLine("1");
            if (b < a && b < c)
                Console.WriteLine("2");
            if (c < a && c < b)
                Console.WriteLine("3");

            Console.ReadLine();

        }
    }
}
