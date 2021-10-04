using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circuls
{
    class Circuls10
    {
        static void CirculsTen(string[] args)
        {
            Console.WriteLine("Ex10");
            Console.WriteLine("Введите число N");
            int n = Convert.ToInt32(Console.ReadLine());
            int tmp = 0;
            string str = "";
            while (n > 0)
            {
                tmp = n % 10;
                str = str + tmp;
                n /= 10;
            }
            Console.WriteLine(str);
        }
    }
}
