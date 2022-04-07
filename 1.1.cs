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
            if (a < 6)
                a = 0;
            else a = a;
            if (b < 6)
                b = 0;
            else b = b;
            if (c < 6)
                c = 0;
            else c = c;
            if (d < 6)
                d = 0;
            else d = d;
            sum = a + b + c + d;
            Console.WriteLine("сумма чисел больше 5 = " + sum);
            Console.ReadLine();

        }
    }
}
