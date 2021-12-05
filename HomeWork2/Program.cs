using System;

namespace HomeWork2
{
    class Program
    {
        static double Task1(double a, double b)
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

        static int Task2(double x, double y)
        {
            int quadrant;

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
            }
            else quadrant = 0;

            return quadrant;
        }

        static void Swap(ref double a, ref double b)
        {
            double temp = a;
            a = b;
            b = temp;
        }

        static void Task3(ref double a, ref double b, ref double c)
        {
            if (a > b) 
            {
                Swap(ref a, ref b);
            }
            if (a > c) 
            {
                Swap(ref a, ref c);
            }
            if (b > c) 
            {
                Swap(ref b, ref c);
            }
        }

        static (double x1, double x2, double d) Task4(double a, double b, double c)
        {
            double d = b * b - 4 * a * c;

            if (d >= 0)
            {
                double x1 = (-b - Math.Sqrt(d)) / (2 * a);
                double x2 = (-b + Math.Sqrt(d)) / (2 * a);
                return (x1, x2, d);
            }
            else
            {
                return (0, 0, d);
            }
        }

        static string Task5(int a)
        {
            string result = String.Empty;
            string s = a.ToString();
            char s1 = char.Parse(s.Substring(0, 1));
            char s2 = char.Parse(s.Substring(1, 1));

            if (a < 20)
            { 
            switch (a)
                { 
                    case 10: result += " десять"; break;
                    case 11: result += " одиннадцать"; break;
                    case 12: result += " двенадцать"; break;
                    case 13: result += " тринадцать"; break;
                    case 14: result += " четырнадцать"; break;
                    case 15: result += " пятнадцать"; break;
                    case 16: result += " шестнадцать"; break;
                    case 17: result += " семнадцать"; break;
                    case 18: result += " восемннадцать"; break;
                    case 19: result += " девятнадцать"; break;
                  }
            }
            else
            { 
                switch ((int)s1) 
                {
                    case 50: result = " двадцать"; break;
                    case 51: result = " тридцать"; break;
                    case 52: result = " сорок"; break;
                    case 53: result = " пятьдесят"; break;
                    case 54: result = " шестьдесят"; break;
                    case 55: result = " семьдесят"; break;
                    case 56: result = " восемьдесят"; break;
                    case 57: result = " девяносто"; break;
                }

                switch ((int)s2)
                {
                    case 50: result += " двадцать"; break;
                    case 51: result += " три"; break;
                    case 52: result += " четыре"; break;
                    case 53: result += " пять"; break;
                    case 54: result += " шесть"; break;
                    case 55: result += " семь"; break;
                    case 56: result += " восемь"; break;
                    case 57: result += " девять"; break;
                }
            }

            return result;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Task 1");
            Console.Write("Enter A value: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Enter B value: ");
            double b = double.Parse(Console.ReadLine());

            //Console.WriteLine("Task 1 result is " + Task1(a, b));


            //Console.WriteLine("Task 2");
            //Console.Write("Enter X value: ");
            //double x = double.Parse(Console.ReadLine());
            //Console.Write("Enter Y value: ");
            //double y = double.Parse(Console.ReadLine());

            //int quadrant = Task2(x, y);
            //if  (quadrant > 0) 
            //{ 
            //    Console.WriteLine("Point quadrant " + quadrant); 
            //}
            //else
            //{ 
            //    Console.WriteLine("Point is not in quadrants"); 
            //}


            //Console.WriteLine("Task 3");
            //Console.Write("Enter A value: ");
            //double a = double.Parse(Console.ReadLine());
            //Console.Write("Enter B value: ");
            //double b = double.Parse(Console.ReadLine());
            //Console.Write("Enter C value: ");
            //double c = double.Parse(Console.ReadLine());

            //Task3(ref a, ref b, ref c);
            //Console.WriteLine($"Now A = {a} B = {b} C =  {c}");


            //Console.WriteLine("Task 4");
            //Console.Write("Enter A value: ");
            //double a = double.Parse(Console.ReadLine());
            //Console.Write("Enter B value: ");
            //double b = double.Parse(Console.ReadLine());
            //Console.Write("Enter C value: ");
            //double c = double.Parse(Console.ReadLine());

            //(double x1, double x2, double d) result = Task4( a, b, c);
            //if (result.d > 0)
            //{
            //    Console.WriteLine("x1 = " + result.x1);
            //    Console.WriteLine("x2 = " + result.x2);
            //}
            //else if (result.d == 0)
            //{
            //    Console.WriteLine("x = " + result.x1);

            //}
            //else
            //{
            //    Console.WriteLine("Quadratic equation has no solution");
            //}


            //Console.WriteLine("Task 5");
            //Console.Write("Enter two-digit number: ");
            //int a = Convert.ToInt32(Console.ReadLine());
            //string s = Task5(a);
            //Console.WriteLine($"number A in words is {s}");
        }
    }
}
