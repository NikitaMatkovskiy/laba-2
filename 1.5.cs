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
            if (a < 0 || a > 15)
                a = 0;
            else a = 1;
            if (b < 0 || b > 15)
                b = 0;
            else b = 1;
            if (c < 0 || c > 15)
                c = 0;
            else c = 1;
            if (d < 0 || d > 15)
                d = 0;
            else d = 1;
            sum = a + b + c + d;
            Console.WriteLine("сколько из чисел принадлежат интервалу(0; 15) = " + sum);
            Console.ReadLine();

        }
    }
}
