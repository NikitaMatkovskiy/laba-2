using System;
namespace laba2
{
    class Program
    {
        static void Main()
        {
            double a, s, k, x, y;
            Console.WriteLine("сколько рублей имеется?=");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("какое расстояние надо проехать?=");
            s = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("сколько стоит литр бензина в руб.?=");
            k = Convert.ToDouble(Console.ReadLine());
            x = a / k;
            y = x * 10; //1 литр на 10 км
            if (y >= s)
                Console.WriteLine("хватит");
            else Console.WriteLine("не хватит");
            Console.ReadLine();

        }
    }
}
