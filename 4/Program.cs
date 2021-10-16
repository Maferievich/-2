using System;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("Введите два числа :");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            a = a * 100;
            a = a + b;
            b = a / 100;
            a = a % 100;
            Console.WriteLine("Переменная а = " + a + " Переменная b = " + b);
        }
    }
}
