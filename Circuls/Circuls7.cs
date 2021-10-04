using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circuls
{
    class Circuls7
    {
        static void CirculsSeven(string[] args)
        {
            Console.WriteLine("Ex7");
            Console.WriteLine("Введите число А");
            int evklidA = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число B");
            int evklidB = Convert.ToInt32(Console.ReadLine());
            int nod = 1;
            int tmpEvklid = 0;
            if (evklidA > evklidB)
            {
                while (evklidA != evklidB)
                {
                    evklidA = evklidA - evklidB;
                    if (evklidA < evklidB)
                    {
                        tmpEvklid = evklidB;
                        evklidB = evklidA;
                        evklidA = tmpEvklid;
                    }
                }
                nod = evklidB;
            }
            else if (evklidA < evklidB)
            {
                while (evklidA != evklidB)
                {
                    evklidB = evklidB - evklidA;
                    if (evklidB < evklidA)
                    {
                        tmpEvklid = evklidB;
                        evklidB = evklidA;
                        evklidA = tmpEvklid;
                    }
                }
                nod = evklidB;
            }
            else
            {
                nod = evklidA;
            }
            Console.WriteLine($"Результат: {nod}");
            Console.WriteLine();
        }
    }
}
