using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circuls
{
    class Circuls2
    {
        static void CirculsTwo(string[] args)
        {
            Console.WriteLine("Введите число А");
            int a = Convert.ToInt32(Console.ReadLine());
            for (int i = a; i <= 1000; i+=a)
            {
                Console.WriteLine(i);
            }
        }
    }
}
