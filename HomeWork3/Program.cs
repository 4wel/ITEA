using System;

namespace HomeWork3
{
    class Program
    {
        static int Task1(int a, int b)
        {
            int result = a;
            for (int i = 1; i < b; i++)
            {
                result *= a;
            }

            return result;
        }

        static void Task2(int a)
        {
            for (int i = 1; i <= 1000; i++)
            {
                if (i % a == 0)
                { 
                    Console.WriteLine(i); 
                }
            }
        }

        static int Task3(int a)
        {
            int i = 1;
         
            while (i * i < a)
            {
                i++;
            }

            return i-1;
        }

        static int Task4(int a)
        {
            int divisor = 0;
            int i = 1;

            while (i < a)
            {
                if (a % i == 0) 
                {
                    divisor = i;
                } 
                i++;
            }

            return divisor;
        }

        static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        static int Task5(int a, int b)
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
                i++;
            }

            return sum;
        }

        static long Task6(int n)
        {
            long lastValue = 0;
            long newValue = 1;

            for (int i = 1; i <= n; i++ )
            {
                long prevValue = lastValue;
                lastValue = newValue;
                newValue = prevValue + newValue;
            }

            return lastValue;
        }

        static int Task7(int a, int b)
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

        static long Task8(int a)
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

        static (int countEven, int countOdd) Task9CountEvenOdd(int n)
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

        static int Task10(int n)
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

        static int Task11(int n)
        {
            int count = 0;

            for (int i = 1; i <= n; i++)
            {
                (int countEven, int countOdd) = Task9CountEvenOdd(i);
                if (countEven > countOdd)
                {
                    count++;
                }
            }

            return count;
        }

        static bool Task12(int a, int b)
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

        static void Main(string[] args)
        {
        }
    }
}
