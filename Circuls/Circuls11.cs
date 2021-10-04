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
            int tmp = 0;
            for (int i = 1; i <= n; i++)
            {
                while(i != 0)
                {
                    tmp = n % 10;
                    if(tmp % 2 == 0)
                    {
                        sumChet += tmp;
                    }
                    else
                    {
                        sumNechet += tmp;
                    }
                    if(sumChet > sumNechet)
                    {
                        Console.WriteLine(i);
                    }
                }
            }

        }
    }
}
