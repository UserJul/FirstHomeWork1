using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circuls
{
    class Circuls11
    {
        static void CirculsEleven(string[] args)
        {
            Console.WriteLine("Ex11");
            Console.WriteLine("Введите число N");
            int n = Convert.ToInt32(Console.ReadLine());
            int sumChet = 0;
            int sumNechet = 0;
            int tmp1 = 0;
            int tmp2 = 0;
            for (int i = 1; i <= n; i++)
            {
                tmp2 = i;
                while (tmp2 > 0)
                {
                    tmp1 = tmp2 % 10;
                    if (tmp1 % 2 == 0)
                    {
                        sumChet += tmp1;
                    }
                    else
                    {
                        sumNechet += tmp1;
                    }
                    tmp2 = tmp2 / 10;
                }
                if (sumChet > sumNechet)
                {
                    Console.WriteLine(i);
                    sumChet = 0;
                    sumNechet = 0;
                }
                else
                {
                    sumChet = 0;
                    sumNechet = 0;
                }
            }

        }
    }
}
