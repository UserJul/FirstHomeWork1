using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstHomeWork1.Branching_structure
{
    class BranchingStructure5
    {
        static void BranchingStructureFive(string[] args)
        {
            Console.WriteLine("Введите число");
            int number = Convert.ToInt32(Console.ReadLine());
            string unicalString = "";

            unicalString = number switch
            {
                10 => "десять",
                11 => "одиннадцать",
                12 => "двенадцать",
                13 => "тринадцать",
                14 => "четырнадцать",
                15 => "пятнадцать",
                16 => "шестнадцать",
                17 => "семьнадцать",
                18 => "восемьнадцать",
                19 => "девятнадцать",
                _ => "",
            };

            int tens = number / 10;
            int ones = number % 10;
            string ten = "";
            string one = "";

            ten = tens switch
            {
                2 => "двадцать",
                3 => "тридцать",
                4 => "сорок",
                5 => "пятьдесят",
                6 => "шестьдесят",
                7 => "семьдесят",
                8 => "восемьдесят",
                9 => "девяносто",
                _ => "",
            };
            one = ones switch
            {
                1 => " один",
                2 => " два",
                3 => " три",
                4 => " четыре",
                5 => " пять",
                6 => " шесть",
                7 => " семь",
                8 => " восемь",
                9 => " девять",
            };

            if (number < 10 && number > 99)
            {
                Console.WriteLine("Число не входит в диапазон") ;
            }
            else if(number >= 10 && number <= 19)
            {
                Console.WriteLine(unicalString); 
            }
            else
            {
                Console.WriteLine(ten + one);
            }

        }
    }
}
