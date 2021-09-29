using System;

namespace FirstHomeWork1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("VariablesFirst");
            Console.WriteLine("Введите число А");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите число B");
            double b = Convert.ToDouble(Console.ReadLine());

            double c = (5 * a) + (b * b) / b - a;

            Console.WriteLine(c);
            Console.WriteLine(" ");

            Console.WriteLine("VariablesSecond");
            Console.WriteLine("Введите число А");
            double a2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите число B");
            double b2 = Convert.ToDouble(Console.ReadLine());

            double c2 = a2;
            a2 = b2;
            b2 = c2;

            Console.WriteLine($"{a2}, {b2}");
            Console.WriteLine(" ");

            Console.WriteLine("VariablesThird");
            Console.WriteLine("Введите число А");
            double a3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите число B");
            double b3 = Convert.ToDouble(Console.ReadLine());

            double c3 = a / b;
            double d3 = a % b;
            Console.WriteLine($"Результат деления А на И = {c3}, остаток от деления = {d3}");
            Console.WriteLine(" ");

            Console.WriteLine("VariablesFourth");
            Console.WriteLine("Введите число А");
            double a4 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите число B");
            double b4 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите число С");
            double c4 = Convert.ToDouble(Console.ReadLine());

            double x4 = c - b / a;
            Console.WriteLine($"Х равен {x4}");
            Console.WriteLine(" ");

            Console.WriteLine("VariablesFifth");
            Console.WriteLine("Введите число X1");
            double x1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите число Y1");
            double y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите число X2");
            double x2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите число Y2");
            double y2 = Convert.ToDouble(Console.ReadLine());

            double a5 = (y1 - y2) / (x1 - x2);
            double b5 = y2 - a5 * x2;
            Console.WriteLine($"Результ y = {a}*x + {b5}");

        }
    }
}
