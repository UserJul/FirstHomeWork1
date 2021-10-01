using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstHomeWork1.Branching_structure
{
    class BranchingStructure3
    {
        static void BranchingStructureTree(string[] args)
        {
            Console.WriteLine("BranchingStructureThird");
            Console.WriteLine("Введите число А");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите число B");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите число C");
            double c = Convert.ToDouble(Console.ReadLine());

            if(a < b && b < c)
            {
                Console.WriteLine($"{a},{b},{c}");
            }
            else if (b < a && a < c)
            {
                Console.WriteLine($"{b},{a},{c}");
            }
            else if (c < a && a < b)
            {
                Console.WriteLine($"{c},{a},{b}");
            }
            else if (a < c && c < b)
            {
                Console.WriteLine($"{a},{c},{b}");
            }
            else if (b < c && c < a)
            {
                Console.WriteLine($"{b},{c},{a}");
            }
            else
            {
                Console.WriteLine($"{c},{b},{a}");
            }
        }
    }
}
