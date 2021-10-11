using System;

namespace DoubleArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] dobleArray1 = new int[3,4];

            Random random = new Random();
            for (int i = 0; i < dobleArray1.GetLength(0); i++)
            {
                for (int j = 0; j < dobleArray1.GetLength(1); j++)
                {
                    dobleArray1[i, j] = random.Next(-100, 100);
                    Console.Write(dobleArray1[i,j] + " ");
                }
                Console.WriteLine();
            }

            int minElement = dobleArray1[0, 0];

            for (int i = 0; i < dobleArray1.GetLength(0); i++)
            {
                for (int j = 0; j < dobleArray1.GetLength(1); j++)
                {
                    if (minElement > dobleArray1[i, j])
                    {
                        minElement = dobleArray1[i, j];
                    }
                }
            }
            Console.WriteLine(minElement);

            int[,] dobleArray2 = new int[3, 4];

           
            for (int i = 0; i < dobleArray2.GetLength(0); i++)
            {
                for (int j = 0; j < dobleArray2.GetLength(1); j++)
                {
                    dobleArray2[i, j] = random.Next(-100, 100);
                    Console.Write(dobleArray2[i, j] + " ");
                }
                Console.WriteLine();
            }

            int maxElement = dobleArray2[0, 0];

            for (int i = 0; i < dobleArray2.GetLength(0); i++)
            {
                for (int j = 0; j < dobleArray2.GetLength(1); j++)
                {
                    if (maxElement < dobleArray2[i, j])
                    {
                        maxElement = dobleArray2[i, j];
                    }
                }
            }
            Console.WriteLine(maxElement);

            int[,] dobleArray3 = new int[3, 4];


            for (int i = 0; i < dobleArray3.GetLength(0); i++)
            {
                for (int j = 0; j < dobleArray3.GetLength(1); j++)
                {
                    dobleArray3[i, j] = random.Next(-100, 100);
                    Console.Write(dobleArray3[i, j] + " ");
                }
                Console.WriteLine();
            }
            int[] indexOfMinElemen = new int[2];

            for (int i = 0; i < dobleArray3.GetLength(0); i++)
            {
                for (int j = 0; j < dobleArray3.GetLength(1); j++)
                {
                    if (minElement < dobleArray3[i, j])
                    {
                        minElement = dobleArray3[i, j];
                        indexOfMinElemen[0] = i;
                        indexOfMinElemen[1] = j;
                    }
                }
            }
            Console.WriteLine($"{indexOfMinElemen[0]}, {indexOfMinElemen[1]}");


            int[,] dobleArray4 = new int[3, 4];


            for (int i = 0; i < dobleArray4.GetLength(0); i++)
            {
                for (int j = 0; j < dobleArray4.GetLength(1); j++)
                {
                    dobleArray4[i, j] = random.Next(-100, 100);
                    Console.Write(dobleArray4[i, j] + " ");
                }
                Console.WriteLine();
            }
            int[] indexOfMaxElemen = new int[2];

            for (int i = 0; i < dobleArray4.GetLength(0); i++)
            {
                for (int j = 0; j < dobleArray4.GetLength(1); j++)
                {
                    if (maxElement < dobleArray4[i, j])
                    {
                        maxElement = dobleArray4[i, j];
                        indexOfMaxElemen[0] = i;
                        indexOfMaxElemen[1] = j;
                    }
                }
            }
            Console.WriteLine($"{indexOfMaxElemen[0]}, {indexOfMaxElemen[1]}");

            int[,] dobleArray5 = new int[3, 4];


            for (int i = 0; i < dobleArray5.GetLength(0); i++)
            {
                for (int j = 0; j < dobleArray5.GetLength(1); j++)
                {
                    dobleArray5[i, j] = random.Next(-100, 100);
                    Console.Write(dobleArray5[i, j] + " ");
                }
                Console.WriteLine();
            }
            int countOfElements = 0;
            int line = dobleArray5.GetLength(0);
            int column = dobleArray5.GetLength(1);

            for (int i = 0; i < dobleArray5.GetLength(0); i++)
            {
                for (int j = 0; j < dobleArray5.GetLength(1); j++)
                {
                    if (
                            ( i == 0 || dobleArray5[i,j] > dobleArray5[i -1, j]) &&
                            (i == line -1 || dobleArray5[i,j] > dobleArray5[i+1, j])&&
                            (j == 0 || dobleArray5[i, j] > dobleArray5[i, j-1]) &&
                            (j == column - 1 || dobleArray5[i, j] > dobleArray5[i, j+1])
                        )

                    {
                        countOfElements++;
                    }
                }
            }
            Console.WriteLine(countOfElements);


            int[,] dobleArray6 = new int[4, 4];


            for (int i = 0; i < dobleArray6.GetLength(0); i++)
            {
                for (int j = 0; j < dobleArray6.GetLength(1); j++)
                {
                    dobleArray6[i, j] = random.Next(-100, 100);
                    Console.Write(dobleArray6[i, j] + " ");
                }
                Console.WriteLine();
            }
            int tmp = 0;

            for (int i = 0; i < dobleArray6.GetLength(0); i++)
            {
                for (int j = i + 1; j < dobleArray6.GetLength(1); j++)
                {
                    tmp = dobleArray6[i, j];
                    dobleArray6[i, j] = dobleArray6[j, i ];
                    dobleArray6[j, i ] = tmp;
                }
            }
            Console.WriteLine();

            for (int i = 0; i < dobleArray6.GetLength(0); i++)
            {
                for (int j = 0; j < dobleArray6.GetLength(1); j++)
                {
                    Console.Write(dobleArray6[i, j] + " ");
                }
                Console.WriteLine();
            }

        }
    }
}
