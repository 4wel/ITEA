using System;

namespace HomeWork4
{
    class Program
    {
        static int MinElement(int[] array)
        {
            int result = array[0];

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < result)
                {
                    result = array[i];
                }
            }

            return result;
        }

        static int MaxElement(int[] array)
        {
            int result = array[0];

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > result)
                {
                    result = array[i];
                }
            }

            return result;
        }

        static int MinElementIndex(int[] array)
        {
            int minElement = array[0];
            int minElementIndex = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < minElement)
                {
                    minElement = array[i];
                    minElementIndex = i;
                }
            }

            return minElementIndex;
        }

        static int MaxElementIndex(int[] array)
        {
            int maxlement = array[0];
            int maxElementIndex = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > maxlement)
                {
                    maxlement = array[i];
                    maxElementIndex = i;
                }
            }

            return maxElementIndex;
        }

        static int SumOddIndexElements(int[] array)
        {
            int sum = 0;

            for (int i = 1; i < array.Length; i+=2)
            {
                sum += array[i];
            }

            return sum;
        }

        static void ReverseArray(ref int[] array)
        {
            int lenght = array.Length;
            int[] newArray = new int[lenght];

            for (int i = 0; i < lenght; i++ )
            {
                newArray[lenght - i - 1] = array[i];
            }

            array = newArray;
        }

        static int SumOddElements(int[] array)
        {
            int count = 0;

            for (int i = 0; i < array.Length; i ++)
            {
                if (array[i] % 2 != 0)
                {
                    count++;
                }
            }

            return count;
        }

        static void HalfSwapArray(ref int[] array)
        {
            for (int i = 0; i < array.Length / 2; i++)
            {
                Swap(ref array[i], ref array[array.Length - array.Length / 2 + i]);
            }
        }

        static void SelectionSortArrayAsc(ref int[] array)
        {
            int min = 0;

            for (int i = 0; i < array.Length; i++)
            {
                min = i;

                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[min] > array[j])
                    {
                        min = j;
                    }
                }

                Swap(ref array[i], ref array[min]);
            }
        }

        static void InsertionSortArrayDesc(ref int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i; j > 0; j--)
                {
                    if (array[j] > array[j - 1])
                    {
                        Swap(ref array[j], ref array[j - 1]);
                    }
                    else
                    {
                        break;
                    }
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
            int N = 7;
            int[] array = new int[N];
            Random random = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(0, 10);
            }

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]} ");
            }

            Console.WriteLine();

            HalfSwapArray(ref array);

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]} ");
            }
        }
    }
}
