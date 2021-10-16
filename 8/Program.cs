using System;

namespace _8
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, d;
            Console.WriteLine("3x^4 - 5x^3 + 2x^2 - x + 7 Значение х = ");
            a = double.Parse(Console.ReadLine());
            b = a * a; //вторая. 1*
            c = b * a; //третья степень  2*
            d = c * a; //четвертая.  3*
            c = 5 * c; //5х3 4*
            b = b + b; //2x2 1*
            d = d + d + d; // 3x4 3*
            a = d - c + b - a + 7;
            Console.WriteLine("Выражение = " + a);
        }
    }
}
