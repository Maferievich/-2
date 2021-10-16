using System;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            double a;
            Console.WriteLine("Введите число с запятой");
            a = double.Parse(Console.ReadLine());
            a = a * 10;
            int b = (int)a;
            b = b % 10;
            Console.WriteLine("Десятая этого числа = " + b);
        }
    }
}
