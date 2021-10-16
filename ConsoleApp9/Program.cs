using System;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            string a1, b1, c1, d1, a2, b2, c2, d2, a3, b3, c3, d3, a4, b4, c4, d4, county, capital,population,str ;
            Console.WriteLine("Введите данные которые хотите внести в таблицу в таком порядке: Государство, столица, население, строй.");


            a1 = string.Format(Console.ReadLine());
            b1 = string.Format(Console.ReadLine());
            c1 = string.Format(Console.ReadLine());
            d1 = string.Format(Console.ReadLine());
            Console.WriteLine("Ещё раз: Государство, столица, население, строй.");

            a2 = string.Format(Console.ReadLine());
            b2 = string.Format(Console.ReadLine());
            c2 = string.Format(Console.ReadLine());
            d2 = string.Format(Console.ReadLine());
            Console.WriteLine("Уверяю это последний: Государство, столица, население, строй.");

            a3 = string.Format(Console.ReadLine());
            b3 = string.Format(Console.ReadLine());
            c3 = string.Format(Console.ReadLine());
            d3 = string.Format(Console.ReadLine());
            Console.WriteLine("А нет, вот теперь точно всё: Государство, столица, население, строй.");

            a4 = string.Format(Console.ReadLine());
            b4 = string.Format(Console.ReadLine());
            c4 = string.Format(Console.ReadLine());
            d4 = string.Format(Console.ReadLine());
            county = "Государство";
            capital = "Столица";
            population = "Население";
            str = "Строй";
            Console.WriteLine();
            Console.WriteLine("География");
            Console.WriteLine("{0,11} |{1,11} |{2,11} |{3,11}",county, capital, population, str);
            Console.WriteLine("{0,11} |{1,11} |{2,11} |{3,11}", a1, b1, c1, d1);
            Console.WriteLine("{0,11} |{1,11} |{2,11} |{3,11}", a2, b2, c2, d2);
            Console.WriteLine("{0,11} |{1,11} |{2,11} |{3,11}", a3, b3, c3, d3);
            Console.WriteLine("{0,11} |{1,11} |{2,11} |{3,11}", a4, b4, c4, d4);
            Console.WriteLine("Перечисляемый тип: Ф - федерация, УГ - унитарное государство");
        }
    }
}
