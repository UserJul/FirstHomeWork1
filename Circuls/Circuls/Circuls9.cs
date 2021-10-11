using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circuls
{
    class Circuls9
    {

        static void CirculsEgth(string[] args)
        {
            Console.WriteLine("Ex9");
            Console.WriteLine("Введите число N");
            int n = Convert.ToInt32(Console.ReadLine());
            int count = 0;
            int tmp = 0;
            while (n > 0)
            {
                tmp = n % 10;
                if (tmp % 2 != 0)
                {
                    count += 1;
                }
                n /= 10;
            }
            Console.WriteLine($"Количество нечетных чиcел равно {count}");
        }
    }

       
}
