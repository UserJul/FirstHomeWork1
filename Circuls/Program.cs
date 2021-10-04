using System;

namespace Circuls
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ex11");
            Console.WriteLine("Введите число N");
            int n = Convert.ToInt32(Console.ReadLine());
            int sumChet = 0;
            int sumNechet = 0;
            int tmp = 0;
            int tmp2 = 0;
            for (int i = 1; i <= n; i++)
            {
                tmp2 = i;
                while (tmp2 != 0)
                {
                    tmp = i % 10;
                    tmp2 = i;
                    if (tmp % 2 == 0)
                    {
                        sumChet += tmp;
                    }
                    else
                    {
                        sumNechet += tmp;
                    }
                    if (sumChet > sumNechet)
                    {
                        Console.WriteLine(i);
                    }
                    tmp2 = i / 10;
                }
            }
        }
    }
}

