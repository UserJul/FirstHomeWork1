using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstHomeWork1.Branching_structure
{
    class BranchingStructure4
    {
        static void BranchingStructureFour(string[] args)
        {
            Console.WriteLine("BranchingStructureThird");
            Console.WriteLine("Введите число А");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите число B");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите число C");
            double c = Convert.ToDouble(Console.ReadLine());

            double d = Math.Pow(b, 2) - 4 * a * c;
            double x1;
            double x2;
            if(d < 0)
            {
                Console.WriteLine("Корней нет");
            }
            else if(d == 0)
            {
                x1 = -b / 2*a;
                Console.WriteLine($"Один корень {x1}");
            }
            else
            {
                x1 = -b + Math.Sqrt(d) / 2 * a;
                x2 = -b - Math.Sqrt(d) / 2 * a;
                Console.WriteLine($"Два корня х1 = {x1}, х2 = {x2}");
            }
        }
       
    }
}

