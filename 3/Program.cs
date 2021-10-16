using System;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.WriteLine("Введите часы (0 - 11)");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите минуты (0 - 59)");
            b = int.Parse(Console.ReadLine());
            if ((0 <= a) && (a <= 11) && (0 <= b) && (b <= 59))
            {
                c = (a * 30) + (b / 2);
                Console.WriteLine("Кол-во градусов от начала суток:" + c);
            }
            else
                Console.WriteLine("Некорректный ввод");
        }
    }
}
