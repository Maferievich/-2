using System;

namespace _7
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("Введите трёх значное число:");
            a = int.Parse(Console.ReadLine());
            b = (a % 10 * 100) + (a / 10 % 10 * 10) + (a / 100);
            Console.WriteLine("Перевернутое число :" + b);
        }
    }
}
