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
            if (a < 1 || a > 10)
                a = 0;
            if (b < 1 || b > 10)
                b = 0;
            if (c < 1 || c > 10)
                c = 0;
            if (d < 1 || d > 10)
                d = 0;
            sum = a + b + c + d;
            Console.WriteLine("сумма чисел от 1 до 10 = " + sum);
            Console.ReadLine();

        }
    }
}
