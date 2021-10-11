using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circuls
{
    class Circuls5
    {
        static void CirculsFive(string[] args)
        {
            Console.WriteLine("Введите число А");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число B");
            int b = Convert.ToInt32(Console.ReadLine());

            int sum = 0;
            if (a > b)
            {
                for (int i = a; i <= b; i++)
                {
                    if( i % 7 == 0)
                    {
                        sum += i;
                    }
                }
            }
            else
            {
                for (int i = b; i <= a; i++)
                {
                    if (i % 7 == 0)
                    {
                        sum += i;
                    }
                }
            }
           
            Console.WriteLine(sum);
        }
    }
}
