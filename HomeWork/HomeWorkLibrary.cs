using System;

namespace HomeWorkLibrary
{
    public class HWLibrary
    {
        public static void SwapDouble(ref double a, ref double b)
        {
            double temp = a;
            a = b;
            b = temp;
        }

        public static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        public static double CalculateEquation(double a, double b)
        {
            if (b == a)
            {
                throw new ArgumentException("A equal to B!");
            }

            return ((5 * a) + b * b) / (b - a);
        }

        public static(int integerPart, double divisionRemainder) IntegerDivisionRemainderParts(int a, int b)
        {
            if (b == a)
            {
                throw new ArgumentException("A equal to B!");
            }

            int integerPart = (int)(a / b);
            double divisionRemainder = a - (integerPart * b);

            return (integerPart, divisionRemainder);
        }

        public static double CalculateEquation2(int a, int b, int c)
        {
            if (a == 0)
            {
                throw new ArgumentException("A equal zero!");
            }

            return (double)(c - b) / a; 
        }

        public static(double a, double b) LineCoefficients(int x1, int y1, int x2, int y2)
        {
            if (x1 == x2)
            {
                throw new DivideByZeroException();
            }

            double a = (double)(y1 - y2) / (double)(x1 - x2);
            double b = (double)(y2 - a * x2);

            return (a, b);
        }

        public static double Compare(double a, double b)
        {
            double result;
            if (a > b)
            {
                result = a + b;
            }
            else if (a == b)
            {
                result = a * b;
            }
            else
            {
                result = a - b;
            }

            return result;
        }

        public static int Quadrant(double x, double y)
        {
            if (x == 0 || y == 0)
            {
                throw new ArgumentException("Point is on axial");
            }

            int quadrant = 0;

            if (x > 0 && y > 0)
            {
                quadrant = 1;
            }
            else if (x < 0 && y > 0)
            {
                quadrant = 2;
            }
            else if (x < 0 && y < 0)
            {
                quadrant = 3;
            }
            else if (x > 0 && y < 0)
            {
                quadrant = 4;
            };

            return quadrant;
        }

        public static void SortAsc(ref double a, ref double b, ref double c)
        {
            if (a > b)
            {
                SwapDouble(ref a, ref b);
            }
            if (a > c)
            {
                SwapDouble(ref a, ref c);
            }
            if (b > c)
            {
                SwapDouble(ref b, ref c);
            }
        }

        public static (double x1, double x2) QuadraticEquation(double a, double b, double c)
        {
            double d = b * b - 4 * a * c;

            if (d < 0)
            {
                throw new ArgumentException("Quadratic equation has no real roots!");
            }

            if (a == 0)
            {
                throw new DivideByZeroException();
            }

            double x1 = (-b - Math.Sqrt(d)) / (2 * a);
            double x2 = (-b + Math.Sqrt(d)) / (2 * a);
            return (x1, x2);
        }

        public static string NumbersInWords(int a)
        {
            if (a < 0)
            {
                throw new ArgumentException("The number must be greater than 0!");
            }

            if (a < 10)
            {
                throw new ArgumentException("The number must be greater than 10!");
            }

            string result = String.Empty;
            string s = a.ToString();
            char s1 = char.Parse(s.Substring(0, 1));
            char s2 = char.Parse(s.Substring(1, 1));

            if (a < 20)
            {
                switch (a)
                {
                    case 10: result += "ten"; break;
                    case 11: result += "eleven"; break;
                    case 12: result += "twelve"; break;
                    case 13: result += "thirteen"; break;
                    case 14: result += "fourteen"; break;
                    case 15: result += "fifteen"; break;
                    case 16: result += "sixteen"; break;
                    case 17: result += "seventeen"; break;
                    case 18: result += "eighteen"; break;
                    case 19: result += "nineteen"; break;
                }
            }
            else
            {
                switch ((int)s1)
                {
                    case 50: result = "twenty"; break;
                    case 51: result = "thirty"; break;
                    case 52: result = "forty"; break;
                    case 53: result = "fifty"; break;
                    case 54: result = "sixty"; break;
                    case 55: result = "seventy"; break;
                    case 56: result = "eighty"; break;
                    case 57: result = "ninety"; break;
                }

                switch ((int)s2)
                {
                    case 49: result += " one"; break;
                    case 50: result += " two"; break;
                    case 51: result += " three"; break;
                    case 52: result += " four"; break;
                    case 53: result += " five"; break;
                    case 54: result += " six"; break;
                    case 55: result += " seven"; break;
                    case 56: result += " eight"; break;
                    case 57: result += " nine"; break;
                }
            }

            return result;
        }

