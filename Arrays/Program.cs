using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];
            Random random = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(1, 100);
            }

            int minItem = array[0];

            for (int i = 0; i < array.Length; i++)
            {
                if (minItem > array[i])
                {
                    minItem = array[i];
                }
                Console.Write(array[i] + " ");
            }
            Console.WriteLine($"\n{minItem}");



            Console.WriteLine("Array2");

            int[] arraySecond = new int[10];

            for (int i = 0; i < arraySecond.Length; i++)
            {
                arraySecond[i] = random.Next(1, 100);
            }

            int maxItem = arraySecond[0];

            for (int i = 0; i < arraySecond.Length; i++)
            {
                if (maxItem < arraySecond[i])
                {
                    maxItem = arraySecond[i];
                }
                Console.Write(arraySecond[i] + " ");
            }
            Console.WriteLine($"\n{maxItem}");


            Console.WriteLine("Array3");

            int[] arrayThird = new int[10];
            for (int i = 0; i < arrayThird.Length; i++)
            {
                arrayThird[i] = random.Next(1, 100);
            }
            int minIndex = 0;
            int minItem3 = arrayThird[0];

            for (int i = 0; i < arrayThird.Length; i++)
            {
                if (minItem3 > arrayThird[i])
                {
                    minItem3 = arrayThird[i];
                    minIndex = i;
                }
                Console.Write(arrayThird[i] + " ");
            }
            Console.WriteLine($"\n{minIndex}");


            Console.WriteLine("Array4");

            int[] arrayFour = new int[10];
            for (int i = 0; i < arrayThird.Length; i++)
            {
                arrayFour[i] = random.Next(1, 100);
            }
            int maxIndex4 = 0;
            int maxItem4 = arrayFour[0];

            for (int i = 0; i < arrayFour.Length; i++)
            {
                if (maxItem4 < arrayFour[i])
                {
                    maxItem4 = arrayFour[i];
                    maxIndex4 = i;
                }
                Console.Write(arrayFour[i] + " ");
            }
            Console.WriteLine($"\n{maxIndex4}");


            Console.WriteLine("Array5");

            int[] arrayFive = new int[4];
            for (int i = 0; i < arrayFive.Length; i++)
            {
                arrayFive[i] = random.Next(1, 100);
            }
            int sumElementsOfNecetIndex = 0;


            for (int i = 0; i < arrayFive.Length; i++)
            {
                if (i % 2 != 0)
                {
                    sumElementsOfNecetIndex += arrayFive[i];
                }
                Console.Write(arrayFive[i] + " ");
            }
            Console.WriteLine($"\n{sumElementsOfNecetIndex}");


            Console.WriteLine("Array6");

            int[] arraySix = new int[10];
            for (int i = 0; i < arraySix.Length; i++)
            {
                arraySix[i] = random.Next(1, 100);
            }
            for (int i = 0; i < arraySix.Length; i++)
            {
                Console.Write(arraySix[i] + " ");
            }

            for (int i = 0; i < arraySix.Length / 2; i++)
            {
                int tmp = arraySix[i];
                arraySix[i] = arraySix[arraySix.Length - i - 1];
               arraySix[arraySix.Length - i - 1] = tmp;
            }

            for (int i = 0; i < arraySix.Length; i++)
            {
                Console.Write(arraySix[i] + " ");
            }


            Console.WriteLine("Array7");

            int[] arraySeven = new int[10];

            for (int i = 0; i < arraySeven.Length; i++)
            {
                arraySeven[i] = random.Next(1, 100);
            }
            int sumElementsOfNecet = 0;

            for (int i = 0; i < arraySeven.Length; i++)
            {
                if (arraySeven[i] % 2 != 0)
                {
                    sumElementsOfNecet += 1;
                }
                Console.Write(arraySeven[i] + " ");
            }
            Console.WriteLine($"\n{sumElementsOfNecet}");



            Console.WriteLine("Array8");

            int[] arrayEgth = new int[10];

            for (int i = 0; i < arrayEgth.Length; i++)
            {
                arrayEgth[i] = random.Next(1, 100);
            }

            for (int i = 0; i < arrayEgth.Length; i++)
            {
                Console.Write(arrayEgth[i] + " ");
            }

            Console.WriteLine();

            int j1 = arrayEgth.Length / 2;
            int tmpOddArray = 0;
            int tmpForEhth = 0;

            if (arrayEgth.Length % 2!= 0)
            {
                tmpOddArray = 1;
            }
            
            for (int i = 0; i < j1; i++)
            {
                tmpForEhth = arrayEgth[i];
                arrayEgth[i] = arrayEgth[i + j1 + tmpOddArray];
                arrayEgth[i + j1 + tmpOddArray] = tmpForEhth;

            }

            for (int i = 0; i < arrayEgth.Length; i++)
            {
                Console.Write(arrayEgth[i] + " ");
            }


            Console.WriteLine();


            Console.WriteLine("Array9");

            int[] arrayNine = new int[10];

            for (int i = 0; i < arrayNine.Length; i++)
            {
                arrayNine[i] = random.Next(1, 100);
            }
            for (int i = 0; i < arrayNine.Length; i++)
            {
                Console.Write(arrayNine[i] + " ");
            }

            Console.WriteLine();

            int tmpSortBubble = arrayNine[0];

            for (int i = 0; i < arrayNine.Length -1; i++)
            {
                for (int j = 0; j < arrayNine.Length - i - 1; j++)
                {
                    if(arrayNine[j +1] < arrayNine[j])
                    {
                        tmpSortBubble = arrayNine[j + 1];
                        arrayNine[j + 1] = arrayNine[j];
                        arrayNine[j] = tmpSortBubble;
                    }
                }
            }
            for (int i = 0; i < arrayNine.Length; i++)
            {
                Console.Write(arrayNine[i] + " ");
            }
            Console.WriteLine();

            Console.WriteLine("Array10");

            int[] arrayTen = new int[10];   

            for (int i = 0; i < arrayTen.Length; i++)
            {
                arrayTen[i] = random.Next(1, 100);
            }
            for (int i = 0; i < arrayTen.Length; i++)
            {
                Console.Write(arrayTen[i] + " ");
            }
            Console.WriteLine();

            for (int i = 1; i < arrayTen.Length; i++)
            {
                int tmp = arrayTen[i];
                int j = i;                                                                                                                                                                                                                          
                while (j > 0 && tmp < arrayTen[j -1])
                {
                    arrayTen[j] = arrayTen[j - 1];
                    j--;
                }
                arrayTen[j] = tmp;
            }
            for (int i = 0; i < arrayTen.Length; i++)
            {
                Console.Write(arrayTen[i] + " ");
            }
            Console.WriteLine();

        }
    }
    }

