using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circuls
{
    class Circuls8
    {
        static void CirculsEgth(string[] args)
        {
            Console.WriteLine("Ex8");
            Console.WriteLine("Введите число N");
            int kubeN = Convert.ToInt32(Console.ReadLine());
            int left = 0;
            int mid = 0;
            int right = kubeN;

            while (Math.Pow(mid, 3) != kubeN)
            {
                if (left < right)
                {
                    mid = (left + right) / 2;
                    if (Math.Pow(mid, 3) > kubeN)
                    { right = mid; }
                    else if (Math.Pow(mid, 3) < kubeN)
                    { left = mid; }
                }
                else if (left > right)
                {
                    mid = left;
                    mid = (mid + right) / 2;
                }
            }
            Console.WriteLine($"Результат: {mid}");
            Console.WriteLine();
        }
    }
}
