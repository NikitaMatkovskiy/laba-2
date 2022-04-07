using System;
namespace laba2
{
    class Program
    {
        static void Main()
        {
            double a, b, c, d;
            Console.WriteLine("длина открытки=");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("ширина открытки=");
            b= Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("длина конверта");
            c = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("ширина конверта");
            d = Convert.ToDouble(Console.ReadLine());
            if (a < c && b < d)
                Console.WriteLine("поместится");
            else Console.WriteLine("не поместится");
            Console.ReadLine();

        }
    }
}
