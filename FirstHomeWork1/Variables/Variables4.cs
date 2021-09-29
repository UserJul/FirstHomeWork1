using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstHomeWork1
{
    class Variables4
    {
        static void VariablesFourth(string[] args)
        {
            Console.WriteLine("VariablesFourth");
            Console.WriteLine("Введите число А");
            double a4 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите число B");
            double b4 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите число С");
            double c4 = Convert.ToDouble(Console.ReadLine());

            double x4 = (c4 - b4) / a4;
            Console.WriteLine($"Х равен {x4}");
            
        }
    }
}
