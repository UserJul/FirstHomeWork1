using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstHomeWork1
{
    class Variables2
    {
        static void VariablesSecond(string[] args)
        {
            Console.WriteLine("VariablesSecond");
            Console.WriteLine("Введите число А");
            string a2 = Console.ReadLine();
            Console.WriteLine("Введите число B");
            string b2 = Console.ReadLine();

            string c2 = a2;
            a2 = b2;
            b2 = c2;

            Console.WriteLine($"{a2}, {b2}");
            

        }
    }
}
