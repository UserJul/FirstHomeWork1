using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstHomeWork1
{
    class Variables3
    {
        static void VariablesThird(string[] args)
        {
            Console.WriteLine("VariablesThird");
            Console.WriteLine("Введите число А");
            double a3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите число B");
            double b3 = Convert.ToDouble(Console.ReadLine());

            double c3 = a3 / b3;
            double d3 = a3 % b3;
            Console.WriteLine($"Результат деления А на И = {c3}, остаток от деления = {d3}");
            Console.WriteLine(" ");
        }
    }
}
