using System;
namespace laba2
{
    class Program
    {
        static void Main()
        {
            double a;
            Console.WriteLine("число a=");
            a = Convert.ToDouble(Console.ReadLine());

            if (a > 0)
                Console.WriteLine("положительное");
            else Console.WriteLine("отрицательное");
            if (a % 2 == 0)
                Console.WriteLine("четное");
            else Console.WriteLine("нечетное");
            Console.ReadLine();

        }
    }
}
