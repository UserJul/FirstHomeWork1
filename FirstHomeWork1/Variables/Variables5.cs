using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstHomeWork1
{
    class Variables5
    {
        static void VariablesFifth(string[] args)
        {
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
            Console.WriteLine($"Результ y = {a5}*x + {b5}");

        }
    }
    }
}
