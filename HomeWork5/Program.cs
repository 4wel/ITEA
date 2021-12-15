using System;

namespace HomeWork5
{
    class Program
    {
        static int MinElement(int[,] arr)
        {
            (int i, int j) = MinElementIndex(arr);

            return arr[i, j];
        }

        static int MaxElement(int[,] arr)
        {
            (int i, int j) = MaxElementIndex(arr);

            return arr[i, j];
        }

        static (int iMin, int jMin) MinElementIndex(int[,] arr)
        {
            int iMin = 0;
            int jMin = 0;

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (arr[i, j] < arr[iMin, jMin])
                    {
                        iMin = i;
                        jMin = j;
                    }
                }
            }

            return (iMin, jMin);
        }

        static (int iMax, int jMax) MaxElementIndex(int[,] arr)
        {
            int iMax = 0;
            int jMax = 0;

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (arr[i, j] > arr[iMax, jMax])
                    {
                        iMax = i;
                        jMax = j;
                    }
                }
            }

            return (iMax, jMax);
        }

        static int MoreThanAdjacentElementsCount(int[,] arr)
        {
            int elementsCount = 0;
            int iLenght = arr.GetLength(0);
            int jLenght = arr.GetLength(1);

            for (int i = 0; i < iLenght; i++)
            {
                for (int j = 0; j < jLenght; j++)
                {
                    if (i == 0 || arr[i, j] > arr[i - 1, j])
                    {
                        if (i == iLenght - 1 || arr[i, j] > arr[i + 1, j])
                        {
                            if (j == 0 || arr[i, j] > arr[i, j - 1])
                            {
                                if (j == jLenght - 1 || arr[i, j] > arr[i, j + 1])
                                {
                                    ++elementsCount;
                                }
                            }
                        }
                    }
                }
            }

            return elementsCount;
        }

        static void ReverseArrayByDiagonal(ref int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = i; j < arr.GetLength(1); j++ )
                {
                    Swap(ref arr[i, j], ref arr[j, i]);
                }
            }
        }

        static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        static void Main(string[] args)
        {
            int[,] arr = new int[5, 5];
            Random random = new Random();

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = random.Next(0, 100);
                }
            }

            Console.WriteLine(MinElement(arr));
            Console.WriteLine(MaxElement(arr));
            Console.WriteLine(MinElementIndex(arr));
            Console.WriteLine(MaxElementIndex(arr));
            Console.WriteLine(MoreThanAdjacentElementsCount(arr));

            Console.WriteLine();

            //for (int i = 0; i < arr.GetLength(0); i++)
            //{
            //    for (int j = 0; j < arr.GetLength(1); j++)
            //    {
            //        Console.Write(arr[i, j] + "  ");
            //    }

            //    Console.WriteLine();
            //}

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i, j] + "  ");
                }

                Console.WriteLine();
            }



        }
    }
}
