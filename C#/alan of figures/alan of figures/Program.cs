using System;

namespace alan_of_figures
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CalculateArea(2));
            Console.WriteLine(CalculateArea(2, 3));
            Console.WriteLine(CalculateArea(2, 3, 4));
        }


        static int CalculateArea(int a)
        {
            int area = 3 * a * a;
            return area;
        }
        static int CalculateArea(int a, int b)
        {
            int area = a * b;
            return area;
        }
        static int CalculateArea(int a, int b, int c)
        {
            int area = 2 * (a * b + a * c + b * c);
            return area;
        }

    }
}

