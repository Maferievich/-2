using System;

namespace Индивидуальное_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите 3 переменных, чтобы вычислить формулу: f=ln(a+x^2)+sin(x/b), b не должно = 0");
            double a, x, b, f, c, e, z;
            Console.Write("a = ");
            a = double.Parse(Console.ReadLine());
            Console.Write("x = ");
            x = double.Parse(Console.ReadLine());
            Console.Write("b = ");
            b = double.Parse(Console.ReadLine());
            if (b == 0)
                Console.WriteLine("Деление на 0 невозможно");
            else
            {
                f = Math.Log(a + Math.Pow(x, 2)) + Math.Sin(x / b);
                Console.WriteLine();
                Console.WriteLine("Формула f = " + f);

            }
            Console.WriteLine();
            Console.WriteLine("Введите 5 переменных, чтобы вычислить формулу: z=e^(-cx)*((x+√(x+a))/(x-√(|x-b|)))");
            Console.WriteLine("x+a не должны давать отрицательное значение");



            Console.Write("a = ");
            a = double.Parse(Console.ReadLine());
            Console.Write("b = ");
            b = double.Parse(Console.ReadLine());
            Console.Write("c = ");
            c = double.Parse(Console.ReadLine());
            Console.Write("x = ");
            x = double.Parse(Console.ReadLine());
            Console.Write("e = ");
            e = double.Parse(Console.ReadLine());
            if ((x + a) < 0)
                Console.WriteLine("Невозможно посчитать корень");
            else
            {
                z = Math.Pow(e, (-c * x));
                z = z * ((x + Math.Sqrt(x + a)) / (x - Math.Sqrt(Math.Abs(x - b))));
                Console.WriteLine();
                Console.WriteLine("Формула z = " + z);
            }



        }
    }
}
