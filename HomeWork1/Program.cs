using System;

namespace HomeWork1
{
    class Program
    {
        static void Task1()
        {
            Console.Write("Enter A value: ");
            double a = double.Parse( Console.ReadLine());
            Console.Write("Enter B value: ");
            double b = double.Parse(Console.ReadLine());

            double result =
                ((5 * a) + b * b) / (b - a);

            Console.WriteLine("Result is " + result);
        }

        static void Task2()
        {
            Console.Write("Enter first string: ");
            string a = Console.ReadLine();
            Console.Write("Enter second string: ");
            string b = Console.ReadLine();

            string c = a;
            a = b;
            b = c; 

            Console.WriteLine("A string value now is " + a);
            Console.WriteLine("B string value now is " + b);
        }

        static void Task3()
        {
            Console.Write("Enter A value: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter B value: ");
            int b = int.Parse(Console.ReadLine());

            int integerPart = (int)(a / b);

            double divisionRemainder = a - (integerPart * b);

            Console.WriteLine("Integer Part:" + integerPart);
            Console.WriteLine("Remainder of Division: " + divisionRemainder);
        }

        static void Task4()
        {
            Console.Write("Enter A value: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter B value: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Enter C value: ");
            int c = int.Parse(Console.ReadLine());

            double result = (double)(c - b) / a;

            Console.WriteLine("X = " + result);
        }

        static void Task5()
        {
            Console.Write("Enter X1 value: ");
            int x1 = int.Parse(Console.ReadLine());
            Console.Write("Enter Y1 value: ");
            int y1 = int.Parse(Console.ReadLine());
            Console.Write("Enter X2 value: ");
            int x2 = int.Parse(Console.ReadLine());
            Console.Write("Enter Y2 value: ");
            int y2 = int.Parse(Console.ReadLine());

            double a = (double)(y1 - y2) / (double)(x1 - x2);
            double b = (double)(y2 - a * x2);

            Console.WriteLine($"Y = {Math.Round(a,2)}x + {Math.Round(b,2)}");
        }


        static void Main(string[] args)
        {
            Task5();
        }
    }
}
