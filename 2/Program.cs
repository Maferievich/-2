using System;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d;
            Console.WriteLine("Введите кол-во секунд:");
            a = int.Parse(Console.ReadLine());
            b = a % 60;
            c = a / 60 % 60;
            d = a / 60 / 60 % 60;
            Console.WriteLine("Прошло: " + d + " часов, " + c + " минут, " + b + " секунд.");
        }
    }
}
