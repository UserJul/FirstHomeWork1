using System;

namespace FirstHomeWork1
{
    class Variables1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("VariablesFirst");
            Console.WriteLine("Введите число А");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите число B");
            double b = Convert.ToDouble(Console.ReadLine());

            double c = (5 * a) + (b * b) / (b - a);

            Console.WriteLine(c);
            Console.WriteLine(" ");

    }
}
