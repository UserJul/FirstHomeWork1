using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circuls
{
    class Circuls1
    {
        static void CirculsOne(string[] args)
        {
            Console.WriteLine("Введите число А");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите число B");
            double b = Convert.ToDouble(Console.ReadLine());

            double result = 1;
            for (int i = 0; i < b; i++)
            {
                result *= a;
            }
            Console.WriteLine(result);
        }
    }
}
