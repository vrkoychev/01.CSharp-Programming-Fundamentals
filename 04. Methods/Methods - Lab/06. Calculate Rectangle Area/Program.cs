using System;

namespace _06._Calculate_Rectangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int area = RectangleArea(a, b);
            Console.WriteLine(area);
        }

        static int RectangleArea(int a, int b)
        {
            int area = a * b;
            return area;
        }
    }
}
