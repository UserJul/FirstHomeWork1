using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circuls
{
    class Circuls12
    {
        static void CirculTvelv(string[] args)
        {
            Console.WriteLine("Введите число А");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число B");
            int b = Convert.ToInt32(Console.ReadLine());
            while (a > 0)
            {
                while (b > 0)
                { 
                    if(a % 10 == b % 10)
                    {
                        Console.WriteLine("Yes");
                    }
                    Console.WriteLine("No");
                }

            }
        }
    }
}