        public static double ADegreeB(int a, int b)
        {
            if (a < 0)
            {
                throw new ArgumentException("The number A must be greater than 0!");
            }

            double result = a;

            if (b > 0)
            {
                for (int i = 1; i < b; i++)
                {
                    result *= a;
                }
            }
            else if (b < 0)
            {
                for (int i = 1; i < -1 * b; i++)
                {
                    result *= a;
                }
                
                if (result == 0)
                {
                    throw new DivideByZeroException();
                }

                result = (double)(1 / result);
            }
            else
            {
                result = 1;
            }

            return result;
        }

        public static int[] DivisibleByA(int a)
        {
            if (a == 0)
            {
                throw new DivideByZeroException();
            }

            int[] arr = { };
            int num = 0;

            for (int i = 1; i <= 1000; i++)
            {
                if (i % a == 0)
                {
                    Array.Resize(ref arr, arr.Length + 1);
                    arr[num] = i;
                    num++;
                }
            }

            return arr;
        }

        public static int RealNumberCountSquareMoreThanA(int a)
        {
            if (a < 0)
            {
                throw new ArgumentException("The number must be greater than 0!");
            }

            int result = 0;
            for (int i = 1; i < a; i++)
            {
                if (i * i < a)
                {
                    result++;
                }
            }

            return result;
        }

        public static int MaxDivisor(int a)
        {
            if (a < 0)
            {
                throw new ArgumentException("The number must be greater than 0!");
            }

            int divisor = 0;

            for (int i = a - 1; i > 0; i--)
            {
                if (a % i == 0)
                {
                    divisor = i;
                    break;
                }
            }

            return divisor;
        }

        public static int DivisibleBy7(int a, int b)
        {
            int sum = 0;

            if (b < a)
            {
                Swap(ref a, ref b);
            }
            for (int i = a; i <= b; i++)
            {
                if (i % 7 == 0)
                {
                    sum += i;
                }
            }

            return sum;
        }

        public static long FibonacciNNumber(int n)
        {
            if (n < 0)
            {
                throw new ArgumentException("The number must be greater than 0!");
            }

            long lastValue = 0;
            long newValue = 1;

            for (int i = 1; i < n; i++)
            {
                long prevValue = lastValue;
                lastValue = newValue;
                newValue = prevValue + newValue;
            }

            return newValue;
        }

        public static int MaxDivisorByEuclideanAlgorithm(int a, int b)
        {
            while ((a != 0) && (b != 0))
            {
                if (a > b)
                {
                    a -= b;
                }
                else
                {
                    b -= a;
                }
            }

            return Math.Max(a, b);
        }

        public static long FindByBisectionMethod(int a)
        {
            long left = 0;
            long right = a;
            long lenght = 0;
            long x = 0;

            while (right - left > 1)
            {
                lenght = right - left;
                x = left + lenght / 2;
                if (x * x * x < a)
                {
                    left = x;
                }
                else
                {
                    right = x;
                };

                if (x * x * x == a)
                {
                    break;
                }
            }

            return x;
        }

        public static (int countEven, int countOdd) CountEvenOdd(int n)
        {
            int countEven = 0;
            int countOdd = 0;

            if (n == 0)
            {
                countEven = 1;
            }
            else
            {
                while (n != 0)
                {
                    if (n % 2 == 0)
                    {
                        countEven++;
                    }
                    else
                    {
                        countOdd++;
                    }
                    n /= 10;
                }
            }

            return (countEven, countOdd);
        }

        public static int Palindromic(int n)
        {
            int result = 0;
            while (n != 0)
            {
                int currentDigit = n % 10;
                n /= 10;
                result *= 10;
                result += currentDigit;
            }

            return result;
        }

