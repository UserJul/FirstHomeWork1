using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circuls
{
    class Circuls3
    {
        static void CirculsThree(string[] args)
        {
            Console.WriteLine("Введите число А");
            int a = Convert.ToInt32(Console.ReadLine());
            int amount = 0;
            for (int i = 1; i < a; i++)
            {
                if (i*i < a)
                {
                    amount++;
                }
            }
            Console.WriteLine(amount);
        }
    }
}
