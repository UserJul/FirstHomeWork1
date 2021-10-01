using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstHomeWork1.Branching_structure
{
    class BranchingStructure1
    {
        static void BranchingStructureOne(string[] args)
        {
            Console.WriteLine("BranchingStructureFirst");
            Console.WriteLine("Введите число А");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите число B");
            double b = Convert.ToDouble(Console.ReadLine());

            double result;
            if(a > b)
            {
                result = a + b;
            }
            else if (a == b)
            {
                result = a * b;
            }
            else
            {
                result = a - b;
            }
            Console.WriteLine($"Результат = {result}");
        }
    }
}
