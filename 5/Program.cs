using System;

namespace _5
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;
            Console.WriteLine("Введите значение катетов:");
            a = double.Parse(Console.ReadLine());
            b = double.Parse(Console.ReadLine());
            c = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
            Console.WriteLine("Гипотенуза: " + c);
            Console.WriteLine("Периметр: " + (a + b + c));
            Console.WriteLine("Площадь: " + ((a * b) / 2));

        }
    }
}
