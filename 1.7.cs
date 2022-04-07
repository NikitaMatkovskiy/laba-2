using System;
namespace laba2
{
    class Program
    {
        static void Main()
        {
            double a, b, c, d, sum;
            Console.WriteLine("целое число a=");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("целое число b=");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("целое число c=");
            c = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("целое число d=");
            d = Convert.ToDouble(Console.ReadLine());
            if (a < 10 || a > 99)
                a = 0;
            else a = 1;
            if (b < 10 || b > 99)
                b = 0;
            else b = 1;
            if (c < 10 || c > 99)
                c = 0;
            else c = 1;
            if (d < 10 || d > 99)
                d = 0;
            else d = 1;
            sum = a + b + c + d;
            Console.WriteLine("двузначных чисел: " + sum);
            Console.ReadLine();

        }
    }
}