        public static int[] EvenMoreOdd(int n)
        {
            int[] arr = new int[n];

            for (int i = 1; i <= n; i++)
            {
                (int countEven, int countOdd) = CountEvenOdd(i);
                if (countEven > countOdd)
                {
                    arr[i] = i;
                }
            }

            return arr;
        }

        public static bool IsIntersectionExists(int a, int b)
        {
            bool result = false;
            int btemp = b;

            while (a != 0)
            {
                int currentDigitA = a % 10;
                a /= 10;
                btemp = b;

                while (btemp != 0)
                {
                    int currentDigitB = btemp % 10;
                    btemp /= 10;
                    if (currentDigitB == currentDigitA)
                    {
                        result = true;
                        a = 0;
                        break;
                    }
                }
            }

            return result;
        }

        public static int MinElement(int[] array)
        {
            if (array.Length == 0)
            {
                throw new ArgumentNullException();
            }

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

        public static int MaxElement(int[] array)
        {
            if (array.Length == 0)
            {
                throw new ArgumentNullException();
            }

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

        public static int MinElementIndex(int[] array)
        {
            if (array.Length == 0)
            {
                throw new ArgumentNullException();
            }

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

        public static int MaxElementIndex(int[] array)
        {
            if (array.Length == 0)
            {
                throw new ArgumentNullException();
            }

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

        public static int SumOddIndexElements(int[] array)
        {
            int sum = 0;

            for (int i = 1; i < array.Length; i += 2)
            {
                sum += array[i];
            }

            return sum;
        }

        public static void ReverseArray(ref int[] array)
        {
            int lenght = array.Length;
            int[] newArray = new int[lenght];

            for (int i = 0; i < lenght; i++)
            {
                newArray[lenght - i - 1] = array[i];
            }

            array = newArray;
        }

        public static int SumOddElements(int[] array)
        {
            int count = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0)
                {
                    count++;
                }
            }

            return count;
        }

        public static void HalfSwapArray(ref int[] array)
        {
            for (int i = 0; i < array.Length / 2; i++)
            {
                Swap(ref array[i], ref array[array.Length - array.Length / 2 + i]);
            }
        }

        public static void SelectionSortArrayAsc(ref int[] array)
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

        public static void InsertionSortArrayDesc(ref int[] array)
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

        public static int MinElement(int[,] array)
        {
            if (array == null)
            {
                throw new ArgumentNullException();
            }

            (int i, int j) = MinElementIndex(array);

            return array[i, j];
        }

        public static int MaxElement(int[,] array)
        {
            if (array == null)
            {
                throw new ArgumentNullException();
            }

            (int i, int j) = MaxElementIndex(array);

            return array[i, j];
        }

        public static (int iMin, int jMin) MinElementIndex(int[,] array)
        {
            if (array == null)
            {
                throw new ArgumentNullException();
            }

            int iMin = 0;
            int jMin = 0;

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] < array[iMin, jMin])
                    {
                        iMin = i;
                        jMin = j;
                    }
                }
            }

            return (iMin, jMin);
        }

        public static (int iMax, int jMax) MaxElementIndex(int[,] arr)
        {
            if (arr == null)
            {
                throw new ArgumentNullException();
            }

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

        public static int MoreThanAdjacentElementsCount(int[,] array)
        {
            if (array.GetLength(0) == 0)
            {
                throw new ArgumentNullException();
            }
            if (array.GetLength(1) == 0)
            {
                throw new ArgumentNullException();
            }

            int elementsCount = 0;
            int iLenght = array.GetLength(0);
            int jLenght = array.GetLength(1);

            for (int i = 0; i < iLenght; i++)
            {
                for (int j = 0; j < jLenght; j++)
                {
                    if (i == 0 || array[i, j] > array[i - 1, j])
                    {
                        if (i == iLenght - 1 || array[i, j] > array[i + 1, j])
                        {
                            if (j == 0 || array[i, j] > array[i, j - 1])
                            {
                                if (j == jLenght - 1 || array[i, j] > array[i, j + 1])
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

        public static void ReverseArrayByDiagonal(ref int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = i; j < array.GetLength(1); j++)
                {
                    Swap(ref array[i, j], ref array[j, i]);
                }
            }
        }

    }
}
