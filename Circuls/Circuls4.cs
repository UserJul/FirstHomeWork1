using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circuls
{
    class Circules4
    {
        static void CirculsFour(string[] args)
        {
            Console.WriteLine("Введите число А");
            int a = Convert.ToInt32(Console.ReadLine());
            int nd = 1;
            for (int i = 1; i < a; i++)
            {
                if( a % nd == 0)
                {
                    nd = i;
                }
            }
            Console.WriteLine(nd);
        }
    }
}
