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
            Console.WriteLine("Введите число 1");
            int first = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число 2");
            int second = Convert.ToInt32(Console.ReadLine());

            int tmp1 = Math.Abs(first);
            int tmp2 = Math.Abs(second);
            int srav = 0;
            int i = 0;
            int j = 0;
            if (first != 0 || second != 0)
            {
                while (tmp1 > 0)
                {
                    i = tmp1 % 10;
                    tmp1 = tmp1 / 10;
                    while (tmp2 > 0)
                    {
                        j = tmp2 % 10;
                        tmp2 = tmp2 / 10;
                        if (i == j)
                        {
                            srav++;

                        }

                    }
                    tmp2 = second;
                }
                if (srav != 0)
                {
                    Console.WriteLine("yes");
                }
                else
                {
                    Console.WriteLine("no");
                }
            }
            else
            {
                Console.WriteLine("Введеные числа равны 0");
            }

        }
    }
}
