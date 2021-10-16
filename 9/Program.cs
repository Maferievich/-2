using System;

namespace _9
{
    class Program
    {
        static void Main(string[] args)
        {
            double A1, B1, C1, D1, A2, B2, C2, D2, A3, B3, C3, D3, dec1, dec2, dec3, dec;
            Console.WriteLine("Введите значение 4х переменных коэффициентов первой строки:");
            A1 = double.Parse(Console.ReadLine());
            B1 = double.Parse(Console.ReadLine());
            C1 = double.Parse(Console.ReadLine());
            D1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите значение 4х переменных коэффициентов второй строки:");
            A2 = double.Parse(Console.ReadLine());
            B2 = double.Parse(Console.ReadLine());
            C2 = double.Parse(Console.ReadLine());
            D2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите значение 4х переменных коэффициентов третьей строки:");
            A3 = double.Parse(Console.ReadLine());
            B3 = double.Parse(Console.ReadLine());
            C3 = double.Parse(Console.ReadLine());
            D3 = double.Parse(Console.ReadLine());
            dec = A1 * B2 * C3 + B1 * C2 * A3 + C1 * A2 * B3 - C1 * B2 * A3 - A1 * C2 * B3 - B1 * A2 * C3;
            if (dec == 0)
                Console.WriteLine("Определитель системы = 0");
            else
            {
                dec1 = D1 * B2 * C3 + B1 * C2 * D3 + C1 * D2 * B3 - C1 * B2 * D3 - D1 * C2 * B3 - B1 * D2 * C3;
                dec2 = A1 * D2 * C3 + D1 * C2 * A3 + C1 * A2 * D3 - C1 * D2 * A3 - A1 * C2 * D3 - D1 * A2 * C3;
                dec3 = A1 * B2 * D3 + B1 * D2 * A3 + D1 * A2 * B3 - D1 * B2 * A3 - A1 * D2 * B3 - B1 * A2 * D3;
                Console.WriteLine("Ответ:");
                Console.WriteLine("x1= " + dec1);
                Console.WriteLine("x2= " + dec2);
                Console.WriteLine("x3= " + dec3);
            }



        }
    
    }
}
