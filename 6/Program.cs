using System;

namespace _6
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d;
            Console.WriteLine("Введите 4х значное число");
            a = int.Parse(Console.ReadLine());
            b = a / 1000;
            c = a / 100 % 10;
            d = a % 100 / 10;
            a = a % 10;
            b = b * c * d * a;
            Console.WriteLine("Произведение всех чисел = " + b);
        }
    }
}
