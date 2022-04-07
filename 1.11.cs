using System;
namespace laba2
{
    class Program
    {
        static void Main()
        {
            double a, b, c, d, sum;
            Console.WriteLine("число a=");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("число b=");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("число c=");
            c = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("число d=");
            d = Convert.ToDouble(Console.ReadLine());
            if (a >= 0 && a < 41)
                Console.WriteLine(a);
            if (b >= 0 && b < 41)
                Console.WriteLine(b);
            if (c >= 0 && c < 41)
                Console.WriteLine(c);
            if (d >= 0 && d < 41)
                Console.WriteLine(d);
            Console.ReadLine();

        }
    }
}
