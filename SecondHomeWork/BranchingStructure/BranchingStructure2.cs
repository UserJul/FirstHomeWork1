using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstHomeWork1.Branching_structure
{
    class BranchingStructure2
    {
        static void BranchingStructureTwo(string[] args)
        {
            Console.WriteLine("BranchingStructureSecond");
            Console.WriteLine("Введите значение X");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение Y");
            double y = Convert.ToDouble(Console.ReadLine());
            string result;
            if(x > 0 && y > 0)
            {
                result = "I";
            }
            else if( x < 0 && y > 0)
            {
                result = "II";
            }
            else if (x < 0 && y < 0)
            {
                result = "III";
            }
            else
            {
                result = "IV";
            }
            Console.WriteLine(result);
        }
    }
}
